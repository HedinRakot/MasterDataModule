using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdCustomerInfo"/> entity
    /// </summary>
    public partial class OrdCustomerInfosController: ClientApiController<OrdCustomerInfoModel, OrdCustomerInfo, int, IOrdCustomerInfoManager>
    {

        public OrdCustomerInfosController(IOrdCustomerInfoManager manager): base(manager){}

        protected override void EntityToModel(OrdCustomerInfo entity, OrdCustomerInfoModel model)
        {
            model.textValue = entity.TextValue;
            model.numberValue = entity.NumberValue;
            model.infoType = entity.InfoType;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdCustomerInfoModel model, OrdCustomerInfo entity, ActionTypes actionType)
        {
            entity.TextValue = model.textValue;
            entity.NumberValue = model.numberValue;
            entity.InfoType = model.infoType;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
