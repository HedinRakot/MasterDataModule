using Microsoft.Practices.Unity;
using MonitoringAgent.Services.Common.Contracts;
using MonitoringAgent.Site;
using MonitoringAgent.Site.Interfaces.Services;
using MonitoringAgent.WcfServices;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.Configuration
{
    public partial class Configuration
    {
        readonly IUnityContainer container = new UnityContainer();

        public void Initialize()
        {
            RegisterManagers(container);   
            container.RegisterType<IWcfPingService, WcfPingService>();
            container.RegisterType<ICheckingModule, WcfServicePingModule>("wcfPingManager");

            container.RegisterType<ISitePingService, SitePingService>();
        }

        public IUnityContainer Container
        {
            get { return container; }
        }
    }
}
