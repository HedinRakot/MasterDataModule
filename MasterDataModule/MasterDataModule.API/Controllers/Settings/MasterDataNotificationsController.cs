using MasterDataModule.API.Models;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using System;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataNotifications })]
    /// <summary>
    ///     Controller for <see cref="MasterDataNotifications"/> entity
    /// </summary>
    public partial class MasterDataNotificationsController: ClientApiController<MasterDataNotificationsModel, MasterDataNotifications, int, IMasterDataNotificationsManager>
    {

        public MasterDataNotificationsController(IMasterDataNotificationsManager manager): base(manager){}

        protected override void EntityToModel(MasterDataNotifications entity, MasterDataNotificationsModel model)
        {
            model.notificationType = entity.NotificationType;
            model.isAlertOn = entity.IsAlertOn;
            model.alertCheckStatus = entity.AlertCheckStatus;
            model.alertAttemptCount = entity.AlertAttemptCount;
            model.message = entity.Message;
            model.subject = entity.Subject;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataNotificationsModel model, MasterDataNotifications entity, ActionTypes actionType)
        {
            entity.NotificationType = model.notificationType;
            entity.IsAlertOn = model.isAlertOn;
            entity.AlertCheckStatus = model.alertCheckStatus;
            entity.AlertAttemptCount = model.alertAttemptCount;
            entity.Message = model.message;
            entity.Subject = model.subject;
        }
    }
}
