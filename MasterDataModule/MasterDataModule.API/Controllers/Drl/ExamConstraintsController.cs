using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamConstraint"/> entity
    /// </summary>
    public partial class ExamConstraintsController: ClientApiController<ExamConstraintModel, ExamConstraint, int, IExamConstraintManager>
    {

        public ExamConstraintsController(IExamConstraintManager manager): base(manager){}

        protected override void EntityToModel(ExamConstraint entity, ExamConstraintModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.constraintType = entity.ConstraintType;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = entity.CreateDate;
            model.changeDate = entity.ChangeDate;
        }
        protected override void ModelToEntity(ExamConstraintModel model, ExamConstraint entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.ConstraintType = model.constraintType;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
