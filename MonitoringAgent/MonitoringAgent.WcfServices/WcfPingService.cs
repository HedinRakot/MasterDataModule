using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.WcfServices.Interfaces.Services;


namespace MonitoringAgent.WcfServices
{
    public class WcfPingService : IWcfPingService
    {
        private readonly IWcfServiceInfoManager manager;
        private readonly IWcfServiceInfoCheckResultManager serviceInfoCheckResultManager;

        public WcfPingService(IWcfServiceInfoManager manager, IWcfServiceInfoCheckResultManager serviceInfoCheckResultManager)
        {
            this.manager = manager;
            this.serviceInfoCheckResultManager = serviceInfoCheckResultManager;
        }

        public List<WcfServiceInfo> GetAllServicesToCheck()
        {
            return manager.GetAllEntities().ToList();
        }

        public WcfServiceInfoCheckResult GetLastResult(int serviceId)
        {
            return serviceInfoCheckResultManager.GetAllEntities().Where(s => s.WcfServiceInfoId == serviceId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }

        public void SetCheckingResult(WcfServiceInfoCheckResult result)
        {
            serviceInfoCheckResultManager.AddOrUpdateEntities(new[] { result });
            serviceInfoCheckResultManager.SaveChanges();
        }
    }
}
