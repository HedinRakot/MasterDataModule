using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdContactPersonFunction"/> entity
    /// </summary>
    public partial class OrdContactPersonFunctionsController: ClientApiController<OrdContactPersonFunctionModel, OrdContactPersonFunction, int, IOrdContactPersonFunctionManager>
    {

        public OrdContactPersonFunctionsController(IOrdContactPersonFunctionManager manager): base(manager){}

        protected override void EntityToModel(OrdContactPersonFunction entity, OrdContactPersonFunctionModel model)
        {
            model.sapId = entity.SapId;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdContactPersonFunctionModel model, OrdContactPersonFunction entity, ActionTypes actionType)
        {
            entity.SapId = model.sapId;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
