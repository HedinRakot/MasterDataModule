using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WindowsService.Interfaces;

namespace MonitoringAgent.WindowsService
{
    /// <summary>
    /// Module for checking windows services
    /// </summary>
    public class WindowsServiceCheckingModule: CheckingModuleWithLastResult<MasterDataWindowsServiceInfo, MasterDataWindowsServiceCheckResults>
    {
        private readonly IWindowsServicePingService pingService;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pingService">Ping service</param>
        /// <param name="notficationModule">Notification module</param>
        public WindowsServiceCheckingModule(IWindowsServicePingService pingService, INotificationsModule notficationModule)
            : base(notficationModule)
        {
            this.pingService = pingService;
        }

        /// <summary>
        /// Gets all monitorable objects for checking
        /// </summary>
        /// <returns>List of monitorble objects</returns>
        protected override IList<MasterDataWindowsServiceInfo> ServiceExtractor()
        {
            return pingService.GetAllInfos();
        }

        /// <summary>
        /// Save results of checking
        /// </summary>
        /// <param name="result">Result</param>
        protected override void SaveCheckingResult(MasterDataWindowsServiceCheckResults result)
        {
            pingService.SetCheckingResult(result);
        }

        /// <summary>
        /// Module type
        /// </summary>
        protected override CheckModuleType CheckModuleType
        {
            get { return CheckModuleType.WindowsService; }
        }

        /// <summary>
        /// Gets previous result of checking
        /// </summary>
        /// <param name="serviceInfo">Info about monitorable object</param>
        protected override MasterDataWindowsServiceCheckResults LastResultExtractor(MasterDataWindowsServiceInfo serviceInfo)
        {
            return pingService.GetLastResult(serviceInfo.Id);
        }

        protected override MasterDataWindowsServiceCheckResults CheckServiceWithLastResult(MasterDataWindowsServiceInfo serviceInfo)
        {
            return pingService.CheckService(serviceInfo);
        }
    }
}
