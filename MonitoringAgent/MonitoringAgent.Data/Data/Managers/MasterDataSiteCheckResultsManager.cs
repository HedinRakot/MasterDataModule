using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataSiteCheckResultsManager: BaseManager<MasterDataSiteCheckResults>, IMasterDataSiteCheckResultsManager
    {
		public MasterDataSiteCheckResultsManager(DbContext context): base(context)
		{
		}
	}
}
