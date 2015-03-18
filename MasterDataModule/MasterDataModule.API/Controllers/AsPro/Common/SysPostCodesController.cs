using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="SysPostCode"/> entity
    /// </summary>
    public partial class SysPostCodesController: ClientApiController<SysPostCodeModel, SysPostCode, int, ISysPostCodeManager>
    {

        public SysPostCodesController(ISysPostCodeManager manager): base(manager){}

        protected override void EntityToModel(SysPostCode entity, SysPostCodeModel model)
        {
            model.postCode = entity.PostCode;
            model.city = entity.City;
            model.street = entity.Street;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SysPostCodeModel model, SysPostCode entity, ActionTypes actionType)
        {
            entity.PostCode = model.postCode;
            entity.City = model.city;
            entity.Street = model.street;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
