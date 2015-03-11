using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdOrderCancelationReason"/> entity
    /// </summary>
    public partial class OrdOrderCancelationReasonsController: ClientApiController<OrdOrderCancelationReasonModel, OrdOrderCancelationReason, int, IOrdOrderCancelationReasonManager>
    {

        public OrdOrderCancelationReasonsController(IOrdOrderCancelationReasonManager manager): base(manager){}

        protected override void EntityToModel(OrdOrderCancelationReason entity, OrdOrderCancelationReasonModel model)
        {
            model.cancelationReasonText = entity.CancelationReasonText;
        }
        protected override void ModelToEntity(OrdOrderCancelationReasonModel model, OrdOrderCancelationReason entity, ActionTypes actionType)
        {
            entity.CancelationReasonText = model.cancelationReasonText;
        }
    }
}
