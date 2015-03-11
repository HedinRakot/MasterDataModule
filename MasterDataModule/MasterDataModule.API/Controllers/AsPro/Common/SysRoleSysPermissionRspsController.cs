using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="SysRoleSysPermissionRsp"/> entity
    /// </summary>
    public partial class SysRoleSysPermissionRspsController: ClientApiController<SysRoleSysPermissionRspModel, SysRoleSysPermissionRsp, int, ISysRoleSysPermissionRspManager>
    {

        public SysRoleSysPermissionRspsController(ISysRoleSysPermissionRspManager manager): base(manager){}

        protected override void EntityToModel(SysRoleSysPermissionRsp entity, SysRoleSysPermissionRspModel model)
        {
            model.sysRoleId = entity.SysRoleId;
            model.sysPermissionId = entity.SysPermissionId;
        }
        protected override void ModelToEntity(SysRoleSysPermissionRspModel model, SysRoleSysPermissionRsp entity, ActionTypes actionType)
        {
            entity.SysRoleId = model.sysRoleId;
            entity.SysPermissionId = model.sysPermissionId;
        }
    }
}
