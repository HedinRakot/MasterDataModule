using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataNotificationsMasterDataSubscribersRspManager: BaseManager<MasterDataNotificationsMasterDataSubscribersRsp>, IMasterDataNotificationsMasterDataSubscribersRspManager
    {
		public MasterDataNotificationsMasterDataSubscribersRspManager(DbContext context): base(context)
		{
		}
	}
}
