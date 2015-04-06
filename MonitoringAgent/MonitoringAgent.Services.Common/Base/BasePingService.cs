using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common.Base
{
    /// <summary>
    /// Base class for all services for monitor objects
    /// </summary>
    /// <typeparam name="TManager">Manager for get info about monitorable objects</typeparam>
    /// <typeparam name="TServiceInfo">Type of monitorable objects</typeparam>
    public abstract class BasePingService<TManager, TServiceInfo>: BaseManagersService, 
        IBasePingService<TServiceInfo> where TManager: IBaseManager<TServiceInfo> where TServiceInfo : class
    {
        /// <summary>
        /// Ctor 
        /// </summary>
        /// <param name="managersProvider">Managers provider</param>
        protected BasePingService(IManagersProvider managersProvider) : base(managersProvider)
        {
        }

        /// <summary>
        /// Gets all objects for checking
        /// </summary>
        /// <returns></returns>
        public List<TServiceInfo> GetAllInfos()
        {
            var manager = ManagersProvider.GetManager<TManager>();
            return manager.GetAllEntities().ToList();
        }
    }
}
