using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public class WcfServiceInfoManager : BaseManager<WcfServiceInfo>, IWcfServiceInfoManager
    {
        public WcfServiceInfoManager(MasterDataMonitoringModelContainer context)
            : base(context)
        {
        }
    }
}
