using System;
using System.Collections.Generic;
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
        private readonly Dictionary <string, IMasterDataDbContext> scopeContexts = new Dictionary<string, IMasterDataDbContext>(); 

        /// <summary>
        /// Ctor
        /// </summary>
        public ManagersProvider()
        {
            unityContainer = new UnityContainer();
            unityContainer.RegisterType<IMasterDataDbContext, MasterDataDbContext>(new PerResolveLifetimeManager(), new InjectionConstructor());
            RegisterManagers(unityContainer);
        }

        /// <summary>
        /// Begin scope
        /// </summary>
        public ContextScope BeginScope()
        {
            var guid = Guid.NewGuid().ToString();
            scopeContexts.Add(guid, unityContainer.Resolve<IMasterDataDbContext>());
            return new ContextScope(guid);
        }

        /// <summary>
        /// End scope
        /// </summary>
        public void EndScope(ContextScope scope)
        {
            scopeContexts.Remove(scope.Guid);
        }

        /// <summary>
        /// Gets manager
        /// </summary>
        /// <typeparam name="T">Type of manager</typeparam>
        public T GetManager<T>(ContextScope scope = null)
        {
            IMasterDataDbContext context;
            if (scope != null)
            {
                context = scopeContexts[scope.Guid];
            }
            else
            {
                context = unityContainer.Resolve<IMasterDataDbContext>();
            }
            
            return unityContainer.Resolve<T>(new ParameterOverride("context", context));
        }

    }
}
