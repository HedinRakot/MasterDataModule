using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="CoreDataProduct"/> entity
    /// </summary>
    public partial class CoreDataProductsController: ClientApiController<CoreDataProductModel, CoreDataProduct, int, ICoreDataProductManager>
    {

        public CoreDataProductsController(ICoreDataProductManager manager): base(manager){}

        protected override void EntityToModel(CoreDataProduct entity, CoreDataProductModel model)
        {
            model.insCoreDataProductId = entity.InsCoreDataProductId;
            model.minAge = entity.MinAge;
            model.maxAge = entity.MaxAge;
            model.examType = entity.ExamType;
            model.priorTimeInMonths = entity.PriorTimeInMonths;
            model.expirationInMonth = entity.ExpirationInMonth;
            model.repeatTimeInDays = entity.RepeatTimeInDays;
            model.trainingCertFlag = entity.TrainingCertFlag;
            model.resultFlag = entity.ResultFlag;
            model.multiplyFlag = entity.MultiplyFlag;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isMofaPrint = entity.IsMofaPrint;
            model.isAdditionalProduct = entity.IsAdditionalProduct;
            model.isPrepaymentRequired = entity.IsPrepaymentRequired;
            model.isMandatory = entity.IsMandatory;
            model.feProductNumber = entity.FeProductNumber;
            model.repeatTimeInDaysReduced = entity.RepeatTimeInDaysReduced;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(CoreDataProductModel model, CoreDataProduct entity, ActionTypes actionType)
        {
            entity.InsCoreDataProductId = model.insCoreDataProductId;
            entity.MinAge = model.minAge;
            entity.MaxAge = model.maxAge;
            entity.ExamType = model.examType;
            entity.PriorTimeInMonths = model.priorTimeInMonths;
            entity.ExpirationInMonth = model.expirationInMonth;
            entity.RepeatTimeInDays = model.repeatTimeInDays;
            entity.TrainingCertFlag = model.trainingCertFlag;
            entity.ResultFlag = model.resultFlag;
            entity.MultiplyFlag = model.multiplyFlag;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.IsMofaPrint = model.isMofaPrint;
            entity.IsAdditionalProduct = model.isAdditionalProduct;
            entity.IsPrepaymentRequired = model.isPrepaymentRequired;
            entity.IsMandatory = model.isMandatory;
            entity.FeProductNumber = model.feProductNumber;
            entity.RepeatTimeInDaysReduced = model.repeatTimeInDaysReduced;
        }
    }
}
