using System.Web.Http;
using System.Web.Security;
using MasterDataModule.API.Models;

namespace MasterDataModule.API.Controllers
{
	public class LogoutController : ApiController
	{
		[Authorize]
		public IHttpActionResult Post()
		{
			FormsAuthentication.SignOut();

			return Ok(new LoggedUserModel());
		}
	}
}