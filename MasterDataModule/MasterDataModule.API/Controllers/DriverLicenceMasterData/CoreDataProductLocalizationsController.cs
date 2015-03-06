using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class CoreDataProductLocalizationsController : 
        ClientApiController<CoreDataProductLocalizationModel, CoreDataProductLocalization, int, ICoreDataProductLocalizationManager>
    {
        public CoreDataProductLocalizationsController(ICoreDataProductLocalizationManager coreDataProductLocalizationManager)
            : base(coreDataProductLocalizationManager)
        {
        }

        protected override void EntityToModel(CoreDataProductLocalization entity, CoreDataProductLocalizationModel model)
        {
            model.name = entity.EntityTitle;
            model.description = entity.Description;
            model.coreDataProductId = entity.CoreDataProductId;
            model.sysLanguageId = entity.SysLanguageId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }

        protected override void ModelToEntity(CoreDataProductLocalizationModel model, CoreDataProductLocalization entity, ActionTypes actionType)
        {
            entity.ProductName = model.name;
            entity.Description = string.IsNullOrWhiteSpace(model.description) ? string.Empty : model.description;            
            entity.CoreDataProductId = model.coreDataProductId;
            entity.SysLanguageId = model.sysLanguageId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}