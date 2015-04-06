using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Site.Interfaces.Services;

namespace MonitoringAgent.Site
{
    /// <summary>
    /// Module for checking sites
    /// </summary>
    internal sealed class SitePingModule : CheckingModuleWithLastResult<MasterDataSiteInfo, MasterDataSiteCheckResults>
    {
        private readonly ISitePingServiceWithLastResult sitePingServiceWithLastResult;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="sitePingServiceWithLastResult">Site ping service</param>
        /// <param name="notificationsModule">Notification module</param>
        public SitePingModule(ISitePingServiceWithLastResult sitePingServiceWithLastResult, INotificationsModule notificationsModule)
            : base(notificationsModule)
        {
            this.sitePingServiceWithLastResult = sitePingServiceWithLastResult;
        }
        /// <summary>
        /// Gets all monitorable objects for checking
        /// </summary>
        /// <returns>List of monitorble objects</returns>
        protected override IList<MasterDataSiteInfo> ServiceExtractor()
        {
            return sitePingServiceWithLastResult.GetAllInfos();
        }
        /// <summary>
        /// Save result
        /// </summary>
        protected override void SaveCheckingResult(MasterDataSiteCheckResults result)
        {
            sitePingServiceWithLastResult.SetCheckingResult(result);
        }
        /// <summary>
        /// Gets previous result of checking
        /// </summary>
        /// <param name="serviceInfo">Info about monitorable object</param>
        protected override MasterDataSiteCheckResults LastResultExtractor(MasterDataSiteInfo serviceInfo)
        {
            return sitePingServiceWithLastResult.GetLastResult(serviceInfo.Id);
        }
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected override MasterDataSiteCheckResults CheckServiceWithLastResult(MasterDataSiteInfo serviceInfo)
        {
            var ping = new Ping();
            var result = ping.Send(serviceInfo.SitePath);
            return new MasterDataSiteCheckResults
            {
                Attempt = 1,
                CheckDate = DateTime.Now,
                MasterDataSiteInfoId = serviceInfo.Id,
                CheckStatus = result != null && result.Status == IPStatus.Success ? 1 : 0,
            };
        }
        /// <summary>
        /// Module type
        /// </summary>
        protected override CheckModuleType CheckModuleType
        {
            get { return CheckModuleType.Site; }
        }
    }
}
