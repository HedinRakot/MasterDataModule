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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataMonitorableInfoMasterDataNotificationsRsp })]
    /// <summary>
    ///     Controller for <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp"/> entity
    /// </summary>
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRspsController: ClientApiController<MasterDataMonitorableInfoMasterDataNotificationsRspModel, MasterDataMonitorableInfoMasterDataNotificationsRsp, int, IMasterDataMonitorableInfoMasterDataNotificationsRspManager>
    {

        public MasterDataMonitorableInfoMasterDataNotificationsRspsController(IMasterDataMonitorableInfoMasterDataNotificationsRspManager manager): base(manager){}

        protected override void EntityToModel(MasterDataMonitorableInfoMasterDataNotificationsRsp entity, MasterDataMonitorableInfoMasterDataNotificationsRspModel model)
        {
            model.monitorableInfoType = entity.MonitorableInfoType;
            model.monitorableInfoId = entity.MonitorableInfoId;
            model.masterDataNotificationsId = entity.MasterDataNotificationsId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;

            ExtraEntityToModel(entity, model);
        }
        protected override void ModelToEntity(MasterDataMonitorableInfoMasterDataNotificationsRspModel model, MasterDataMonitorableInfoMasterDataNotificationsRsp entity, ActionTypes actionType)
        {
            entity.MonitorableInfoType = model.monitorableInfoType;
            entity.MonitorableInfoId = model.monitorableInfoId;
            entity.MasterDataNotificationsId = model.masterDataNotificationsId;
        }
    }
}
