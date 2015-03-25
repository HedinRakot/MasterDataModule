using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsProductCombinationType })]
    /// <summary>
    ///     Controller for <see cref="InsProductCombinationType"/> entity
    /// </summary>
    public partial class InsProductCombinationTypesController: ClientApiController<InsProductCombinationTypeModel, InsProductCombinationType, int, IInsProductCombinationTypeManager>
    {

        public InsProductCombinationTypesController(IInsProductCombinationTypeManager manager): base(manager){}

        protected override void EntityToModel(InsProductCombinationType entity, InsProductCombinationTypeModel model)
        {
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsProductCombinationTypeModel model, InsProductCombinationType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
