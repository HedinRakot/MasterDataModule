using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamPossibleResult"/> entity
    /// </summary>
    public partial class ExamPossibleResultsController: ClientApiController<ExamPossibleResultModel, ExamPossibleResult, int, IExamPossibleResultManager>
    {

        public ExamPossibleResultsController(IExamPossibleResultManager manager): base(manager){}

        protected override void EntityToModel(ExamPossibleResult entity, ExamPossibleResultModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.isFeePayable = entity.IsFeePayable;
            model.examCounterFlag = entity.ExamCounterFlag;
            model.nextExamProductFlag = entity.NextExamProductFlag;
            model.driverLicenceFlag = entity.DriverLicenceFlag;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isMedicalAttestRequired = entity.IsMedicalAttestRequired;
        }
        protected override void ModelToEntity(ExamPossibleResultModel model, ExamPossibleResult entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.IsFeePayable = model.isFeePayable;
            entity.ExamCounterFlag = model.examCounterFlag;
            entity.NextExamProductFlag = model.nextExamProductFlag;
            entity.DriverLicenceFlag = model.driverLicenceFlag;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.IsMedicalAttestRequired = model.isMedicalAttestRequired;
        }
    }
}
