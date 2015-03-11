using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsProductClassGroup"/> entity
    /// </summary>
    public partial class InsProductClassGroupsController: ClientApiController<InsProductClassGroupModel, InsProductClassGroup, int, IInsProductClassGroupManager>
    {

        public InsProductClassGroupsController(IInsProductClassGroupManager manager): base(manager){}

        protected override void EntityToModel(InsProductClassGroup entity, InsProductClassGroupModel model)
        {
            model.description = entity.Description;
            model.sapId = entity.SapId;
        }
        protected override void ModelToEntity(InsProductClassGroupModel model, InsProductClassGroup entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.SapId = model.sapId;
        }
    }
}
