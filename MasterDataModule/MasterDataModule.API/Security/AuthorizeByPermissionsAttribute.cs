using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using MasterDataModule.Contracts.Managers;

namespace MasterDataModule.API.Security
{
    public class AuthorizeByPermissionsAttribute : AuthorizeAttribute
    {
        #region	Private fields
        private readonly IUserManager _userManager;
        private PermissionTypes[] _permissionTypes;
        #endregion
        #region Constructor
        public AuthorizeByPermissionsAttribute()
        {
            //TODO Should be refactored
            _userManager = (IUserManager) GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof (IUserManager));
            PermissionTypes = new PermissionTypes[0];
        }
        #endregion
        public PermissionTypes[] PermissionTypes
        {
            get { return _permissionTypes; }
            set { _permissionTypes = value ?? new PermissionTypes[0]; }
        }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            if (actionContext.RequestContext.Principal == null &&
                actionContext.RequestContext.Principal.Identity == null &&
                !actionContext.RequestContext.Principal.Identity.IsAuthenticated)
            {
                return false;
            }

            var userName = actionContext.RequestContext.Principal.Identity.Name;

            var user = _userManager.GetByLogin(userName);

            if (user == null || user.Role == null)
            {
                return false;
            }

            var userPermissionIds = user.Role.Permissions.Select(o => o.Id).ToList();
            var intersection = userPermissionIds.Intersect(PermissionTypes.Select(o => (int) o));

            return intersection.Any();
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            if (actionContext.RequestContext.Principal != null &&
                actionContext.RequestContext.Principal.Identity != null &&
                actionContext.RequestContext.Principal.Identity.IsAuthenticated)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
            }
            else
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
        }
    }
}