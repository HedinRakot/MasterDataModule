using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Services.Common.Contracts
{
    /// <summary>
    /// Service for working with notifications
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Gets all notifications which have alert on flag for list of monitorable objects
        /// </summary>
        /// <param name="serviceIds">List of monitorable objects</param>
        /// <param name="checkModuleType">Module type</param>
        Dictionary<int, List<MasterDataNotifications>> GetAllNotifications(IList<int> serviceIds, CheckModuleType checkModuleType);
        /// <summary>
        /// Notified to all subscribers about event
        /// </summary>
        /// <param name="notification">Notification</param>
        void Notify(MasterDataNotifications notification);
    }
}