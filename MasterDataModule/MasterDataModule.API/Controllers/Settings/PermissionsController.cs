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
    ///     Controller for <see cref="Permission"/> entity
    /// </summary>
    public partial class PermissionsController: ClientApiController<PermissionModel, Permission, int, IPermissionManager>
    {

        public PermissionsController(IPermissionManager manager): base(manager){}

        protected override void EntityToModel(Permission entity, PermissionModel model)
        {
            model.systemName = entity.SystemName;
            model.name = entity.Name;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(PermissionModel model, Permission entity, ActionTypes actionType)
        {
            entity.SystemName = model.systemName;
            entity.Name = model.name;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
