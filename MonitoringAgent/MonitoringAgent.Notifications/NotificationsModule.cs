using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;

namespace MonitoringAgent.Notifications
{
    /// <summary>
    /// Module for manage notifications
    /// </summary>
    internal sealed class NotificationsModule : INotificationsModule
    {
        private readonly INotificationService notificationService;
        private readonly ISubscribersService subscribersService;

        /// <summary>
        /// Ctor
        /// </summary>
        public NotificationsModule(INotificationService notificationService, ISubscribersService subscribersService)
        {
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
            //TODO Notify subscribers
        }
    }
}
