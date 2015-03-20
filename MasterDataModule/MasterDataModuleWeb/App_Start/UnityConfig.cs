using Microsoft.Practices.Unity;
using System.Web.Http;
using MasterDataModule.Configuration;
using Unity.WebApi;

namespace TuevSued.V1.IT.FE
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            UnityConfiguration.ConfigureContainer(container);
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}