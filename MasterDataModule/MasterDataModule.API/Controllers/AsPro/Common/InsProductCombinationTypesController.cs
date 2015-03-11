using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsProductCombinationType"/> entity
    /// </summary>
    public partial class InsProductCombinationTypesController: ClientApiController<InsProductCombinationTypeModel, InsProductCombinationType, int, IInsProductCombinationTypeManager>
    {

        public InsProductCombinationTypesController(IInsProductCombinationTypeManager manager): base(manager){}

        protected override void EntityToModel(InsProductCombinationType entity, InsProductCombinationTypeModel model)
        {
            model.description = entity.Description;
        }
        protected override void ModelToEntity(InsProductCombinationTypeModel model, InsProductCombinationType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
        }
    }
}
