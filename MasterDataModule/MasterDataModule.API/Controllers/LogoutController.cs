using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;
using System.Web.Http;
using System.Web.Security;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers
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