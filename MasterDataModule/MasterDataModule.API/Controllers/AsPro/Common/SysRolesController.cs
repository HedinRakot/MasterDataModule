using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.SysRole })]
    /// <summary>
    ///     Controller for <see cref="SysRole"/> entity
    /// </summary>
    public partial class SysRolesController: ClientApiController<SysRoleModel, SysRole, int, ISysRoleManager>
    {

        public SysRolesController(ISysRoleManager manager): base(manager){}

        protected override void EntityToModel(SysRole entity, SysRoleModel model)
        {
            model.roleNumber = entity.RoleNumber;
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SysRoleModel model, SysRole entity, ActionTypes actionType)
        {
            entity.RoleNumber = model.roleNumber;
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
