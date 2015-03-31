using System;
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

        protected override void RegisterServices()
        {
            var services = service.GetAllServicesToCheck();
            foreach (var serviceInfo in services)
            {
                AddService(serviceInfo, serviceInfo.Name, serviceInfo.TimeoutChecking);
            }
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
            var lastResult = service.GetLastResult(result.WcfServiceInfoId);
            if (lastResult != null && result.CheckStatus == lastResult.CheckStatus && result.Message == lastResult.Message)
            {
                lastResult.Attempt++;
                lastResult.CheckDate = result.CheckDate;
                result = lastResult;
            }
            service.SetCheckingResult(result);
        }
    }
}
