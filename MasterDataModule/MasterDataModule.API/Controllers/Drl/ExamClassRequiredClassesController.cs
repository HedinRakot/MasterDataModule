using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamClassRequiredClass"/> entity
    /// </summary>
    public partial class ExamClassRequiredClassesController: ClientApiController<ExamClassRequiredClassModel, ExamClassRequiredClass, int, IExamClassRequiredClassManager>
    {

        public ExamClassRequiredClassesController(IExamClassRequiredClassManager manager): base(manager){}

        protected override void EntityToModel(ExamClassRequiredClass entity, ExamClassRequiredClassModel model)
        {
            model.examClassId = entity.ExamClassId;
            model.examClassIdRequired = entity.ExamClassIdRequired;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(ExamClassRequiredClassModel model, ExamClassRequiredClass entity, ActionTypes actionType)
        {
            entity.ExamClassId = model.examClassId;
            entity.ExamClassIdRequired = model.examClassIdRequired;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
