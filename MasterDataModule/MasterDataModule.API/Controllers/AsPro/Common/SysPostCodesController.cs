using MasterDataModule.API.Models;
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
        }
        protected override void ModelToEntity(SysPostCodeModel model, SysPostCode entity, ActionTypes actionType)
        {
            entity.PostCode = model.postCode;
            entity.City = model.city;
            entity.Street = model.street;
        }
    }
}
