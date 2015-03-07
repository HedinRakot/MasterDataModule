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
    public partial class InclusiveExamClassesController : 
        ClientApiController<InclusiveExamClassModel, ExamClassInclusiveClass, int, IInclusiveExamClassManager>
    {
        public InclusiveExamClassesController(IInclusiveExamClassManager manager)
            : base(manager)
        {
        }

        protected override void EntityToModel(ExamClassInclusiveClass entity, InclusiveExamClassModel model)
        {
            model.examClassId = entity.ExamClassId;
            model.inclusiveExamClassId = entity.ExamClassIdInclusive;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isConditional = entity.IsConditional;
            model.ChangeDate = entity.ChangeDate;
        }

        protected override void ModelToEntity(InclusiveExamClassModel model, ExamClassInclusiveClass entity, ActionTypes actionType)
        {
            entity.ExamClassId = model.examClassId;
            entity.ExamClassIdInclusive = model.inclusiveExamClassId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.IsConditional = model.isConditional;
        }
    }
}