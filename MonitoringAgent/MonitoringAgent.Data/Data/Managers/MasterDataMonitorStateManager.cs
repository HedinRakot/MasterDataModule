using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataMonitorStateManager: BaseManager<MasterDataMonitorState>, IMasterDataMonitorStateManager
    {
		public MasterDataMonitorStateManager(DbContext context): base(context)
		{
		}
	}
}
