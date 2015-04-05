using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataJobInfoManager: BaseManager<MasterDataJobInfo>, IMasterDataJobInfoManager
    {
		public MasterDataJobInfoManager(DbContext context): base(context)
		{
		}
	}
}
