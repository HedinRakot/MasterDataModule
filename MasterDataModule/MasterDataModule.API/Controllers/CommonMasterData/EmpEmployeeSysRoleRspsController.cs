using TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.CommonMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class EmpEmployeeSysRoleRspsController :
        ClientApiController<EmpEmployeeSysRoleRspModel, EmpEmployeeSysRoleRsp, int, IEmpEmployeeSysRoleRspManager>
    {
        public EmpEmployeeSysRoleRspsController(IEmpEmployeeSysRoleRspManager manager)
            : base(manager)
        {
        }

        protected override void EntityToModel(EmpEmployeeSysRoleRsp entity, EmpEmployeeSysRoleRspModel model)
        {
            model.empEmployeeId = entity.EmpEmployeeId;
            model.sysRoleId = entity.SysRoleId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.ChangeDate = entity.ChangeDate;
        }

        protected override void ModelToEntity(EmpEmployeeSysRoleRspModel model, EmpEmployeeSysRoleRsp entity, ActionTypes actionType)
        {
            entity.SysRoleId = model.sysRoleId;
            entity.EmpEmployeeId = model.empEmployeeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}