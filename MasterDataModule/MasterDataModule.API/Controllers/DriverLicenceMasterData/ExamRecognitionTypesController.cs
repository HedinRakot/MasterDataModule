using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public class ExamRecognitionTypesController : ClientApiController<ExamRecognitionTypeModel, ExamRecognitionType, int, IExamRecognitionTypeManager>
    {
        public ExamRecognitionTypesController(IExamRecognitionTypeManager examRecognitionTypeManager)
            : base(examRecognitionTypeManager)
        {
        }

        protected override void ModelToEntity(ExamRecognitionTypeModel model, ExamRecognitionType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = string.IsNullOrWhiteSpace(model.description) ? string.Empty : model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
           
        }

        protected override void EntityToModel(ExamRecognitionType entity, ExamRecognitionTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.ChangeDate = entity.ChangeDate;
        }
    }
}