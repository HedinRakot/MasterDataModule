using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsProductObjectType"/> entity
    /// </summary>
    public partial class InsProductObjectTypesController: ClientApiController<InsProductObjectTypeModel, InsProductObjectType, int, IInsProductObjectTypeManager>
    {

        public InsProductObjectTypesController(IInsProductObjectTypeManager manager): base(manager){}

        protected override void EntityToModel(InsProductObjectType entity, InsProductObjectTypeModel model)
        {
            model.description = entity.Description;
            model.sapId = entity.SapId;
            model.isAuNecessary = entity.IsAuNecessary;
        }
        protected override void ModelToEntity(InsProductObjectTypeModel model, InsProductObjectType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.SapId = model.sapId;
            entity.IsAuNecessary = model.isAuNecessary;
        }
    }
}
