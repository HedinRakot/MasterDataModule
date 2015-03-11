using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsTaxCode"/> entity
    /// </summary>
    public partial class InsTaxCodesController: ClientApiController<InsTaxCodeModel, InsTaxCode, int, IInsTaxCodeManager>
    {

        public InsTaxCodesController(IInsTaxCodeManager manager): base(manager){}

        protected override void EntityToModel(InsTaxCode entity, InsTaxCodeModel model)
        {
            model.taxCode = entity.TaxCode;
        }
        protected override void ModelToEntity(InsTaxCodeModel model, InsTaxCode entity, ActionTypes actionType)
        {
            entity.TaxCode = model.taxCode;
        }
    }
}
