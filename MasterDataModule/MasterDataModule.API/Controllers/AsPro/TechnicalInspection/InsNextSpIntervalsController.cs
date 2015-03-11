using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsNextSpInterval"/> entity
    /// </summary>
    public partial class InsNextSpIntervalsController: ClientApiController<InsNextSpIntervalModel, InsNextSpInterval, int, IInsNextSpIntervalManager>
    {

        public InsNextSpIntervalsController(IInsNextSpIntervalManager manager): base(manager){}

        protected override void EntityToModel(InsNextSpInterval entity, InsNextSpIntervalModel model)
        {
            model.insProductObjectTypeId = entity.InsProductObjectTypeId;
            model.insProductObjectClassId = entity.InsProductObjectClassId;
            model.ageMonthFrom = entity.AgeMonthFrom;
            model.ageMonthTo = entity.AgeMonthTo;
            model.spInterval = entity.SpInterval;
        }
        protected override void ModelToEntity(InsNextSpIntervalModel model, InsNextSpInterval entity, ActionTypes actionType)
        {
            entity.InsProductObjectTypeId = model.insProductObjectTypeId;
            entity.InsProductObjectClassId = model.insProductObjectClassId;
            entity.AgeMonthFrom = model.ageMonthFrom;
            entity.AgeMonthTo = model.ageMonthTo;
            entity.SpInterval = model.spInterval;
        }
    }
}
