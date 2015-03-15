using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
        }
        protected override void ModelToEntity(InsProductTypeModel model, InsProductType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
