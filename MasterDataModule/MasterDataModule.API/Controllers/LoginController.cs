using System.Linq;
using System.Web.Http;
using System.Web.Security;
using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using TuevSued.V1.IT.FE.CoreBase;

namespace MasterDataModule.API.Controllers
{
	public class LoginController : ApiController
	{
	    private readonly IUserManager _userManager;

	    public LoginController(IUserManager userManager)
	    {
	        this._userManager = userManager;
	    }

	    public IHttpActionResult Post([FromBody]LoginModel loginModel)
		{
			if (ModelState.IsValid)
			{
                var user = _userManager.GetByLogin(loginModel.Login);
				if (user != null && user.Password == StringHelper.GetMD5Hash(loginModel.Password))
				{
					FormsAuthentication.SetAuthCookie(loginModel.Login, loginModel.RememberMe);
					return Ok(new LoggedUserModel
					{
						IsAuthenticated = true,
						Login = user.Login,
						Name = user.Name,
						Permissions = user.Role.Permissions.ToDictionary(o => o.SystemName, o => true)
					});
				}

				ModelState.AddModelError("login", "invalid");
			}
			
			return BadRequest(ModelState);
		}

		public IHttpActionResult Patch([FromBody]LoggedUserModel model)
		{
			return Ok(model);			
		}		
	}
}