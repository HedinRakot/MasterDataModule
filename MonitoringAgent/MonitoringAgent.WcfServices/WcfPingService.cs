using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WcfServices.Interfaces.Services;


namespace MonitoringAgent.WcfServices
{
    public class WcfPingService : BaseManagersService, IWcfPingService
    {
        public WcfPingService(IManagersProvider managersProvider)
            : base(managersProvider)
        {
        }

        public List<MasterDataWcfInfo> GetAllServicesToCheck()
        {
            var manager = ManagersProvider.GetManager<IMasterDataWcfInfoManager>();
            return manager.GetAllEntities().ToList();
        }

        public MasterDataWcfCheckResults GetLastResult(int serviceId)
        {
            var serviceInfoCheckResultManager = ManagersProvider.GetManager<IMasterDataWcfCheckResultsManager>();
            return serviceInfoCheckResultManager.GetAllEntities().Where(s => s.MasterDataWcfInfoId == serviceId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }

        public void SetCheckingResult(MasterDataWcfCheckResults result)
        {
            var serviceInfoCheckResultManager = ManagersProvider.GetManager<IMasterDataWcfCheckResultsManager>();
            serviceInfoCheckResultManager.AddOrUpdateEntities(new[] { result });
            serviceInfoCheckResultManager.SaveChanges();
        }
    }
}
