using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsSeverityType"/> entity
    /// </summary>
    public partial class InsSeverityTypesController: ClientApiController<InsSeverityTypeModel, InsSeverityType, int, IInsSeverityTypeManager>
    {

        public InsSeverityTypesController(IInsSeverityTypeManager manager): base(manager){}

        protected override void EntityToModel(InsSeverityType entity, InsSeverityTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsSeverityTypeModel model, InsSeverityType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
