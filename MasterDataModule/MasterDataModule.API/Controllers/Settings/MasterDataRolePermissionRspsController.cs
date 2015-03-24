using MasterDataModule.API.Models;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using System;

namespace MasterDataModule.API.Controllers.Settings
{
    /// <summary>
    ///     Controller for <see cref="MasterDataRolePermissionRsp"/> entity
    /// </summary>
    public partial class MasterDataRolePermissionRspsController: ClientApiController<MasterDataRolePermissionRspModel, MasterDataRolePermissionRsp, int, IMasterDataRolePermissionRspManager>
    {

        public MasterDataRolePermissionRspsController(IMasterDataRolePermissionRspManager manager): base(manager){}

        protected override void EntityToModel(MasterDataRolePermissionRsp entity, MasterDataRolePermissionRspModel model)
        {
            model.masterDataRoleId = entity.MasterDataRoleId;
            model.masterDataPermissionId = entity.MasterDataPermissionId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataRolePermissionRspModel model, MasterDataRolePermissionRsp entity, ActionTypes actionType)
        {
            entity.MasterDataRoleId = model.masterDataRoleId;
            entity.MasterDataPermissionId = model.masterDataPermissionId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
