using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.SysLocation })]
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
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SysLocationModel model, SysLocation entity, ActionTypes actionType)
        {
            entity.LocationCode = model.locationCode;
            entity.LocationName = model.locationName;
            entity.SysCountryId = model.sysCountryId;
            entity.OrdFederalStateId = model.ordFederalStateId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
