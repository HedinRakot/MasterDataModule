using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.HolidayOrdFederalState })]
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
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(HolidayOrdFederalStateModel model, HolidayOrdFederalState entity, ActionTypes actionType)
        {
            entity.HolidayId = model.holidayId;
            entity.OrdFederalStateId = model.ordFederalStateId;
        }
    }
}
