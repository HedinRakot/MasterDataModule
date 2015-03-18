using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdBillingParameter"/> entity
    /// </summary>
    public partial class OrdBillingParametersController: ClientApiController<OrdBillingParameterModel, OrdBillingParameter, int, IOrdBillingParameterManager>
    {

        public OrdBillingParametersController(IOrdBillingParameterManager manager): base(manager){}

        protected override void EntityToModel(OrdBillingParameter entity, OrdBillingParameterModel model)
        {
            model.sapId = entity.SapId;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdBillingParameterModel model, OrdBillingParameter entity, ActionTypes actionType)
        {
            entity.SapId = model.sapId;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
