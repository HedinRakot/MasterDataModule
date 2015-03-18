using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsAvailableInspectionStep"/> entity
    /// </summary>
    public partial class InsAvailableInspectionStepsController: ClientApiController<InsAvailableInspectionStepModel, InsAvailableInspectionStep, int, IInsAvailableInspectionStepManager>
    {

        public InsAvailableInspectionStepsController(IInsAvailableInspectionStepManager manager): base(manager){}

        protected override void EntityToModel(InsAvailableInspectionStep entity, InsAvailableInspectionStepModel model)
        {
            model.insInspectionStepId = entity.InsInspectionStepId;
            model.isMandatory = entity.IsMandatory;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsAvailableInspectionStepModel model, InsAvailableInspectionStep entity, ActionTypes actionType)
        {
            entity.InsInspectionStepId = model.insInspectionStepId;
            entity.IsMandatory = model.isMandatory;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
