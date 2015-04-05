using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;

namespace MonitoringAgent.Notifications.Interfaces
{
    /// <summary>
    /// Module for managing notifications 
    /// </summary>
    public interface INotificationsModule
    {
        /// <summary>
        /// Gets all notifications which have alert on flag for list of monitorable objects
        /// </summary>
        /// <param name="objectIds">List of monitorable objects</param>
        /// <param name="moduleType">Module type</param>
        Dictionary<int, List<MasterDataNotifications>> GetAllNotifications(IList<int> objectIds, CheckModuleType moduleType);

        /// <summary>
        /// Notified to all subscribers about event
        /// </summary>
        /// <param name="notification">Notification</param>
        void Notify(MasterDataNotifications notification);
    }
}