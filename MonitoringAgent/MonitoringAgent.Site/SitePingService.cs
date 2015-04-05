using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    /// <summary>
    /// Service for working with sites
    /// </summary>
    internal sealed class SitePingService :BaseManagersService, ISitePingService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managerProvider">Managers provider</param>
        public SitePingService(IManagersProvider managerProvider): base(managerProvider)
        {
        }
        /// <summary>
        /// Gets all sites for checking
        /// </summary>
        /// <returns></returns>
        public List<MasterDataSiteInfo> GetAllSitesForCheck()
        {
            var siteInfoManager = ManagersProvider.GetManager<IMasterDataSiteInfoManager>();
            return siteInfoManager.GetAllEntities().ToList();
        }
        /// <summary>
        /// Gets last result of checking
        /// </summary>
        /// <param name="siteId">Id of monitorable object</param>
        /// <returns></returns>
        public MasterDataSiteCheckResults GetLastResult(int siteId)
        {
            var checkResultManager = ManagersProvider.GetManager<IMasterDataSiteCheckResultsManager>();
            return checkResultManager.GetAllEntities().Where(s => s.MasterDataSiteInfoId == siteId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }
        /// <summary>
        /// Saves checking result
        /// </summary>
        /// <param name="result">Result</param>
        public void SetCheckingResult(MasterDataSiteCheckResults result)
        {
            var checkResultManager = ManagersProvider.GetManager<IMasterDataSiteCheckResultsManager>();
            checkResultManager.AddOrUpdateEntities(new[] { result });
            checkResultManager.SaveChanges();
        }
    }
}
