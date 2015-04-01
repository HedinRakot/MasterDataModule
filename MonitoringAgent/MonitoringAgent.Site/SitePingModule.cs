using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    public sealed class SitePingModule: CheckingModule<SiteInfo, SiteInfoCheckResult>
    {
        private readonly ISitePingService sitePingService;

        public SitePingModule(ISitePingService sitePingService)
        {
            this.sitePingService = sitePingService;
        }

        protected override IList<SiteInfo> ServiceExtractor()
        {
            return sitePingService.GetAllSitesForCheck();
        }

        protected override SiteInfoCheckResult LastResultExtractor(SiteInfo serviceInfo)
        {
            return sitePingService.GetLastResult(serviceInfo.Id);
        }

        protected override SiteInfoCheckResult CheckService(SiteInfo serviceInfo)
        {
            var ping = new Ping();
            var result = ping.Send(serviceInfo.SitePath);
            return new SiteInfoCheckResult
            {
                Attempt = 1,
                CheckDate = DateTime.Now,
                SiteInfoId = serviceInfo.Id,
                CheckStatus = result.Status == IPStatus.Success ? 1 : 0,
            };
        }

        protected override void SaveCheckingResult(SiteInfoCheckResult result)
        {
            sitePingService.SetCheckingResult(result);
        }
    }
}
