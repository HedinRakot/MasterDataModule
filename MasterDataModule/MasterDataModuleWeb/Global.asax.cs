using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TuevSued.V1.IT.FE.MasterDataModuleWeb;

namespace TuevSued.V1.IT.FE
{
    public class MasterDataModuleWebApplication : HttpApplication
    {
        protected void Application_Start()
        {
			AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
			GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
