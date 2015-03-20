using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="CoreDataProductLocalization"/> entity
    /// </summary>
    public partial class CoreDataProductLocalizationsController: ClientApiController<CoreDataProductLocalizationModel, CoreDataProductLocalization, int, ICoreDataProductLocalizationManager>
    {

        public CoreDataProductLocalizationsController(ICoreDataProductLocalizationManager manager): base(manager){}

        protected override void EntityToModel(CoreDataProductLocalization entity, CoreDataProductLocalizationModel model)
        {
            model.coreDataProductId = entity.CoreDataProductId;
            model.sysLanguageId = entity.SysLanguageId;
            model.productName = entity.ProductName;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(CoreDataProductLocalizationModel model, CoreDataProductLocalization entity, ActionTypes actionType)
        {
            entity.CoreDataProductId = model.coreDataProductId;
            entity.SysLanguageId = model.sysLanguageId;
            entity.ProductName = model.productName;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
