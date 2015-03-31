using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    public class SitePingService : ISitePingService
    {
        private readonly ISiteInfoManager siteInfoManager;
        private readonly ISiteInfoCheckResultManager checkResultManager;

        public SitePingService(ISiteInfoManager siteInfoManager, ISiteInfoCheckResultManager checkResultManager)
        {
            this.siteInfoManager = siteInfoManager;
            this.checkResultManager = checkResultManager;
        }

        public List<SiteInfo> GetAllSitesForCheck()
        {
            return siteInfoManager.GetAllEntities().ToList();
        }

        public SiteInfoCheckResult GetLastResult(int siteId)
        {
            return checkResultManager.GetAllEntities().Where(s => s.SiteInfoId == siteId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }

        public void SetCheckingResult(SiteInfoCheckResult result)
        {
            checkResultManager.AddOrUpdateEntities(new[] { result });
            checkResultManager.SaveChanges();
        }
    }
}
