using Microsoft.Practices.Unity;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class ManagersProvider : IManagersProvider
    {
        private readonly IUnityContainer container;

        public ManagersProvider()
        {
            container = new UnityContainer();
            RegisterManagers(container);
        }

        public T GetManager<T>()
        {
            return container.Resolve<T>();
        }
    }
}
