using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsProductObjectType"/> entity
    /// </summary>
    public partial class InsProductObjectTypesController: ClientApiController<InsProductObjectTypeModel, InsProductObjectType, int, IInsProductObjectTypeManager>
    {

        public InsProductObjectTypesController(IInsProductObjectTypeManager manager): base(manager){}

        protected override void EntityToModel(InsProductObjectType entity, InsProductObjectTypeModel model)
        {
            model.description = entity.Description;
            model.sapId = entity.SapId;
            model.isAuNecessary = entity.IsAuNecessary;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsProductObjectTypeModel model, InsProductObjectType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.SapId = model.sapId;
            entity.IsAuNecessary = model.isAuNecessary;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
