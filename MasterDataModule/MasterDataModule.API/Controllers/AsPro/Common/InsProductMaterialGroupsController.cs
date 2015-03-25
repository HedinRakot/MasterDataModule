using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsProductMaterialGroup })]
    /// <summary>
    ///     Controller for <see cref="InsProductMaterialGroup"/> entity
    /// </summary>
    public partial class InsProductMaterialGroupsController: ClientApiController<InsProductMaterialGroupModel, InsProductMaterialGroup, int, IInsProductMaterialGroupManager>
    {

        public InsProductMaterialGroupsController(IInsProductMaterialGroupManager manager): base(manager){}

        protected override void EntityToModel(InsProductMaterialGroup entity, InsProductMaterialGroupModel model)
        {
            model.description = entity.Description;
            model.sapId = entity.SapId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsProductMaterialGroupModel model, InsProductMaterialGroup entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.SapId = model.sapId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
