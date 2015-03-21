using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsCoreDataProduct"/> entity
    /// </summary>
    public partial class InsCoreDataProductsController: ClientApiController<InsCoreDataProductModel, InsCoreDataProduct, int, IInsCoreDataProductManager>
    {

        public InsCoreDataProductsController(IInsCoreDataProductManager manager): base(manager){}

        protected override void EntityToModel(InsCoreDataProduct entity, InsCoreDataProductModel model)
        {
            model.productNumber = entity.ProductNumber;
            model.isNextInspectionProduct = entity.IsNextInspectionProduct;
            model.isProvisionCostMayBeCalculated = entity.IsProvisionCostMayBeCalculated;
            model.priceReportRequired = entity.PriceReportRequired;
            model.insProductTypeId = entity.InsProductTypeId;
            model.insProductObjectClassId = entity.InsProductObjectClassId;
            model.insProductObjectTypeId = entity.InsProductObjectTypeId;
            model.insProductMaterialGroupId = entity.InsProductMaterialGroupId;
            model.insProductClassId = entity.InsProductClassId;
            model.insCoreDataProductGroupId = entity.InsCoreDataProductGroupId;
            model.isIngener = entity.IsIngener;
            model.isProductive = entity.IsProductive;
            model.isKmGeld = entity.IsKmGeld;
            model.isOtherMaterial = entity.IsOtherMaterial;
            model.isTrip = entity.IsTrip;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.reusageType = entity.ReusageType;
            model.insTaxCodeId = entity.InsTaxCodeId;
            model.oldProductNumber = entity.OldProductNumber;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;

            ExtraEntityToModel(entity, model);
        }
        protected override void ModelToEntity(InsCoreDataProductModel model, InsCoreDataProduct entity, ActionTypes actionType)
        {
            entity.ProductNumber = model.productNumber;
            entity.IsNextInspectionProduct = model.isNextInspectionProduct;
            entity.IsProvisionCostMayBeCalculated = model.isProvisionCostMayBeCalculated;
            entity.PriceReportRequired = model.priceReportRequired;
            entity.InsProductTypeId = model.insProductTypeId;
            entity.InsProductObjectClassId = model.insProductObjectClassId;
            entity.InsProductObjectTypeId = model.insProductObjectTypeId;
            entity.InsProductMaterialGroupId = model.insProductMaterialGroupId;
            entity.InsProductClassId = model.insProductClassId;
            entity.InsCoreDataProductGroupId = model.insCoreDataProductGroupId;
            entity.IsIngener = model.isIngener;
            entity.IsProductive = model.isProductive;
            entity.IsKmGeld = model.isKmGeld;
            entity.IsOtherMaterial = model.isOtherMaterial;
            entity.IsTrip = model.isTrip;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.ReusageType = model.reusageType;
            entity.InsTaxCodeId = model.insTaxCodeId;
            entity.OldProductNumber = model.oldProductNumber;
        }
    }
}
