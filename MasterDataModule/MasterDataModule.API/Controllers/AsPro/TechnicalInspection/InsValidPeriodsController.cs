using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsValidPeriod"/> entity
    /// </summary>
    public partial class InsValidPeriodsController: ClientApiController<InsValidPeriodModel, InsValidPeriod, int, IInsValidPeriodManager>
    {

        public InsValidPeriodsController(IInsValidPeriodManager manager): base(manager){}

        protected override void EntityToModel(InsValidPeriod entity, InsValidPeriodModel model)
        {
            model.description = entity.Description;
            model.validityPeriod = entity.ValidityPeriod;
            model.isNextTerminPossible = entity.IsNextTerminPossible;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsValidPeriodModel model, InsValidPeriod entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.ValidityPeriod = model.validityPeriod;
            entity.IsNextTerminPossible = model.isNextTerminPossible;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
