using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsCoreDataProductGroup"/> entity
    /// </summary>
    public partial class InsCoreDataProductGroupsController: ClientApiController<InsCoreDataProductGroupModel, InsCoreDataProductGroup, int, IInsCoreDataProductGroupManager>
    {

        public InsCoreDataProductGroupsController(IInsCoreDataProductGroupManager manager): base(manager){}

        protected override void EntityToModel(InsCoreDataProductGroup entity, InsCoreDataProductGroupModel model)
        {
            model.name = entity.Name;
            model.defaultDuration = entity.DefaultDuration;
        }
        protected override void ModelToEntity(InsCoreDataProductGroupModel model, InsCoreDataProductGroup entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.DefaultDuration = model.defaultDuration;
        }
    }
}
