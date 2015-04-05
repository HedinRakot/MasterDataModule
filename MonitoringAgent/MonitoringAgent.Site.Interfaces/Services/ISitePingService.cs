using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Site.Interfaces.Services
{
    /// <summary>
    /// Service for working with sites
    /// </summary>
    public interface ISitePingService
    {
        /// <summary>
        /// Gets all sites for checking
        /// </summary>
        /// <returns></returns>
        List<MasterDataSiteInfo> GetAllSitesForCheck();
        /// <summary>
        /// Gets last result of checking
        /// </summary>
        /// <param name="siteId">Id of monitorable object</param>
        /// <returns></returns>
        MasterDataSiteCheckResults GetLastResult(int siteId);
        /// <summary>
        /// Saves checking result
        /// </summary>
        /// <param name="result">Result</param>
        void SetCheckingResult(MasterDataSiteCheckResults result);
    }
}