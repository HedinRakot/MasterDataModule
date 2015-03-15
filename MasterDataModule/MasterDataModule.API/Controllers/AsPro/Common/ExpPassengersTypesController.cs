using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExpPassengersType"/> entity
    /// </summary>
    public partial class ExpPassengersTypesController: ClientApiController<ExpPassengersTypeModel, ExpPassengersType, int, IExpPassengersTypeManager>
    {

        public ExpPassengersTypesController(IExpPassengersTypeManager manager): base(manager){}

        protected override void EntityToModel(ExpPassengersType entity, ExpPassengersTypeModel model)
        {
            model.text = entity.Text;
            model.code = entity.Code;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(ExpPassengersTypeModel model, ExpPassengersType entity, ActionTypes actionType)
        {
            entity.Text = model.text;
            entity.Code = model.code;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
