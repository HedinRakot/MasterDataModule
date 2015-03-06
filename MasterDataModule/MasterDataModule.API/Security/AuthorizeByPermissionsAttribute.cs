using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using Microsoft.Practices.Unity;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Security
{
	public class AuthorizeByPermissionsAttribute : System.Web.Http.AuthorizeAttribute
	{
	    private readonly IUserManager userManager;

	    public AuthorizeByPermissionsAttribute()
	    {
            //TODO Should be refactored
	       userManager = (IUserManager)GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof (IUserManager));
	    }

	    private PermissionTypes[] _permissionTypes;
		public PermissionTypes[] PermissionTypes
		{
			get { return _permissionTypes ?? new PermissionTypes[0]; }
			set { _permissionTypes = value; }
		}

	    protected override bool IsAuthorized(HttpActionContext actionContext)
		{
			if (actionContext.RequestContext.Principal == null &&
				actionContext.RequestContext.Principal.Identity == null &&
				!actionContext.RequestContext.Principal.Identity.IsAuthenticated)
				return false;
            
			var userName = actionContext.RequestContext.Principal.Identity.Name;

            var user = userManager.GetByLogin(userName);

			if (user == null || user.Role == null)
				return false;

			var userPermissionIds = user.Role.Permissions.Select(o => o.Id).ToList();
			var intersection = userPermissionIds.Intersect(PermissionTypes.Select(o => (int)o));

			return intersection.Any();
		}

		protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
		{
			if (actionContext.RequestContext.Principal != null &&
				actionContext.RequestContext.Principal.Identity != null &&
				actionContext.RequestContext.Principal.Identity.IsAuthenticated)
				actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
			else
				actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
		}
	}
}
