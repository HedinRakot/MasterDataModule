using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsUnitCode })]
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
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsUnitCodeModel model, InsUnitCode entity, ActionTypes actionType)
        {
            entity.OrgAccountingAreaId = model.orgAccountingAreaId;
            entity.OrdFederalStateId = model.ordFederalStateId;
            entity.OrdAreaOfWorkId = model.ordAreaOfWorkId;
            entity.UnitCode = model.unitCode;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
