using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsProductType })]
    /// <summary>
    ///     Controller for <see cref="InsProductType"/> entity
    /// </summary>
    public partial class InsProductTypesController: ClientApiController<InsProductTypeModel, InsProductType, int, IInsProductTypeManager>
    {

        public InsProductTypesController(IInsProductTypeManager manager): base(manager){}

        protected override void EntityToModel(InsProductType entity, InsProductTypeModel model)
        {
            model.name = entity.Name;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsProductTypeModel model, InsProductType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
