using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsNextSpInterval })]
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
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsNextSpIntervalModel model, InsNextSpInterval entity, ActionTypes actionType)
        {
            entity.InsProductObjectTypeId = model.insProductObjectTypeId;
            entity.InsProductObjectClassId = model.insProductObjectClassId;
            entity.AgeMonthFrom = model.ageMonthFrom;
            entity.AgeMonthTo = model.ageMonthTo;
            entity.SpInterval = model.spInterval;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
