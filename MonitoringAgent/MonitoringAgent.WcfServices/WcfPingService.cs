using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.WcfServices.Interfaces.Services;


namespace MonitoringAgent.WcfServices
{
    public class WcfPingService : IWcfPingService
    {
        private readonly IManagersProvider managersProvider;

        public WcfPingService(IManagersProvider managersProvider)
        {
            this.managersProvider = managersProvider;
        }

        public List<WcfServiceInfo> GetAllServicesToCheck()
        {
            var manager = managersProvider.GetManager<IWcfServiceInfoManager>();
            return manager.GetAllEntities().ToList();
        }

        public WcfServiceInfoCheckResult GetLastResult(int serviceId)
        {
            var serviceInfoCheckResultManager = managersProvider.GetManager<IWcfServiceInfoCheckResultManager>();
            return serviceInfoCheckResultManager.GetAllEntities().Where(s => s.WcfServiceInfoId == serviceId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }

        public void SetCheckingResult(WcfServiceInfoCheckResult result)
        {
            var serviceInfoCheckResultManager = managersProvider.GetManager<IWcfServiceInfoCheckResultManager>();
            serviceInfoCheckResultManager.AddOrUpdateEntities(new[] { result });
            serviceInfoCheckResultManager.SaveChanges();
        }
    }
}
