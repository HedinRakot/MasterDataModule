using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrgOrganizationalUnit })]
    /// <summary>
    ///     Controller for <see cref="OrgOrganizationalUnit"/> entity
    /// </summary>
    public partial class OrgOrganizationalUnitsController: ClientApiController<OrgOrganizationalUnitModel, OrgOrganizationalUnit, int, IOrgOrganizationalUnitManager>
    {

        public OrgOrganizationalUnitsController(IOrgOrganizationalUnitManager manager): base(manager){}

        protected override void EntityToModel(OrgOrganizationalUnit entity, OrgOrganizationalUnitModel model)
        {
            model.orgNumber = entity.OrgNumber;
            model.name = entity.Name;
            model.abbr = entity.Abbr;
            model.locationAbbr = entity.LocationAbbr;
            model.sysLocationId = entity.SysLocationId;
            model.orgTypeId = entity.OrgTypeId;
            model.emailFrom = entity.EmailFrom;
            model.emailTo = entity.EmailTo;
            model.isEgdokPrintAlways = entity.IsEgdokPrintAlways;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.orgAccountingAreaId = entity.OrgAccountingAreaId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrgOrganizationalUnitModel model, OrgOrganizationalUnit entity, ActionTypes actionType)
        {
            entity.OrgNumber = model.orgNumber;
            entity.Name = model.name;
            entity.Abbr = model.abbr;
            entity.LocationAbbr = model.locationAbbr;
            entity.SysLocationId = model.sysLocationId;
            entity.OrgTypeId = model.orgTypeId;
            entity.EmailFrom = model.emailFrom;
            entity.EmailTo = model.emailTo;
            entity.IsEgdokPrintAlways = model.isEgdokPrintAlways;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.OrgAccountingAreaId = model.orgAccountingAreaId;
        }
    }
}
