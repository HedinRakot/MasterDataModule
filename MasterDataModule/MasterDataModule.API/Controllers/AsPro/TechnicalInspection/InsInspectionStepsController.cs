using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsInspectionStep })]
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
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsInspectionStepModel model, InsInspectionStep entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
