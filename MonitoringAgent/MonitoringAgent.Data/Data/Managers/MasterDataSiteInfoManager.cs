
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataSiteInfoManager: BaseManager<MasterDataSiteInfo>, IMasterDataSiteInfoManager
    {
		public MasterDataSiteInfoManager(DbContextProvider contextProvider): base(contextProvider)
		{
		}
	}
}
