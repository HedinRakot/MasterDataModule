using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Site.Interfaces.Services
{
    public interface ISitePingService
    {
        List<MasterDataSiteInfo> GetAllSitesForCheck();
        MasterDataSiteCheckResults GetLastResult(int siteId);
        void SetCheckingResult(MasterDataSiteCheckResults result);
    }
}