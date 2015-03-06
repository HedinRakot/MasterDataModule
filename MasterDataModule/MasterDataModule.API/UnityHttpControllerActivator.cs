using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Microsoft.Practices.Unity;

namespace TuevSued.V1.IT.FE.MasterDataModule.API
{
    public class UnityHttpControllerActivator : IHttpControllerActivator
    {
        private readonly IUnityContainer container;

        public UnityHttpControllerActivator(IUnityContainer container)
        {
            this.container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return (IHttpController)container.Resolve(controllerType);
        }
    }
}
