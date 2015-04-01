using System;
using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    public sealed class WcfServicePingModule : CheckingModule<WcfServiceInfo, WcfServiceInfoCheckResult>
    {
        private readonly IWcfPingService service;

        public WcfServicePingModule(IWcfPingService service)
        {
            this.service = service;
        }

        protected override IList<WcfServiceInfo> ServiceExtractor()
        {
            return service.GetAllServicesToCheck();
        }

        protected override WcfServiceInfoCheckResult LastResultExtractor(WcfServiceInfo serviceInfo)
        {
            return service.GetLastResult(serviceInfo.Id);
        }

        protected override WcfServiceInfoCheckResult CheckService(WcfServiceInfo serviceInfo)
        {
            var loader = new WcfMetadataLoader(serviceInfo.WsdlPath);
            var result = loader.Ping();
            return new WcfServiceInfoCheckResult
            {
                Attempt = 1,
                CheckDate = DateTime.Now, 
                CheckStatus = result.Result ? 1 : 0,
                WcfServiceInfoId = serviceInfo.Id,
                Message = result.Message
            };
        }

        protected override void SaveCheckingResult(WcfServiceInfoCheckResult result)
        {
            service.SetCheckingResult(result);
        }
    }
}
