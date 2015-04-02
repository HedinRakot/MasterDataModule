using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    public sealed class SitePingModule : CheckingModuleWithLastResult<MasterDataSiteInfo, MasterDataSiteCheckResults>
    {
        private readonly ISitePingService sitePingService;

        public SitePingModule(ISitePingService sitePingService)
        {
            this.sitePingService = sitePingService;
        }

        protected override IList<MasterDataSiteInfo> ServiceExtractor()
        {
            return sitePingService.GetAllSitesForCheck();
        }

        protected override void SaveResult(MasterDataSiteCheckResults result)
        {
            sitePingService.SetCheckingResult(result);
        }

        protected override MasterDataSiteCheckResults LastResultExtractor(MasterDataSiteInfo serviceInfo)
        {
            return sitePingService.GetLastResult(serviceInfo.Id);
        }

        protected override MasterDataSiteCheckResults CheckService(MasterDataSiteInfo serviceInfo)
        {
            var ping = new Ping();
            var result = ping.Send(serviceInfo.SitePath);
            return new MasterDataSiteCheckResults
            {
                Attempt = 1,
                CheckDate = DateTime.Now,
                MasterDataSiteInfoId = serviceInfo.Id,
                CheckStatus = result.Status == IPStatus.Success ? 1 : 0,
            };
        }
    }
}
