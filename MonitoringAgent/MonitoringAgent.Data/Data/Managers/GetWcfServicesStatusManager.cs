using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class GetWcfServicesStatusManager: BaseManager<GetWcfServicesStatus>, IGetWcfServicesStatusManager
    {
		public GetWcfServicesStatusManager(DbContext context): base(context)
		{
		}
	}
}
