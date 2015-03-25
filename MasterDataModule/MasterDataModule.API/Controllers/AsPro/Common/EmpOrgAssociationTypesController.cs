using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.EmpOrgAssociationType })]
    /// <summary>
    ///     Controller for <see cref="EmpOrgAssociationType"/> entity
    /// </summary>
    public partial class EmpOrgAssociationTypesController: ClientApiController<EmpOrgAssociationTypeModel, EmpOrgAssociationType, int, IEmpOrgAssociationTypeManager>
    {

        public EmpOrgAssociationTypesController(IEmpOrgAssociationTypeManager manager): base(manager){}

        protected override void EntityToModel(EmpOrgAssociationType entity, EmpOrgAssociationTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(EmpOrgAssociationTypeModel model, EmpOrgAssociationType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
