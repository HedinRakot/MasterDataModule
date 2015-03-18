using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamClassInclusiveClass"/> entity
    /// </summary>
    public partial class ExamClassInclusiveClassesController: ClientApiController<ExamClassInclusiveClassModel, ExamClassInclusiveClass, int, IExamClassInclusiveClassManager>
    {

        public ExamClassInclusiveClassesController(IExamClassInclusiveClassManager manager): base(manager){}

        protected override void EntityToModel(ExamClassInclusiveClass entity, ExamClassInclusiveClassModel model)
        {
            model.examClassId = entity.ExamClassId;
            model.examClassIdInclusive = entity.ExamClassIdInclusive;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isConditional = entity.IsConditional;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ExamClassInclusiveClassModel model, ExamClassInclusiveClass entity, ActionTypes actionType)
        {
            entity.ExamClassId = model.examClassId;
            entity.ExamClassIdInclusive = model.examClassIdInclusive;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.IsConditional = model.isConditional;
        }
    }
}
