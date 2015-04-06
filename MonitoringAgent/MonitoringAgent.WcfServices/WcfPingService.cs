using System;
using System.Linq.Expressions;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    /// <summary>
    /// Service for checking WCF services
    /// </summary>
    internal sealed class WcfPingService : BasePingServiceWithLastResult<IMasterDataWcfInfoManager, MasterDataWcfInfo, IMasterDataWcfCheckResultsManager, MasterDataWcfCheckResults>, IWcfPingService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managersProvider">Managers provider</param>
        public WcfPingService(IManagersProvider managersProvider)
            : base(managersProvider)
        {
        }
 
        /// <summary>
        /// Gets id of info
        /// </summary>
        protected override Expression<Func<MasterDataWcfCheckResults, int>> InfoIdExtractor
        {
            get
            {
                return (res) => res.MasterDataWcfInfoId;
            }
        }
    }
}
