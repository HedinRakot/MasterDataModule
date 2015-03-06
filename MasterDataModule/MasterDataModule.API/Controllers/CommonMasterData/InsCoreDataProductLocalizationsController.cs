using TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.CommonMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class InsCoreDataProductLocalizationsController : 
        ClientApiController<InsCoreDataProductLocalizationModel, InsCoreDataProductLocalization, int, IInsCoreDataProductLocalizationManager>
    {
        public InsCoreDataProductLocalizationsController(IInsCoreDataProductLocalizationManager insCoreDataProductLocalizationManager)
            : base(insCoreDataProductLocalizationManager)
        {
        }

        protected override void EntityToModel(InsCoreDataProductLocalization entity, InsCoreDataProductLocalizationModel model)
        {
            model.name = entity.EntityTitle;
            model.description = entity.Description;
            model.sysLanguageId = entity.SysLanguageId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }

        protected override void ModelToEntity(InsCoreDataProductLocalizationModel model, InsCoreDataProductLocalization entity, ActionTypes actionType)
        {
            entity.ProductName = model.name;
            entity.Description = string.IsNullOrWhiteSpace(model.description) ? string.Empty : model.description;            
            entity.SysLanguageId = model.sysLanguageId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}