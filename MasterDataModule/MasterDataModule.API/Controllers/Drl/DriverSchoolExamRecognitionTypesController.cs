using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="DriverSchoolExamRecognitionType"/> entity
    /// </summary>
    public partial class DriverSchoolExamRecognitionTypesController: ClientApiController<DriverSchoolExamRecognitionTypeModel, DriverSchoolExamRecognitionType, int, IDriverSchoolExamRecognitionTypeManager>
    {

        public DriverSchoolExamRecognitionTypesController(IDriverSchoolExamRecognitionTypeManager manager): base(manager){}

        protected override void EntityToModel(DriverSchoolExamRecognitionType entity, DriverSchoolExamRecognitionTypeModel model)
        {
            model.driverSchoolId = entity.DriverSchoolId;
            model.examRecognitionTypeId = entity.ExamRecognitionTypeId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(DriverSchoolExamRecognitionTypeModel model, DriverSchoolExamRecognitionType entity, ActionTypes actionType)
        {
            entity.DriverSchoolId = model.driverSchoolId;
            entity.ExamRecognitionTypeId = model.examRecognitionTypeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}