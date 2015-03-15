using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsInspectionStep"/> entity
    /// </summary>
    public partial class InsInspectionStepsController: ClientApiController<InsInspectionStepModel, InsInspectionStep, int, IInsInspectionStepManager>
    {

        public InsInspectionStepsController(IInsInspectionStepManager manager): base(manager){}

        protected override void EntityToModel(InsInspectionStep entity, InsInspectionStepModel model)
        {
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsInspectionStepModel model, InsInspectionStep entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
