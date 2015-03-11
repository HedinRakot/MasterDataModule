using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsUnitCode"/> entity
    /// </summary>
    public partial class InsUnitCodesController: ClientApiController<InsUnitCodeModel, InsUnitCode, int, IInsUnitCodeManager>
    {

        public InsUnitCodesController(IInsUnitCodeManager manager): base(manager){}

        protected override void EntityToModel(InsUnitCode entity, InsUnitCodeModel model)
        {
            model.orgAccountingAreaId = entity.OrgAccountingAreaId;
            model.ordFederalStateId = entity.OrdFederalStateId;
            model.ordAreaOfWorkId = entity.OrdAreaOfWorkId;
            model.unitCode = entity.UnitCode;
        }
        protected override void ModelToEntity(InsUnitCodeModel model, InsUnitCode entity, ActionTypes actionType)
        {
            entity.OrgAccountingAreaId = model.orgAccountingAreaId;
            entity.OrdFederalStateId = model.ordFederalStateId;
            entity.OrdAreaOfWorkId = model.ordAreaOfWorkId;
            entity.UnitCode = model.unitCode;
        }
    }
}
