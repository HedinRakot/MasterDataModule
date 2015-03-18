using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ReturnReason"/> entity
    /// </summary>
    public partial class ReturnReasonsController: ClientApiController<ReturnReasonModel, ReturnReason, int, IReturnReasonManager>
    {

        public ReturnReasonsController(IReturnReasonManager manager): base(manager){}

        protected override void EntityToModel(ReturnReason entity, ReturnReasonModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.text1 = entity.Text1;
            model.text2 = entity.Text2;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ReturnReasonModel model, ReturnReason entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.Text1 = model.text1;
            entity.Text2 = model.text2;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
