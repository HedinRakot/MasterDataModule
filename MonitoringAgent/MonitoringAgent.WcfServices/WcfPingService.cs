using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    internal sealed class WcfPingService : BaseManagersService, IWcfPingService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managersProvider">Managers provider</param>
        public WcfPingService(IManagersProvider managersProvider)
            : base(managersProvider)
        {
        }
        /// <summary>
        /// Get all services for check
        /// </summary>
        /// <returns></returns>
        public List<MasterDataWcfInfo> GetAllServicesToCheck()
        {
            var manager = ManagersProvider.GetManager<IMasterDataWcfInfoManager>();
            return manager.GetAllEntities().ToList();
        }
        /// <summary>
        /// Gets last result
        /// </summary>
        /// <param name="serviceId">Service id</param>
        public MasterDataWcfCheckResults GetLastResult(int serviceId)
        {
            var serviceInfoCheckResultManager = ManagersProvider.GetManager<IMasterDataWcfCheckResultsManager>();
            return serviceInfoCheckResultManager.GetAllEntities().Where(s => s.MasterDataWcfInfoId == serviceId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }
        /// <summary>
        /// Saves checking result
        /// </summary>
        /// <param name="result">Result</param>
        public void SetCheckingResult(MasterDataWcfCheckResults result)
        {
            var serviceInfoCheckResultManager = ManagersProvider.GetManager<IMasterDataWcfCheckResultsManager>();
            serviceInfoCheckResultManager.AddOrUpdateEntities(new[] { result });
            serviceInfoCheckResultManager.SaveChanges();
        }
    }
}
