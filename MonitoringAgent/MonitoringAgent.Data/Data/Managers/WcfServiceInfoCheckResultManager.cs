using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public class WcfServiceInfoCheckResultManager: BaseManager<WcfServiceInfoCheckResult>, IWcfServiceInfoCheckResultManager
    {
        public WcfServiceInfoCheckResultManager(MasterDataMonitoringModelContainer context) : base(context)
        {
        }
    }
}
