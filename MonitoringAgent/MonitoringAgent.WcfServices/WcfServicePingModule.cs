using System;
using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    public sealed class WcfServicePingModule : CheckingModuleWithLastResult<MasterDataWcfInfo, MasterDataWcfCheckResults>
    {
        private readonly IWcfPingService service;

        public WcfServicePingModule(IWcfPingService service)
        {
            this.service = service;
        }

        protected override IList<MasterDataWcfInfo> ServiceExtractor()
        {
            return service.GetAllServicesToCheck();
        }

        protected override void SaveResult(MasterDataWcfCheckResults result)
        {
            service.SetCheckingResult(result);
        }

        protected override MasterDataWcfCheckResults LastResultExtractor(MasterDataWcfInfo serviceInfo)
        {
            return service.GetLastResult(serviceInfo.Id);
        }

        protected override MasterDataWcfCheckResults CheckService(MasterDataWcfInfo serviceInfo)
        {
            var loader = new WcfMetadataLoader(serviceInfo.WsdlPath);
            var result = loader.Ping();
            return new MasterDataWcfCheckResults
            {
                Attempt = 1,
                CheckDate = DateTime.Now, 
                CheckStatus = result.Result ? 1 : 0,
                MasterDataWcfInfoId = serviceInfo.Id,
                Message = result.Message
            };
        }
    }
}
