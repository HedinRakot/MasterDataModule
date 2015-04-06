using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class MasterDataWindowsServiceCheckResultsManager: BaseManager<MasterDataWindowsServiceCheckResults>, IMasterDataWindowsServiceCheckResultsManager
    {
		public MasterDataWindowsServiceCheckResultsManager(DbContext context): base(context)
		{
		}
	}
}
