using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="EmpEmployeeSysRoleRsp"/> entity
    /// </summary>
    public partial class EmpEmployeeSysRoleRspsController: ClientApiController<EmpEmployeeSysRoleRspModel, EmpEmployeeSysRoleRsp, int, IEmpEmployeeSysRoleRspManager>
    {

        public EmpEmployeeSysRoleRspsController(IEmpEmployeeSysRoleRspManager manager): base(manager){}

        protected override void EntityToModel(EmpEmployeeSysRoleRsp entity, EmpEmployeeSysRoleRspModel model)
        {
            model.empEmployeeId = entity.EmpEmployeeId;
            model.sysRoleId = entity.SysRoleId;
        }
        protected override void ModelToEntity(EmpEmployeeSysRoleRspModel model, EmpEmployeeSysRoleRsp entity, ActionTypes actionType)
        {
            entity.EmpEmployeeId = model.empEmployeeId;
            entity.SysRoleId = model.sysRoleId;
        }
    }
}
