using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
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

        protected override void RegisterServices()
        {
            var siteInfos = sitePingService.GetAllSitesForCheck();
            foreach (var siteInfo in siteInfos)
            {
                AddService(siteInfo, siteInfo.Name, siteInfo.TimeoutChecking);
            }
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
                CheckStatus = result.Status == System.Net.NetworkInformation.IPStatus.Success ? 1 : 0,
            };
        }

        protected override void SaveCheckingResult(SiteInfoCheckResult result)
        {
            var lastResult = sitePingService.GetLastResult(result.SiteInfoId);
            if (lastResult != null && result.CheckStatus == lastResult.CheckStatus && result.Message == lastResult.Message)
            {
                lastResult.Attempt++;
                lastResult.CheckDate = result.CheckDate;
                result = lastResult;
            }
            sitePingService.SetCheckingResult(result);
        }
    }
}
