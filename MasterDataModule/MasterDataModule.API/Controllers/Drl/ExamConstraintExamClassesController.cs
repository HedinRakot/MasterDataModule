using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ExamConstraintExamClass })]
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
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
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
