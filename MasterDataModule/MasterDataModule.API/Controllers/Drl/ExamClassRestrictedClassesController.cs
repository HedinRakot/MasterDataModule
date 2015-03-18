using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamClassRestrictedClass"/> entity
    /// </summary>
    public partial class ExamClassRestrictedClassesController: ClientApiController<ExamClassRestrictedClassModel, ExamClassRestrictedClass, int, IExamClassRestrictedClassManager>
    {

        public ExamClassRestrictedClassesController(IExamClassRestrictedClassManager manager): base(manager){}

        protected override void EntityToModel(ExamClassRestrictedClass entity, ExamClassRestrictedClassModel model)
        {
            model.examClassId = entity.ExamClassId;
            model.examClassIdRestricted = entity.ExamClassIdRestricted;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = entity.CreateDate;
            model.changeDate = entity.ChangeDate;
        }
        protected override void ModelToEntity(ExamClassRestrictedClassModel model, ExamClassRestrictedClass entity, ActionTypes actionType)
        {
            entity.ExamClassId = model.examClassId;
            entity.ExamClassIdRestricted = model.examClassIdRestricted;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
