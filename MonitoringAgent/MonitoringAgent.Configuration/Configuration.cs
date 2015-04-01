using Microsoft.Practices.Unity;
using MonitoringAgent.Common.Data.Managers;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Contracts;
using MonitoringAgent.Services.Common.Services;
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
            container.RegisterType<IManagersProvider, ManagersProvider>();
            container.RegisterType<IConfigurationService, ConfigurationService>();
            container.RegisterType<IWcfPingService, WcfPingService>();
            container.RegisterType<ICheckingModule, WcfServicePingModule>("wcfPing");

            container.RegisterType<ISitePingService, SitePingService>();
            container.RegisterType<ICheckingModule, SitePingModule>("sitePing");
        }

        public IUnityContainer Container
        {
            get { return container; }
        }
    }
}
