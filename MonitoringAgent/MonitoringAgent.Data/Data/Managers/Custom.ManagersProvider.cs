using Microsoft.Practices.Unity;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    /// <summary>
    /// Provides managers
    /// </summary>
    internal sealed partial class ManagersProvider : IManagersProvider
    {
        private readonly IUnityContainer unityContainer;

        /// <summary>
        /// Ctor
        /// </summary>
        public ManagersProvider()
        {
            unityContainer = new UnityContainer();
            unityContainer.RegisterType<IMasterDataDbContext, MasterDataDbContext>(new PerThreadLifetimeManager(), new InjectionConstructor());
            RegisterManagers(unityContainer);
        }

        /// <summary>
        /// Gets manager
        /// </summary>
        /// <typeparam name="T">Type of manager</typeparam>
        public T GetManager<T>()
        {
            var context = unityContainer.Resolve<IMasterDataDbContext>();
            return unityContainer.Resolve<T>(new ParameterOverride("context", context));
        }
    }
}
