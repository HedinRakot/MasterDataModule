using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataSubscribersManager: BaseManager<MasterDataSubscribers>, IMasterDataSubscribersManager
    {
		public MasterDataSubscribersManager(DbContext context): base(context)
		{
		}
	}
}
