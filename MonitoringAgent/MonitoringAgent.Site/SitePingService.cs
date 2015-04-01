using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    public class SitePingService : ISitePingService
    {
        private readonly IManagersProvider managerProvider;

        public SitePingService(IManagersProvider managerProvider)
        {
            this.managerProvider = managerProvider;
        }

        public List<SiteInfo> GetAllSitesForCheck()
        {
            var siteInfoManager = managerProvider.GetManager<ISiteInfoManager>();
            return siteInfoManager.GetAllEntities().ToList();
        }

        public SiteInfoCheckResult GetLastResult(int siteId)
        {
            var checkResultManager = managerProvider.GetManager<ISiteInfoCheckResultManager>();
            return checkResultManager.GetAllEntities().Where(s => s.SiteInfoId == siteId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }

        public void SetCheckingResult(SiteInfoCheckResult result)
        {
            var checkResultManager = managerProvider.GetManager<ISiteInfoCheckResultManager>();
            checkResultManager.AddOrUpdateEntities(new[] { result });
            checkResultManager.SaveChanges();
        }
    }
}
