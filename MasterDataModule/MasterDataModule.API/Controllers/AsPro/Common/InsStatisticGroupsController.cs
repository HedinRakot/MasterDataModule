using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsStatisticGroup"/> entity
    /// </summary>
    public partial class InsStatisticGroupsController: ClientApiController<InsStatisticGroupModel, InsStatisticGroup, int, IInsStatisticGroupManager>
    {

        public InsStatisticGroupsController(IInsStatisticGroupManager manager): base(manager){}

        protected override void EntityToModel(InsStatisticGroup entity, InsStatisticGroupModel model)
        {
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsStatisticGroupModel model, InsStatisticGroup entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
