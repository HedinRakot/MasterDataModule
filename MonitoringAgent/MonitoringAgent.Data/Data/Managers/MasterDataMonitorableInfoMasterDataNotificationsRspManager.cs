using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataMonitorableInfoMasterDataNotificationsRspManager: BaseManager<MasterDataMonitorableInfoMasterDataNotificationsRsp>, IMasterDataMonitorableInfoMasterDataNotificationsRspManager
    {
		public MasterDataMonitorableInfoMasterDataNotificationsRspManager(DbContext context): base(context)
		{
		}
	}
}
