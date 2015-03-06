using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using TuevSued.V1.IT.Configuration;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule;
using TuevSued.V1.IT.FE.MasterDataModule.API;
using TuevSued.V1.IT.FE.MasterDataModule.API.Controllers;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;

namespace TuevSued.V1.IT.FE.MasterDataModuleWeb
{
    public class MasterDataModuleWebApplication : System.Web.HttpApplication
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
