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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.SysTable })]
    /// <summary>
    ///     Controller for <see cref="SysTable"/> entity
    /// </summary>
    public partial class SysTablesController: ClientApiController<SysTableModel, SysTable, int, ISysTableManager>
    {

        public SysTablesController(ISysTableManager manager): base(manager){}

        protected override void EntityToModel(SysTable entity, SysTableModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.editMode = entity.EditMode;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;

            ExtraEntityToModel(entity, model);
        }
        protected override void ModelToEntity(SysTableModel model, SysTable entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.EditMode = model.editMode;
        }
    }
}
