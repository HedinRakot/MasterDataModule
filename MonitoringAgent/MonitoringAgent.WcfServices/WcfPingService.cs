using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Common.Data;
using MonitoringAgent.Common.Data.Managers;


namespace MonitoringAgent.WcfServices
{
    public class WcfPingService
    {
        private readonly WcfServiceInfoManager manager;

        public WcfPingService(WcfServiceInfoManager manager)
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
        }
    }
}
