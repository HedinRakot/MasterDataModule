using System;
using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    /// <summary>
    /// Module for checking WCF services
    /// </summary>
    internal sealed class WcfServicePingModule : CheckingModuleWithLastResult<MasterDataWcfInfo, MasterDataWcfCheckResults>
    {
        private readonly IWcfPingService service;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="service">Service for checking WCF</param>
        /// <param name="notificationsModule">Notification module</param>
        public WcfServicePingModule(IWcfPingService service, INotificationsModule notificationsModule)
            : base(notificationsModule)
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
