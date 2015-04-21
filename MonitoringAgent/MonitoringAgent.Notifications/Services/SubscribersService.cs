using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Notifications.Interfaces.Services;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Notifications.Services
{
    /// <summary>
    /// Service for working with subscribers
    /// </summary>
    internal sealed class SubscribersService: BaseManagersService, ISubscribersService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managersProvider">Provides managers</param>
        public SubscribersService(IManagersProvider managersProvider) : base(managersProvider)
        {
        }

        /// <summary>
        /// Gets all subscribers for notification
        /// </summary>
        /// <param name="notificationId">Identifier of notification</param>
        public IList<MasterDataSubscribers> GetSubscribers(int notificationId)
        {
            var scope = ManagersProvider.BeginScope();
            var rspManager = ManagersProvider.GetManager<IMasterDataNotificationsMasterDataSubscribersRspManager>(scope);
            var subscribersManager = ManagersProvider.GetManager<IMasterDataSubscribersManager>(scope);
            ManagersProvider.EndScope(scope);

            var query = from subscriber in subscribersManager.GetAllEntities()
                join rsp in rspManager.GetAllEntities() on subscriber.Id equals rsp.MasterDataSubscribersId
                where rsp.MasterDataNotificationsId == notificationId
                select subscriber;

            return query.ToList();
        }
    }
}
