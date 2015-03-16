using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgCostCenterResponsibleEmployeeRsp"/> entity
    /// </summary>
    public partial class OrgCostCenterResponsibleEmployeeRspsController: ClientApiController<OrgCostCenterResponsibleEmployeeRspModel, OrgCostCenterResponsibleEmployeeRsp, int, IOrgCostCenterResponsibleEmployeeRspManager>
    {

        public OrgCostCenterResponsibleEmployeeRspsController(IOrgCostCenterResponsibleEmployeeRspManager manager): base(manager){}

        protected override void EntityToModel(OrgCostCenterResponsibleEmployeeRsp entity, OrgCostCenterResponsibleEmployeeRspModel model)
        {
            model.orgCostCenterId = entity.OrgCostCenterId;
            model.empEmployeeId = entity.EmpEmployeeId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(OrgCostCenterResponsibleEmployeeRspModel model, OrgCostCenterResponsibleEmployeeRsp entity, ActionTypes actionType)
        {
            entity.OrgCostCenterId = model.orgCostCenterId;
            entity.EmpEmployeeId = model.empEmployeeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}