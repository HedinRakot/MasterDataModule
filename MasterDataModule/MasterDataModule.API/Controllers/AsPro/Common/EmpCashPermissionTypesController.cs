using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.EmpCashPermissionType })]
    /// <summary>
    ///     Controller for <see cref="EmpCashPermissionType"/> entity
    /// </summary>
    public partial class EmpCashPermissionTypesController: ClientApiController<EmpCashPermissionTypeModel, EmpCashPermissionType, int, IEmpCashPermissionTypeManager>
    {

        public EmpCashPermissionTypesController(IEmpCashPermissionTypeManager manager): base(manager){}

        protected override void EntityToModel(EmpCashPermissionType entity, EmpCashPermissionTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(EmpCashPermissionTypeModel model, EmpCashPermissionType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
