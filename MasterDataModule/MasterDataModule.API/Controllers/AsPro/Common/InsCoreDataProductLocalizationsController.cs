using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsCoreDataProductLocalization })]
    /// <summary>
    ///     Controller for <see cref="InsCoreDataProductLocalization"/> entity
    /// </summary>
    public partial class InsCoreDataProductLocalizationsController: ClientApiController<InsCoreDataProductLocalizationModel, InsCoreDataProductLocalization, int, IInsCoreDataProductLocalizationManager>
    {

        public InsCoreDataProductLocalizationsController(IInsCoreDataProductLocalizationManager manager): base(manager){}

        protected override void EntityToModel(InsCoreDataProductLocalization entity, InsCoreDataProductLocalizationModel model)
        {
            model.insCoreDataProductId = entity.InsCoreDataProductId;
            model.sysLanguageId = entity.SysLanguageId;
            model.productName = entity.ProductName;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsCoreDataProductLocalizationModel model, InsCoreDataProductLocalization entity, ActionTypes actionType)
        {
            entity.InsCoreDataProductId = model.insCoreDataProductId;
            entity.SysLanguageId = model.sysLanguageId;
            entity.ProductName = model.productName;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
