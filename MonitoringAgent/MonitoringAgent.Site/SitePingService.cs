using System;
using System.Linq.Expressions;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    /// <summary>
    /// Service for working with sites
    /// </summary>
    internal sealed class SitePingServiceWithLastResultWithLastResult : BasePingServiceWithLastResultWithLastResult<IMasterDataSiteInfoManager, MasterDataSiteInfo, IMasterDataSiteCheckResultsManager, MasterDataSiteCheckResults>, ISitePingServiceWithLastResult
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managerProvider">Managers provider</param>
        public SitePingServiceWithLastResultWithLastResult(IManagersProvider managerProvider): base(managerProvider)
        {
        }
        /// <summary>
        /// Gets id of info
        /// </summary>
        protected override Expression<Func<MasterDataSiteCheckResults, int>> InfoIdExtractor
        {
            get { return results => results.MasterDataSiteInfoId; }
        }
    }
}
