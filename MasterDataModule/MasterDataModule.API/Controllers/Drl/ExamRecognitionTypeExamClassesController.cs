using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ExamRecognitionTypeExamClass })]
    /// <summary>
    ///     Controller for <see cref="ExamRecognitionTypeExamClass"/> entity
    /// </summary>
    public partial class ExamRecognitionTypeExamClassesController: ClientApiController<ExamRecognitionTypeExamClassModel, ExamRecognitionTypeExamClass, int, IExamRecognitionTypeExamClassManager>
    {

        public ExamRecognitionTypeExamClassesController(IExamRecognitionTypeExamClassManager manager): base(manager){}

        protected override void EntityToModel(ExamRecognitionTypeExamClass entity, ExamRecognitionTypeExamClassModel model)
        {
            model.examRecognitionTypeId = entity.ExamRecognitionTypeId;
            model.examClassId = entity.ExamClassId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ExamRecognitionTypeExamClassModel model, ExamRecognitionTypeExamClass entity, ActionTypes actionType)
        {
            entity.ExamRecognitionTypeId = model.examRecognitionTypeId;
            entity.ExamClassId = model.examClassId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
