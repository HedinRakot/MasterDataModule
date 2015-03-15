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
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(KssExpenseGroundModel model, KssExpenseGround entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.Account = model.account;
            entity.InsVatTypeId = model.insVatTypeId;
            entity.MaxAmount = model.maxAmount;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
