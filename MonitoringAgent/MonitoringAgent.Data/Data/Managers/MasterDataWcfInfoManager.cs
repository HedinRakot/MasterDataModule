
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataWcfInfoManager: BaseManager<MasterDataWcfInfo>, IMasterDataWcfInfoManager
    {
		public MasterDataWcfInfoManager(DbContextProvider contextProvider): base(contextProvider)
		{
		}
	}
}
