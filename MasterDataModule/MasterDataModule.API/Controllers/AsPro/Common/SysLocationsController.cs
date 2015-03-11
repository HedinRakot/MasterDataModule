using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="SysLocation"/> entity
    /// </summary>
    public partial class SysLocationsController: ClientApiController<SysLocationModel, SysLocation, int, ISysLocationManager>
    {

        public SysLocationsController(ISysLocationManager manager): base(manager){}

        protected override void EntityToModel(SysLocation entity, SysLocationModel model)
        {
            model.locationCode = entity.LocationCode;
            model.locationName = entity.LocationName;
            model.sysCountryId = entity.SysCountryId;
            model.ordFederalStateId = entity.OrdFederalStateId;
        }
        protected override void ModelToEntity(SysLocationModel model, SysLocation entity, ActionTypes actionType)
        {
            entity.LocationCode = model.locationCode;
            entity.LocationName = model.locationName;
            entity.SysCountryId = model.sysCountryId;
            entity.OrdFederalStateId = model.ordFederalStateId;
        }
    }
}
