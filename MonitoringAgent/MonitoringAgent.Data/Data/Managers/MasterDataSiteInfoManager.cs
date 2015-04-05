using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataSiteInfoManager: BaseManager<MasterDataSiteInfo>, IMasterDataSiteInfoManager
    {
		public MasterDataSiteInfoManager(DbContext context): base(context)
		{
		}
	}
}
