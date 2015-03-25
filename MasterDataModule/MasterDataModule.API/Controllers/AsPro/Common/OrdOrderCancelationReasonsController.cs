using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrdOrderCancelationReason })]
    /// <summary>
    ///     Controller for <see cref="OrdOrderCancelationReason"/> entity
    /// </summary>
    public partial class OrdOrderCancelationReasonsController: ClientApiController<OrdOrderCancelationReasonModel, OrdOrderCancelationReason, int, IOrdOrderCancelationReasonManager>
    {

        public OrdOrderCancelationReasonsController(IOrdOrderCancelationReasonManager manager): base(manager){}

        protected override void EntityToModel(OrdOrderCancelationReason entity, OrdOrderCancelationReasonModel model)
        {
            model.cancelationReasonText = entity.CancelationReasonText;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdOrderCancelationReasonModel model, OrdOrderCancelationReason entity, ActionTypes actionType)
        {
            entity.CancelationReasonText = model.cancelationReasonText;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
