using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;

namespace MonitoringAgent.Notifications.Interfaces
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
    }
}