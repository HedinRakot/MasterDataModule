using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataJobInfoManager: BaseManager<MasterDataJobInfo>, IMasterDataJobInfoManager
    {
		public MasterDataJobInfoManager(DbContext context): base(context)
		{
		}
	}
}
