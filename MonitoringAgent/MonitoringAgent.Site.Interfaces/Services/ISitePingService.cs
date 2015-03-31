using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Site.Interfaces.Services
{
    public interface ISitePingService
    {
        List<SiteInfo> GetAllSitesForCheck();
        SiteInfoCheckResult GetLastResult(int siteId);
        void SetCheckingResult(SiteInfoCheckResult result);
    }
}