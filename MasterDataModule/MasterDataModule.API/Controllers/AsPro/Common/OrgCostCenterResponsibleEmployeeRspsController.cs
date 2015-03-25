using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrgCostCenterResponsibleEmployeeRsp })]
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
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
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
