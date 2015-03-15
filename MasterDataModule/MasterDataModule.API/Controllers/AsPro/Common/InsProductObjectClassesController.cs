using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsProductObjectClass"/> entity
    /// </summary>
    public partial class InsProductObjectClassesController: ClientApiController<InsProductObjectClassModel, InsProductObjectClass, int, IInsProductObjectClassManager>
    {

        public InsProductObjectClassesController(IInsProductObjectClassManager manager): base(manager){}

        protected override void EntityToModel(InsProductObjectClass entity, InsProductObjectClassModel model)
        {
            model.description = entity.Description;
            model.weightFrom = entity.WeightFrom;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsProductObjectClassModel model, InsProductObjectClass entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.WeightFrom = model.weightFrom;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
