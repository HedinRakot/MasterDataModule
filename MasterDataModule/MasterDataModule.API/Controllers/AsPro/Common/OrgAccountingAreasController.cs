using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgAccountingArea"/> entity
    /// </summary>
    public partial class OrgAccountingAreasController: ClientApiController<OrgAccountingAreaModel, OrgAccountingArea, int, IOrgAccountingAreaManager>
    {

        public OrgAccountingAreasController(IOrgAccountingAreaManager manager): base(manager){}

        protected override void EntityToModel(OrgAccountingArea entity, OrgAccountingAreaModel model)
        {
            model.accountingArea = entity.AccountingArea;
            model.maxOrderSum = entity.MaxOrderSum;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(OrgAccountingAreaModel model, OrgAccountingArea entity, ActionTypes actionType)
        {
            entity.AccountingArea = model.accountingArea;
            entity.MaxOrderSum = model.maxOrderSum;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
