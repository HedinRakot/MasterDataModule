using Microsoft.Practices.Unity;
using MonitoringAgent.Common.Data.Managers;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Contracts;
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
            container.RegisterType<IWcfServiceInfoCheckResultManager, WcfServiceInfoCheckResultManager>();
            container.RegisterType<IWcfPingService, WcfPingService>();
            container.RegisterType<ICheckingService, WcfServicePingManager>("wcfPingManager");
        }

        internal IUnityContainer Container
        {
            get { return container; }
        }
    }
}
