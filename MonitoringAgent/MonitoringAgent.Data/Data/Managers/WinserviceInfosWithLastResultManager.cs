using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class WinserviceInfosWithLastResultManager: BaseManager<WinserviceInfosWithLastResult>, IWinserviceInfosWithLastResultManager
    {
		public WinserviceInfosWithLastResultManager(DbContext context): base(context)
		{
		}
	}
}
