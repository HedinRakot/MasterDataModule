using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="Authority"/> entity
    /// </summary>
    public partial class AuthoritiesController: ClientApiController<AuthorityModel, Authority, int, IAuthorityManager>
    {

        public AuthoritiesController(IAuthorityManager manager): base(manager){}

        protected override void EntityToModel(Authority entity, AuthorityModel model)
        {
            model.authorityNumber = entity.AuthorityNumber;
            model.name = entity.Name;
            model.description = entity.Description;
            model.isCertificateRequired = entity.IsCertificateRequired;
            model.returnType = entity.ReturnType;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.name2 = entity.Name2;
            model.streetHouseNumber = entity.StreetHouseNumber;
            model.zipCode = entity.ZipCode;
            model.city = entity.City;
            model.sysCountryId = entity.SysCountryId;
            model.phone1 = entity.Phone1;
            model.phone2 = entity.Phone2;
            model.fax = entity.Fax;
        }
        protected override void ModelToEntity(AuthorityModel model, Authority entity, ActionTypes actionType)
        {
            entity.AuthorityNumber = model.authorityNumber;
            entity.Name = model.name;
            entity.Description = model.description;
            entity.IsCertificateRequired = model.isCertificateRequired;
            entity.ReturnType = model.returnType;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.Name2 = model.name2;
            entity.StreetHouseNumber = model.streetHouseNumber;
            entity.ZipCode = model.zipCode;
            entity.City = model.city;
            entity.SysCountryId = model.sysCountryId;
            entity.Phone1 = model.phone1;
            entity.Phone2 = model.phone2;
            entity.Fax = model.fax;
        }
    }
}
