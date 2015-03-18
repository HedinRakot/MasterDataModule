using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamClassMap"/> entity
    /// </summary>
    public partial class ExamClassMapsController: ClientApiController<ExamClassMapModel, ExamClassMap, int, IExamClassMapManager>
    {

        public ExamClassMapsController(IExamClassMapManager manager): base(manager){}

        protected override void EntityToModel(ExamClassMap entity, ExamClassMapModel model)
        {
            model.examClassIdOld = entity.ExamClassIdOld;
            model.examClassIdActual = entity.ExamClassIdActual;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ExamClassMapModel model, ExamClassMap entity, ActionTypes actionType)
        {
            entity.ExamClassIdOld = model.examClassIdOld;
            entity.ExamClassIdActual = model.examClassIdActual;
        }
    }
}
