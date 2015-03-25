using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.EmpEmployeeOrgOrganizationalUnitRsp })]
    /// <summary>
    ///     Controller for <see cref="EmpEmployeeOrgOrganizationalUnitRsp"/> entity
    /// </summary>
    public partial class EmpEmployeeOrgOrganizationalUnitRspsController: ClientApiController<EmpEmployeeOrgOrganizationalUnitRspModel, EmpEmployeeOrgOrganizationalUnitRsp, int, IEmpEmployeeOrgOrganizationalUnitRspManager>
    {

        public EmpEmployeeOrgOrganizationalUnitRspsController(IEmpEmployeeOrgOrganizationalUnitRspManager manager): base(manager){}

        protected override void EntityToModel(EmpEmployeeOrgOrganizationalUnitRsp entity, EmpEmployeeOrgOrganizationalUnitRspModel model)
        {
            model.empEmployeeId = entity.EmpEmployeeId;
            model.orgOrganizationalUnitId = entity.OrgOrganizationalUnitId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(EmpEmployeeOrgOrganizationalUnitRspModel model, EmpEmployeeOrgOrganizationalUnitRsp entity, ActionTypes actionType)
        {
            entity.EmpEmployeeId = model.empEmployeeId;
            entity.OrgOrganizationalUnitId = model.orgOrganizationalUnitId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
