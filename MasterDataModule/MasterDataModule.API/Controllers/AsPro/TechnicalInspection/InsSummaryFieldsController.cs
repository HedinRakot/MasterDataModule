using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
        }
        protected override void ModelToEntity(InsSummaryFieldModel model, InsSummaryField entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
