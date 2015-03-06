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
    public partial class CoreDataProductClassBasisesController :
        ClientApiController<CoreDataProductClassBasisModel, CoreDataProductClassBasis, int, ICoreDataProductClassBasisManager>
    {
        public CoreDataProductClassBasisesController(ICoreDataProductClassBasisManager manager)
            : base(manager)
        {
        }

        protected override void EntityToModel(CoreDataProductClassBasis entity, CoreDataProductClassBasisModel model)
        {
            model.coreDataProductId = entity.CoreDataProductId;
            model.examClassId = entity.ExamClassId;
            model.legalBasisId = entity.LegalBasisId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.sortOrder = entity.SortOrder;
        }

        protected override void ModelToEntity(CoreDataProductClassBasisModel model, CoreDataProductClassBasis entity, ActionTypes actionType)
        {
            entity.CoreDataProductId = model.coreDataProductId;
            entity.ExamClassId = model.examClassId;
            entity.LegalBasisId = model.legalBasisId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.SortOrder = model.sortOrder;
        }
    }
}