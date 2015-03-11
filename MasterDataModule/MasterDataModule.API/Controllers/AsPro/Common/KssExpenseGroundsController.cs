using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="KssExpenseGround"/> entity
    /// </summary>
    public partial class KssExpenseGroundsController: ClientApiController<KssExpenseGroundModel, KssExpenseGround, int, IKssExpenseGroundManager>
    {

        public KssExpenseGroundsController(IKssExpenseGroundManager manager): base(manager){}

        protected override void EntityToModel(KssExpenseGround entity, KssExpenseGroundModel model)
        {
            model.description = entity.Description;
            model.account = entity.Account;
            model.insVatTypeId = entity.InsVatTypeId;
            model.maxAmount = entity.MaxAmount;
        }
        protected override void ModelToEntity(KssExpenseGroundModel model, KssExpenseGround entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.Account = model.account;
            entity.InsVatTypeId = model.insVatTypeId;
            entity.MaxAmount = model.maxAmount;
        }
    }
}
