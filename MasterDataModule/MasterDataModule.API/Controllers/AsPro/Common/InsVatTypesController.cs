using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsVatType })]
    /// <summary>
    ///     Controller for <see cref="InsVatType"/> entity
    /// </summary>
    public partial class InsVatTypesController: ClientApiController<InsVatTypeModel, InsVatType, int, IInsVatTypeManager>
    {

        public InsVatTypesController(IInsVatTypeManager manager): base(manager){}

        protected override void EntityToModel(InsVatType entity, InsVatTypeModel model)
        {
            model.description = entity.Description;
            model.taxCode = entity.TaxCode;
            model.percent = entity.Percent;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsVatTypeModel model, InsVatType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.TaxCode = model.taxCode;
            entity.Percent = model.percent;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
