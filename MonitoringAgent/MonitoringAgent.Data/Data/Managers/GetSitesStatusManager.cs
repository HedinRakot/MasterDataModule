using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class GetSitesStatusManager: BaseManager<GetSitesStatus>, IGetSitesStatusManager
    {
		public GetSitesStatusManager(DbContext context): base(context)
		{
		}
	}
}
