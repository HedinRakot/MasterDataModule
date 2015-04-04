using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataWcfCheckResultsManager: BaseManager<MasterDataWcfCheckResults>, IMasterDataWcfCheckResultsManager
    {
		public MasterDataWcfCheckResultsManager(DbContext context): base(context)
		{
		}
	}
}
