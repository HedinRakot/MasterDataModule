using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataWcfInfoManager: BaseManager<MasterDataWcfInfo>, IMasterDataWcfInfoManager
    {
		public MasterDataWcfInfoManager(DbContext context): base(context)
		{
		}
	}
}
