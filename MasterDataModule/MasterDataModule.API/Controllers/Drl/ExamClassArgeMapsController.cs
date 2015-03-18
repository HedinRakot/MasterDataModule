using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamClassArgeMap"/> entity
    /// </summary>
    public partial class ExamClassArgeMapsController: ClientApiController<ExamClassArgeMapModel, ExamClassArgeMap, int, IExamClassArgeMapManager>
    {

        public ExamClassArgeMapsController(IExamClassArgeMapManager manager): base(manager){}

        protected override void EntityToModel(ExamClassArgeMap entity, ExamClassArgeMapModel model)
        {
            model.examNameArge = entity.ExamNameArge;
            model.examClassId = entity.ExamClassId;
            model.createDate = entity.CreateDate;
            model.changeDate = entity.ChangeDate;
        }
        protected override void ModelToEntity(ExamClassArgeMapModel model, ExamClassArgeMap entity, ActionTypes actionType)
        {
            entity.ExamNameArge = model.examNameArge;
            entity.ExamClassId = model.examClassId;
        }
    }
}
