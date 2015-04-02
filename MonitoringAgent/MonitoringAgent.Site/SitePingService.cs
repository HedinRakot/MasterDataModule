using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    public class SitePingService :BaseManagersService, ISitePingService
    {
        public SitePingService(IManagersProvider managerProvider): base(managerProvider)
        {
        }

        public List<MasterDataSiteInfo> GetAllSitesForCheck()
        {
            var siteInfoManager = ManagersProvider.GetManager<IMasterDataSiteInfoManager>();
            return siteInfoManager.GetAllEntities().ToList();
        }

        public MasterDataSiteCheckResults GetLastResult(int siteId)
        {
            var checkResultManager = ManagersProvider.GetManager<IMasterDataSiteCheckResultsManager>();
            return checkResultManager.GetAllEntities().Where(s => s.MasterDataSiteInfoId == siteId).OrderByDescending(s => s.CheckDate).FirstOrDefault();
        }

        public void SetCheckingResult(MasterDataSiteCheckResults result)
        {
            var checkResultManager = ManagersProvider.GetManager<IMasterDataSiteCheckResultsManager>();
            checkResultManager.AddOrUpdateEntities(new[] { result });
            checkResultManager.SaveChanges();
        }
    }
}
