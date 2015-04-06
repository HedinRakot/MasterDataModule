using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class ApplicationLogsManager: BaseManager<ApplicationLogs>, IApplicationLogsManager
    {
		public ApplicationLogsManager(DbContext context): base(context)
		{
		}
	}
}
