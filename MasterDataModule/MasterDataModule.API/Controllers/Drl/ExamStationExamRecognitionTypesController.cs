using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ExamStationExamRecognitionType })]
    /// <summary>
    ///     Controller for <see cref="ExamStationExamRecognitionType"/> entity
    /// </summary>
    public partial class ExamStationExamRecognitionTypesController: ClientApiController<ExamStationExamRecognitionTypeModel, ExamStationExamRecognitionType, int, IExamStationExamRecognitionTypeManager>
    {

        public ExamStationExamRecognitionTypesController(IExamStationExamRecognitionTypeManager manager): base(manager){}

        protected override void EntityToModel(ExamStationExamRecognitionType entity, ExamStationExamRecognitionTypeModel model)
        {
            model.examStationId = entity.ExamStationId;
            model.examRecognitionTypeId = entity.ExamRecognitionTypeId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ExamStationExamRecognitionTypeModel model, ExamStationExamRecognitionType entity, ActionTypes actionType)
        {
            entity.ExamStationId = model.examStationId;
            entity.ExamRecognitionTypeId = model.examRecognitionTypeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
