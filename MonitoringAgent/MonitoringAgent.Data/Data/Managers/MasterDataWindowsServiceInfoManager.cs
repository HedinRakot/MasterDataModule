using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataWindowsServiceInfoManager: BaseManager<MasterDataWindowsServiceInfo>, IMasterDataWindowsServiceInfoManager
    {
		public MasterDataWindowsServiceInfoManager(DbContext context): base(context)
		{
		}
	}
}
