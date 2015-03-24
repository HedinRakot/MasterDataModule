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
    ///     Controller for <see cref="Role"/> entity
    /// </summary>
    public partial class RolesController: ClientApiController<RoleModel, Role, int, IRoleManager>
    {

        public RolesController(IRoleManager manager): base(manager){}

        protected override void EntityToModel(Role entity, RoleModel model)
        {
            model.name = entity.Name;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;

            ExtraEntityToModel(entity, model);
        }
        protected override void ModelToEntity(RoleModel model, Role entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;

            ExtraModelToEntity(entity, model, actionType);
        }
    }
}
