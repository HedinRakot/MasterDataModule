using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrgAccountingArea })]
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
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
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
