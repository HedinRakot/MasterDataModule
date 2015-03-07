using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Linq.Dynamic;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class RequiredExamClassesController : 
        ClientApiController<RequiredExamClassModel, ExamClassRequiredClass, int, IRequiredExamClassManager>
    {
        public RequiredExamClassesController(IRequiredExamClassManager requiredExamClassManager): base(requiredExamClassManager)
        {
        }
        
        protected override void EntityToModel(ExamClassRequiredClass entity, RequiredExamClassModel model)
        {
            model.Id = entity.Id;
            model.examClassId = entity.ExamClassId;
            model.requiredExamClassId = entity.ExamClassIdRequired;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.ChangeDate = entity.ChangeDate;
        }

        protected override void ModelToEntity(RequiredExamClassModel model, ExamClassRequiredClass entity, ActionTypes actionType)
        {
            entity.ExamClassId = model.examClassId;
            entity.ExamClassIdRequired = model.requiredExamClassId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}