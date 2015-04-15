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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataWindowsServiceInfo })]
    /// <summary>
    ///     Controller for <see cref="MasterDataWindowsServiceInfo"/> entity
    /// </summary>
    public partial class MasterDataWindowsServiceInfosController: ClientApiController<MasterDataWindowsServiceInfoModel, MasterDataWindowsServiceInfo, int, IMasterDataWindowsServiceInfoManager>
    {

        public MasterDataWindowsServiceInfosController(IMasterDataWindowsServiceInfoManager manager): base(manager){}

        protected override void EntityToModel(MasterDataWindowsServiceInfo entity, MasterDataWindowsServiceInfoModel model)
        {
            model.name = entity.Name;
            model.machineName = entity.MachineName;
            model.serviceName = entity.ServiceName;
            model.timeoutChecking = entity.TimeoutChecking;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataWindowsServiceInfoModel model, MasterDataWindowsServiceInfo entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.MachineName = model.machineName;
            entity.ServiceName = model.serviceName;
            entity.TimeoutChecking = model.timeoutChecking;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
