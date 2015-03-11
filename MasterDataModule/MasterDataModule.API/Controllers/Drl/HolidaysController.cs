using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="Holiday"/> entity
    /// </summary>
    public partial class HolidaysController: ClientApiController<HolidayModel, Holiday, int, IHolidayManager>
    {

        public HolidaysController(IHolidayManager manager): base(manager){}

        protected override void EntityToModel(Holiday entity, HolidayModel model)
        {
            model.name = entity.Name;
            model.date = entity.Date;
        }
        protected override void ModelToEntity(HolidayModel model, Holiday entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Date = model.date;
        }
    }
}
