using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="HolidayOrdFederalState"/> entity
    /// </summary>
    public partial class HolidayOrdFederalStatesController: ClientApiController<HolidayOrdFederalStateModel, HolidayOrdFederalState, int, IHolidayOrdFederalStateManager>
    {

        public HolidayOrdFederalStatesController(IHolidayOrdFederalStateManager manager): base(manager){}

        protected override void EntityToModel(HolidayOrdFederalState entity, HolidayOrdFederalStateModel model)
        {
            model.holidayId = entity.HolidayId;
            model.ordFederalStateId = entity.OrdFederalStateId;
        }
        protected override void ModelToEntity(HolidayOrdFederalStateModel model, HolidayOrdFederalState entity, ActionTypes actionType)
        {
            entity.HolidayId = model.holidayId;
            entity.OrdFederalStateId = model.ordFederalStateId;
        }
    }
}
