using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class JobsInfosWithLastResultManager: BaseManager<JobsInfosWithLastResult>, IJobsInfosWithLastResultManager
    {
		public JobsInfosWithLastResultManager(DbContext context): base(context)
		{
		}
	}
}
