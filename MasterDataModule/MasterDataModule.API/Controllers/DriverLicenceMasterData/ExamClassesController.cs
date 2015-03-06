using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class ExamClassesController : ClientApiController<ExamClassModel, ExamClass, int, IExamClassManager>
    {
        public ExamClassesController(IExamClassManager examClassManager): base(examClassManager)
        {
        }

        protected override void EntityToModel(ExamClass entity, ExamClassModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isFsClass = entity.IsFsClass;
            model.isMofa = entity.IsMofa;
            model.sortOrder = entity.SortOrder;
        }

        protected override void ModelToEntity(ExamClassModel model, ExamClass entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = string.IsNullOrWhiteSpace(model.description) ? string.Empty : model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.IsFsClass = model.isFsClass;
            entity.IsMofa = model.isMofa;
            entity.SortOrder = model.sortOrder;
        }
    }
}