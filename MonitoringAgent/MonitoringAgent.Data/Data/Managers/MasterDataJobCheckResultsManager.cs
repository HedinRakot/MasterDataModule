
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public partial class MasterDataJobCheckResultsManager: BaseManager<MasterDataJobCheckResults>, IMasterDataJobCheckResultsManager
    {
		public MasterDataJobCheckResultsManager(DbContextProvider contextProvider): base(contextProvider)
		{
		}
	}
}
