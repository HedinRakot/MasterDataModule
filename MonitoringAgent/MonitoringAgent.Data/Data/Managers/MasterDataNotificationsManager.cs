using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataNotificationsManager: BaseManager<MasterDataNotifications>, IMasterDataNotificationsManager
    {
		public MasterDataNotificationsManager(DbContext context): base(context)
		{
		}
	}
}
