using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="MeetingPoint"/> entity
    /// </summary>
    public partial class MeetingPointsController: ClientApiController<MeetingPointModel, MeetingPoint, int, IMeetingPointManager>
    {

        public MeetingPointsController(IMeetingPointManager manager): base(manager){}

        protected override void EntityToModel(MeetingPoint entity, MeetingPointModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
        }
        protected override void ModelToEntity(MeetingPointModel model, MeetingPoint entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
        }
    }
}