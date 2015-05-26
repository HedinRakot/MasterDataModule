using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Helpers;
using MonitoringAgent.Services.Common.SignalRNotification;

namespace MonitoringAgent.Services.Common.Base
{
    /// <summary>
    /// Base class for all checking modules
    /// </summary>
    /// <typeparam name="TServiceInfo">Info about monitorable object</typeparam>
    /// <typeparam name="TCheckingResult">Type of result</typeparam>
    public abstract class CheckingModule<TServiceInfo, TCheckingResult> : BaseTimerModule<TServiceInfo>
        where TServiceInfo : class, ICheckServiceInfo
        where TCheckingResult : class, IHasCheckStatus
    {
        private readonly HubNotificator hubNotificator;
        private readonly INotificationsModule notificationsModule;
        private Dictionary<string, List<MasterDataNotifications>> notifications = new Dictionary<string, List<MasterDataNotifications>>();

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="notificationsModule">Module for get info about notifications </param>
        protected CheckingModule(INotificationsModule notificationsModule)
        {
            this.notificationsModule = notificationsModule;
            var hubUrl = SettingsHelper.HubUrl;
            var hubName = SettingsHelper.HubName;
            if (!string.IsNullOrWhiteSpace(hubUrl) && !string.IsNullOrWhiteSpace(hubName))
            {
                hubNotificator = new HubNotificator(hubUrl, hubName);
            }
        }

        /// <summary>
        /// Action which will be invoked when timer elapsed
        /// </summary>
        /// <param name="info">Info about monitorable object which is associated with current timer</param>
        protected override void TimerAction(TServiceInfo info)
        {
            var checkingResult = CheckService(info);

            if (hubNotificator != null && checkingResult != null)
            {
                hubNotificator.SendNotification(CheckModuleType, info.Id, checkingResult.CheckStatus);
            }

            List<MasterDataNotifications> serviceNotifications;
            if (notifications.TryGetValue(info.Name, out serviceNotifications))
            {
                foreach (var notification in serviceNotifications)
                {
                    if (NeedNotify(checkingResult, notification))
                    {
                        notificationsModule.Notify(notification);
                    }
                }
            }

            SaveCheckingResult(checkingResult);
        }

        /// <summary>
        /// Initialize module
        /// </summary>
        public override void Initialize()
        {
            var services = ServiceExtractor();
            var allNotifications = notificationsModule.GetAllNotifications(services.Select(s => s.Id).ToList(), CheckModuleType);
            hubNotificator.Initialize();

            foreach (var service in services)
            {
                List<MasterDataNotifications> serviceNotifications;
                allNotifications.TryGetValue(service.Id, out serviceNotifications);
                AddService(service, service.Name, service.TimeoutChecking);
                if (serviceNotifications != null && serviceNotifications.Count > 0 &&
                    !notifications.ContainsKey(service.Name))
                {
                    notifications.Add(service.Name, serviceNotifications);
                }
            }
        }
        /// <summary>
        /// Gets all monitorable objects for checking
        /// </summary>
        /// <returns>List of monitorble objects</returns>
        protected abstract IList<TServiceInfo> ServiceExtractor();
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected abstract TCheckingResult CheckService(TServiceInfo serviceInfo);
        /// <summary>
        /// Save results of checking
        /// </summary>
        /// <param name="result">Result</param>
        protected abstract void SaveCheckingResult(TCheckingResult result);
        /// <summary>
        /// Module type
        /// </summary>
        protected abstract CheckModuleType CheckModuleType { get; }
        /// <summary>
        /// Checks that we need notify
        /// </summary>
        /// <param name="result">Result</param>
        /// <param name="notification">Notification</param>
        protected abstract bool NeedNotify(TCheckingResult result, MasterDataNotifications notification);
    }
}
