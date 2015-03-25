using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrgCostCenterPrice })]
    /// <summary>
    ///     Controller for <see cref="OrgCostCenterPrice"/> entity
    /// </summary>
    public partial class OrgCostCenterPricesController: ClientApiController<OrgCostCenterPriceModel, OrgCostCenterPrice, int, IOrgCostCenterPriceManager>
    {

        public OrgCostCenterPricesController(IOrgCostCenterPriceManager manager): base(manager){}

        protected override void EntityToModel(OrgCostCenterPrice entity, OrgCostCenterPriceModel model)
        {
            model.insCoreDataProductId = entity.InsCoreDataProductId;
            model.salesOffice = entity.SalesOffice;
            model.minPrice = entity.MinPrice;
            model.maxPrice = entity.MaxPrice;
            model.standartPrice = entity.StandartPrice;
            model.quantity = entity.Quantity;
            model.unitOfMeasure = entity.UnitOfMeasure;
            model.sysCurrencyId = entity.SysCurrencyId;
            model.changeAbilityType = entity.ChangeAbilityType;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrgCostCenterPriceModel model, OrgCostCenterPrice entity, ActionTypes actionType)
        {
            entity.InsCoreDataProductId = model.insCoreDataProductId;
            entity.SalesOffice = model.salesOffice;
            entity.MinPrice = model.minPrice;
            entity.MaxPrice = model.maxPrice;
            entity.StandartPrice = model.standartPrice;
            entity.Quantity = model.quantity;
            entity.UnitOfMeasure = model.unitOfMeasure;
            entity.SysCurrencyId = model.sysCurrencyId;
            entity.ChangeAbilityType = model.changeAbilityType;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
