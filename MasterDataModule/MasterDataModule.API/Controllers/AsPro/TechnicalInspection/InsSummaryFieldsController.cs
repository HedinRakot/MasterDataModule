using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsSummaryField })]
    /// <summary>
    ///     Controller for <see cref="InsSummaryField"/> entity
    /// </summary>
    public partial class InsSummaryFieldsController: ClientApiController<InsSummaryFieldModel, InsSummaryField, int, IInsSummaryFieldManager>
    {

        public InsSummaryFieldsController(IInsSummaryFieldManager manager): base(manager){}

        protected override void EntityToModel(InsSummaryField entity, InsSummaryFieldModel model)
        {
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsSummaryFieldModel model, InsSummaryField entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
