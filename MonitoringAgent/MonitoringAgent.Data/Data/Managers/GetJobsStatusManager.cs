using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class GetJobsStatusManager: BaseManager<GetJobsStatus>, IGetJobsStatusManager
    {
		public GetJobsStatusManager(DbContext context): base(context)
		{
		}
	}
}
