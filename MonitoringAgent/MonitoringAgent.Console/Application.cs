using Microsoft.Practices.Unity;
using MonitoringAgent.Common.Data.Managers;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.WcfServices;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent
{
    internal class Application
    {
        readonly IUnityContainer container = new UnityContainer();

        public void Initialize()
        {
            container.RegisterType<IWcfServiceInfoManager, WcfServiceInfoManager>();
            container.RegisterType<IWcfPingService, WcfPingService>();
            container.RegisterType<IWcfServicePingManager, WcfServicePingManager>();
        }

        internal IUnityContainer Container
        {
            get { return container; }
        }
    }
}
