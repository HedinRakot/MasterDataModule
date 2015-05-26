using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class WcfInfosWithLastResultManager: BaseManager<WcfInfosWithLastResult>, IWcfInfosWithLastResultManager
    {
		public WcfInfosWithLastResultManager(DbContext context): base(context)
		{
		}
	}
}