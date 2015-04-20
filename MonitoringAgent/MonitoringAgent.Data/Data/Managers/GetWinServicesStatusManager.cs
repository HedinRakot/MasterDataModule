using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class GetWinServicesStatusManager: BaseManager<GetWinServicesStatus>, IGetWinServicesStatusManager
    {
		public GetWinServicesStatusManager(DbContext context): base(context)
		{
		}
	}
}
