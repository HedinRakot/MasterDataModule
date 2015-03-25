using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.SysCountry })]
    /// <summary>
    ///     Controller for <see cref="SysCountry"/> entity
    /// </summary>
    public partial class SysCountriesController: ClientApiController<SysCountryModel, SysCountry, int, ISysCountryManager>
    {

        public SysCountriesController(ISysCountryManager manager): base(manager){}

        protected override void EntityToModel(SysCountry entity, SysCountryModel model)
        {
            model.sapId = entity.SapId;
            model.name = entity.Name;
            model.isEu = entity.IsEu;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SysCountryModel model, SysCountry entity, ActionTypes actionType)
        {
            entity.SapId = model.sapId;
            entity.Name = model.name;
            entity.IsEu = model.isEu;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
