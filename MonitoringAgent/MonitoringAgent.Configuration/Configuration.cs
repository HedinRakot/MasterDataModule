using Microsoft.Practices.Unity;
using MonitoringAgent.Services.Common.Contracts;
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
            container.RegisterType<ICheckingService, WcfServicePingManager>("wcfPingManager");
        }

        public IUnityContainer Container
        {
            get { return container; }
        }
    }
}
