using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Routing;
using MasterDataModule.API;
using MasterDataModule.Configuration;
using Microsoft.Practices.Unity;

namespace TuevSued.V1.IT.FE.MasterDataModuleWeb
{
    public class MasterDataModuleWebApplication : HttpApplication
    {
        protected void Application_Start()
        {
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);

            var container = new UnityContainer();
            UnityConfiguration.ConfigureContainer(container);

            container.RegisterInstance<IHttpControllerActivator>(new UnityHttpControllerActivator(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityResolver(container);
        }
    }
}
