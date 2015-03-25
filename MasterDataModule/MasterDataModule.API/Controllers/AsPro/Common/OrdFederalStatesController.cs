using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrdFederalState })]
    /// <summary>
    ///     Controller for <see cref="OrdFederalState"/> entity
    /// </summary>
    public partial class OrdFederalStatesController: ClientApiController<OrdFederalStateModel, OrdFederalState, int, IOrdFederalStateManager>
    {

        public OrdFederalStatesController(IOrdFederalStateManager manager): base(manager){}

        protected override void EntityToModel(OrdFederalState entity, OrdFederalStateModel model)
        {
            model.federalStateName = entity.FederalStateName;
            model.description = entity.Description;
            model.sysCountryId = entity.SysCountryId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdFederalStateModel model, OrdFederalState entity, ActionTypes actionType)
        {
            entity.FederalStateName = model.federalStateName;
            entity.Description = model.description;
            entity.SysCountryId = model.sysCountryId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
