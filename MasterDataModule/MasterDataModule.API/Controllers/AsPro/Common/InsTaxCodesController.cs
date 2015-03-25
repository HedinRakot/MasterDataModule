using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsTaxCode })]
    /// <summary>
    ///     Controller for <see cref="InsTaxCode"/> entity
    /// </summary>
    public partial class InsTaxCodesController: ClientApiController<InsTaxCodeModel, InsTaxCode, int, IInsTaxCodeManager>
    {

        public InsTaxCodesController(IInsTaxCodeManager manager): base(manager){}

        protected override void EntityToModel(InsTaxCode entity, InsTaxCodeModel model)
        {
            model.taxCode = entity.TaxCode;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsTaxCodeModel model, InsTaxCode entity, ActionTypes actionType)
        {
            entity.TaxCode = model.taxCode;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
