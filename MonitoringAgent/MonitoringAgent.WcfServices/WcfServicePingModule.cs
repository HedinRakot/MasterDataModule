using System;
using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Services.Common.Contracts;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    /// <summary>
    /// Module for checking WCF services
    /// </summary>
    public sealed class WcfServicePingModule : CheckingModuleWithLastResult<MasterDataWcfInfo, MasterDataWcfCheckResults>
    {
        private readonly IWcfPingService service;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="service">Service for checking WCF</param>
        /// <param name="notificationService">Notification service</param>
        public WcfServicePingModule(IWcfPingService service, INotificationService notificationService): base(notificationService)
        {
            this.service = service;
        }
        /// <summary>
        /// Gets all monitorable objects for checking
        /// </summary>
        /// <returns>List of monitorble objects</returns>
        protected override IList<MasterDataWcfInfo> ServiceExtractor()
        {
            return service.GetAllServicesToCheck();
        }
        /// <summary>
        /// Save results of checking
        /// </summary>
        /// <param name="result">Result</param>
        protected override void SaveCheckingResult(MasterDataWcfCheckResults result)
        {
            service.SetCheckingResult(result);
        }
        /// <summary>
        /// Gets previous result of checking
        /// </summary>
        /// <param name="serviceInfo">Info about monitorable object</param>
        protected override MasterDataWcfCheckResults LastResultExtractor(MasterDataWcfInfo serviceInfo)
        {
            return service.GetLastResult(serviceInfo.Id);
        }
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected override MasterDataWcfCheckResults CheckServiceWithLastResult(MasterDataWcfInfo serviceInfo)
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
        /// <summary>
        /// Module type
        /// </summary>
        protected override CheckModuleType CheckModuleType
        {
            get { return CheckModuleType.WcfService; }
        }
    }
}
