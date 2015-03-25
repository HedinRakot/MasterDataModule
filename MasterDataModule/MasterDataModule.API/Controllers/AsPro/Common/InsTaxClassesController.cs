using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsTaxClass })]
    /// <summary>
    ///     Controller for <see cref="InsTaxClass"/> entity
    /// </summary>
    public partial class InsTaxClassesController: ClientApiController<InsTaxClassModel, InsTaxClass, int, IInsTaxClassManager>
    {

        public InsTaxClassesController(IInsTaxClassManager manager): base(manager){}

        protected override void EntityToModel(InsTaxClass entity, InsTaxClassModel model)
        {
            model.taxClass = entity.TaxClass;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsTaxClassModel model, InsTaxClass entity, ActionTypes actionType)
        {
            entity.TaxClass = model.taxClass;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
