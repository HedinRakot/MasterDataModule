using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
        }
        protected override void ModelToEntity(InsVatTypeModel model, InsVatType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.TaxCode = model.taxCode;
            entity.Percent = model.percent;
        }
    }
}
