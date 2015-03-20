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
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}