using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="EmpEmployeeOrgCostCenterRsp"/> entity
    /// </summary>
    public partial class EmpEmployeeOrgCostCenterRspsController: ClientApiController<EmpEmployeeOrgCostCenterRspModel, EmpEmployeeOrgCostCenterRsp, int, IEmpEmployeeOrgCostCenterRspManager>
    {

        public EmpEmployeeOrgCostCenterRspsController(IEmpEmployeeOrgCostCenterRspManager manager): base(manager){}

        protected override void EntityToModel(EmpEmployeeOrgCostCenterRsp entity, EmpEmployeeOrgCostCenterRspModel model)
        {
            model.empEmployeeId = entity.EmpEmployeeId;
            model.orgCostCenterId = entity.OrgCostCenterId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(EmpEmployeeOrgCostCenterRspModel model, EmpEmployeeOrgCostCenterRsp entity, ActionTypes actionType)
        {
            entity.EmpEmployeeId = model.empEmployeeId;
            entity.OrgCostCenterId = model.orgCostCenterId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
