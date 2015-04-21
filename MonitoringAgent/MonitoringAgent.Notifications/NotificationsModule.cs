using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Notifications.Interfaces.Services;
using MonitoringAgent.Notifications.Services;

namespace MonitoringAgent.Notifications
{
    /// <summary>
    /// Module for manage notifications
    /// </summary>
    internal sealed class NotificationsModule : INotificationsModule
    {
        private readonly IMailNotificationSendService mailNotificationSendService;
        private readonly INotificationService notificationService;
        private readonly ISubscribersService subscribersService;

        /// <summary>
        /// Ctor
        /// </summary>
        public NotificationsModule(IMailNotificationSendService mailNotificationSendService, 
                                    INotificationService notificationService,
                                    ISubscribersService subscribersService)
        {
            this.mailNotificationSendService = mailNotificationSendService;
            this.notificationService = notificationService;
            this.subscribersService = subscribersService;
        }

        /// <summary>
        /// Gets all notifications which have alert on flag for list of monitorable objects
        /// </summary>
        /// <param name="objectIds">List of monitorable objects</param>
        /// <param name="moduleType">Module type</param>
        public Dictionary<int, List<MasterDataNotifications>> GetAllNotifications(IList<int> objectIds, CheckModuleType moduleType)
        {
            return notificationService.GetAllNotifications(objectIds, moduleType);
        }
        /// <summary>
        /// Notified to all subscribers about event
        /// </summary>
        /// <param name="notification">Notification</param>
        public void Notify(MasterDataNotifications notification)
        {
            var subscribers = subscribersService.GetSubscribers(notification.Id);
            mailNotificationSendService.SendNotification(notification, subscribers);
        }
        /// <summary>
        /// Gets list of all subscribers who should receive report about error in log file
        /// </summary>
        /// <returns></returns>
        public List<MasterDataSubscribers> GetAllErrorSubscribers()
        {
            return subscribersService.GetErrorLogSubscribers();
        }
        /// <summary>
        /// Notify subscriber about errors in log files
        /// </summary>
        /// <param name="subscribers">Subscribers</param>
        /// <param name="errors">List of errors</param>
        public void NotifyAboutErrors(List<MasterDataSubscribers> subscribers, List<ApplicationLogs> errors)
        {
            mailNotificationSendService.SendErrorReport(subscribers, errors);
        }
    }
}
