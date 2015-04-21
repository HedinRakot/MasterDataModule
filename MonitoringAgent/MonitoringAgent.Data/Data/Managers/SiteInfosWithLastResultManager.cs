using System.Data.Entity;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    internal sealed partial class SiteInfosWithLastResultManager: BaseManager<SiteInfosWithLastResult>, ISiteInfosWithLastResultManager
    {
		public SiteInfosWithLastResultManager(DbContext context): base(context)
		{
		}
	}
}
