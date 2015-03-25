using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsProductClassGroup })]
    /// <summary>
    ///     Controller for <see cref="InsProductClassGroup"/> entity
    /// </summary>
    public partial class InsProductClassGroupsController: ClientApiController<InsProductClassGroupModel, InsProductClassGroup, int, IInsProductClassGroupManager>
    {

        public InsProductClassGroupsController(IInsProductClassGroupManager manager): base(manager){}

        protected override void EntityToModel(InsProductClassGroup entity, InsProductClassGroupModel model)
        {
            model.description = entity.Description;
            model.sapId = entity.SapId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsProductClassGroupModel model, InsProductClassGroup entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.SapId = model.sapId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
