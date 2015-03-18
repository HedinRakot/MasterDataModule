using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamConstraintExamClass"/> entity
    /// </summary>
    public partial class ExamConstraintExamClassesController: ClientApiController<ExamConstraintExamClassModel, ExamConstraintExamClass, int, IExamConstraintExamClassManager>
    {

        public ExamConstraintExamClassesController(IExamConstraintExamClassManager manager): base(manager){}

        protected override void EntityToModel(ExamConstraintExamClass entity, ExamConstraintExamClassModel model)
        {
            model.examConstraintId = entity.ExamConstraintId;
            model.examClassId = entity.ExamClassId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = entity.CreateDate;
            model.changeDate = entity.ChangeDate;
        }
        protected override void ModelToEntity(ExamConstraintExamClassModel model, ExamConstraintExamClass entity, ActionTypes actionType)
        {
            entity.ExamConstraintId = model.examConstraintId;
            entity.ExamClassId = model.examClassId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
