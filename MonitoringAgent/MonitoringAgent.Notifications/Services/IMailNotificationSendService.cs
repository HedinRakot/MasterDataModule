﻿using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Notifications.Services
{
    /// <summary>
    /// Service for send notifications by e-mail
    /// </summary>
    public interface IMailNotificationSendService
    {
        /// <summary>
        /// Send e-mail notification to list of subscribers
        /// </summary>
        /// <param name="notification">Notification</param>
        /// <param name="subscribers">List of subscribers</param>
        void SendNotification(MasterDataNotifications notification, IList<MasterDataSubscribers> subscribers);
    }
}