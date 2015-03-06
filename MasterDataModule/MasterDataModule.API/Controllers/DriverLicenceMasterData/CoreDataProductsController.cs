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
    public partial class CoreDataProductsController : ClientApiController<CoreDataProductModel, CoreDataProduct, int, ICoreDataProductManager>
    {
        private readonly ISysLanguageManager sysLanguageManager;
        private readonly IInsCoreDataProductManager insCoreDataProductManager;
        public CoreDataProductsController(ICoreDataProductManager coreDataProductManager, 
            ISysLanguageManager sysLanguageManager,
            IInsCoreDataProductManager insCoreDataProductManager)
            : base(coreDataProductManager)
        {
            this.sysLanguageManager = sysLanguageManager;
            this.insCoreDataProductManager = insCoreDataProductManager;
        }

        protected override void EntityToModel(CoreDataProduct entity, CoreDataProductModel model)
        {
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.name = entity.EntityTitle;
            model.minAge = entity.MinAge;
            model.maxAge = entity.MaxAge;
            model.examType = entity.ExamType;
            model.insCoreDataProductId = entity.InsCoreDataProductId;
            model.priorTimeInMonths = entity.PriorTimeInMonths;
            model.repeatTimeInDays = entity.RepeatTimeInDays;
            model.repeatTimeInDaysReduced = entity.RepeatTimeInDaysReduced;
            model.trainingCertFlag = entity.TrainingCertFlag;
            model.resultFlag = entity.ResultFlag;
            model.multiplyFlag = entity.MultiplyFlag;
            model.isMofaPrint = entity.IsMofaPrint;
            model.isAdditionalProduct = entity.IsAdditionalProduct;
            model.isPrepaymentRequired = entity.IsPrepaymentRequired;
            model.isMandatory = entity.IsMandatory;

            var insCoreDataProduct = insCoreDataProductManager.GetByID(entity.InsCoreDataProductId);
            if (insCoreDataProduct != null)
            {
                model.insCoreDataProductName = insCoreDataProduct.EntityTitle;
            }


            //TODO
            if (entity.CoreDataProductLocalizations != null && entity.CoreDataProductLocalizations.Count != 0)
            {
                model.description = entity.CoreDataProductLocalizations.FirstOrDefault().Description;
            }
        }

        protected override void ModelToEntity(CoreDataProductModel model, CoreDataProduct entity, ActionTypes actionType)
        {
            if (actionType == ActionTypes.Add)
            {
                var defaultLanguage = sysLanguageManager.GetEntities(o =>
                    o.Description.Equals("Deutsch", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

                var defaultGermanlocalization = new CoreDataProductLocalization()
                {
                    ProductName = model.name,
                    SysLanguageId = defaultLanguage != null ? defaultLanguage.Id : 0,
                    FromDate = model.fromDate,
                    ToDate = model.toDate,
                    Description = model.description,
                    CoreDataProduct = entity
                };

                entity.CoreDataProductLocalizations = new List<CoreDataProductLocalization>();
                entity.CoreDataProductLocalizations.Add(defaultGermanlocalization);
            }
            
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.MinAge = (byte)model.minAge;
            entity.MaxAge = (byte?)model.maxAge;
            entity.ExamType = model.examType;
            entity.InsCoreDataProductId = model.insCoreDataProductId;
            entity.PriorTimeInMonths = model.priorTimeInMonths;
            entity.RepeatTimeInDays = model.repeatTimeInDays;
            entity.RepeatTimeInDaysReduced = model.repeatTimeInDaysReduced;
            entity.TrainingCertFlag = model.trainingCertFlag;
            entity.ResultFlag = model.resultFlag;
            entity.MultiplyFlag = model.multiplyFlag;
            entity.IsMofaPrint = model.isMofaPrint;
            entity.IsAdditionalProduct = model.isAdditionalProduct;
            entity.IsPrepaymentRequired = model.isPrepaymentRequired;
            entity.IsMandatory = model.isMandatory;
        }
    }
}