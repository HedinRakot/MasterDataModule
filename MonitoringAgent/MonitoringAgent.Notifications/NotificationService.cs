﻿using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Notifications
{
    /// <summary>
    /// Service for working with notifications
    /// </summary>
    internal sealed class NotificationService: BaseManagersService, INotificationService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managersProvider">Managers provider</param>
        public NotificationService(IManagersProvider managersProvider) : base(managersProvider)
        {
        }

        /// <summary>
        /// Gets all notifications which have alert on flag for list of monitorable objects
        /// </summary>
        /// <param name="serviceIds">List of monitorable objects</param>
        /// <param name="checkModuleType">Module type</param>
        public Dictionary<int, List<MasterDataNotifications>> GetAllNotifications(IList<int> serviceIds, CheckModuleType checkModuleType)
        {
            var notificationManager = ManagersProvider.GetManager<IMasterDataNotificationsManager>();
            var rspManager = ManagersProvider.GetManager<IMasterDataMonitorableInfoMasterDataNotificationsRspManager>();

            var query = from notification in notificationManager.GetAllEntities()
                join rsp in rspManager.GetAllEntities() on notification.Id equals rsp.MasterDataNotificationsId
                where rsp.MonitorableInfoType == (int)checkModuleType && serviceIds.Contains(rsp.MonitorableInfoId)
                group notification by rsp.MonitorableInfoId
                into g
                select new {g.Key, g};

            return query.ToDictionary(t => t.Key, t => t.g.ToList());
        }
    }
}