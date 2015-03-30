using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.WcfServices.Interfaces.Services;


namespace MonitoringAgent.WcfServices
{
    public class WcfPingService : IWcfPingService
    {
        private readonly IWcfServiceInfoManager manager;

        public WcfPingService(IWcfServiceInfoManager manager)
        {
            this.manager = manager;
        }

        public List<WcfServiceInfo> GetAllServicesToCheck()
        {
            return manager.GetAllEntities().ToList();
        }

        public void SetCheckingResults(List<WcfServiceInfo> serviceInfos)
        {
            manager.AddOrUpdateEntities(serviceInfos.ToArray());
            manager.SaveChanges();
        }
    }
}
