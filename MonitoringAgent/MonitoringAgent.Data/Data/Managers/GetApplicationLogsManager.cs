using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class GetApplicationLogsManager: BaseManager<GetApplicationLogs>, IGetApplicationLogsManager
    {
		public GetApplicationLogsManager(DbContext context): base(context)
		{
		}
	}
}
