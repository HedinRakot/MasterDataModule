using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsStatisticGroup })]
    /// <summary>
    ///     Controller for <see cref="InsStatisticGroup"/> entity
    /// </summary>
    public partial class InsStatisticGroupsController: ClientApiController<InsStatisticGroupModel, InsStatisticGroup, int, IInsStatisticGroupManager>
    {

        public InsStatisticGroupsController(IInsStatisticGroupManager manager): base(manager){}

        protected override void EntityToModel(InsStatisticGroup entity, InsStatisticGroupModel model)
        {
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsStatisticGroupModel model, InsStatisticGroup entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
