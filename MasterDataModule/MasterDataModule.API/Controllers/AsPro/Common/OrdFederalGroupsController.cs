using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdFederalGroup"/> entity
    /// </summary>
    public partial class OrdFederalGroupsController: ClientApiController<OrdFederalGroupModel, OrdFederalGroup, int, IOrdFederalGroupManager>
    {

        public OrdFederalGroupsController(IOrdFederalGroupManager manager): base(manager){}

        protected override void EntityToModel(OrdFederalGroup entity, OrdFederalGroupModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(OrdFederalGroupModel model, OrdFederalGroup entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
