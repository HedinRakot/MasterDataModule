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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataNotificationsMasterDataSubscribersRsp })]
    /// <summary>
    ///     Controller for <see cref="MasterDataNotificationsMasterDataSubscribersRsp"/> entity
    /// </summary>
    public partial class MasterDataNotificationsMasterDataSubscribersRspsController: ClientApiController<MasterDataNotificationsMasterDataSubscribersRspModel, MasterDataNotificationsMasterDataSubscribersRsp, int, IMasterDataNotificationsMasterDataSubscribersRspManager>
    {

        public MasterDataNotificationsMasterDataSubscribersRspsController(IMasterDataNotificationsMasterDataSubscribersRspManager manager): base(manager){}

        protected override void EntityToModel(MasterDataNotificationsMasterDataSubscribersRsp entity, MasterDataNotificationsMasterDataSubscribersRspModel model)
        {
            model.masterDataNotificationsId = entity.MasterDataNotificationsId;
            model.masterDataSubscribersId = entity.MasterDataSubscribersId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataNotificationsMasterDataSubscribersRspModel model, MasterDataNotificationsMasterDataSubscribersRsp entity, ActionTypes actionType)
        {
            entity.MasterDataNotificationsId = model.masterDataNotificationsId;
            entity.MasterDataSubscribersId = model.masterDataSubscribersId;
        }
    }
}
