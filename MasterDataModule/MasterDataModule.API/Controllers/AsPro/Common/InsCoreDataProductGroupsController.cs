using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsCoreDataProductGroup })]
    /// <summary>
    ///     Controller for <see cref="InsCoreDataProductGroup"/> entity
    /// </summary>
    public partial class InsCoreDataProductGroupsController: ClientApiController<InsCoreDataProductGroupModel, InsCoreDataProductGroup, int, IInsCoreDataProductGroupManager>
    {

        public InsCoreDataProductGroupsController(IInsCoreDataProductGroupManager manager): base(manager){}

        protected override void EntityToModel(InsCoreDataProductGroup entity, InsCoreDataProductGroupModel model)
        {
            model.name = entity.Name;
            model.defaultDuration = entity.DefaultDuration;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsCoreDataProductGroupModel model, InsCoreDataProductGroup entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.DefaultDuration = model.defaultDuration;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
