using Microsoft.Practices.Unity;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    /// <summary>
    /// Provides managers
    /// </summary>
    public partial class ManagersProvider : IManagersProvider
    {
        private readonly IUnityContainer container;

        /// <summary>
        /// Ctor
        /// </summary>
        public ManagersProvider()
        {
            container = new UnityContainer();
            container.RegisterType<IMasterDataDbContext, MasterDataDbContext>(new PerThreadLifetimeManager(), new InjectionConstructor());
            RegisterManagers(container);
        }

        /// <summary>
        /// Gets manager
        /// </summary>
        /// <typeparam name="T">Type of manager</typeparam>
        public T GetManager<T>()
        {
            var context = container.Resolve<IMasterDataDbContext>();
            return container.Resolve<T>(new ParameterOverride("context", context));
        }
    }
}
