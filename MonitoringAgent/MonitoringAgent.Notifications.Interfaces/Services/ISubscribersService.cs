using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Notifications.Interfaces.Services
{
    /// <summary>
    /// Service for working with subscribers
    /// </summary>
    public interface ISubscribersService
    {
        /// <summary>
        /// Gets all subscribers for notification
        /// </summary>
        /// <param name="notificationId">Identifier of notification</param>
        IList<MasterDataSubscribers> GetSubscribers(int notificationId);
        /// <summary>
        /// Gets list of subscribers who should receive message about error in log
        /// </summary>
        /// <returns></returns>
        List<MasterDataSubscribers> GetErrorLogSubscribers();
    }
}