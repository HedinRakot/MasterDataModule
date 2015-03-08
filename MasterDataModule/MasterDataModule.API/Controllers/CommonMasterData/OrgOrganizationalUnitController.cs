using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.CommonMasterData
{
    public class OrgOrganizationalUnitController : ClientApiController<OrgOrganizationalUnitModel, OrgOrganizationalUnit, int, IOrgOrganizationalUnitManager>
    {
        public OrgOrganizationalUnitController(IOrgOrganizationalUnitManager manager) : base(manager)
        {
        }

        protected override void EntityToModel(OrgOrganizationalUnit entity, OrgOrganizationalUnitModel model)
        {
            //model.Id = entity.Id;
            model.orgNumber = entity.OrgNumber;
            model.name = entity.Name;
            model.abbr = entity.Abbr;
            //model.AccountingArea = entity.AccountingArea;
            //model.LandTag = entity.LandTag;
            //model.OrgTopId = entity.OrgTopId;
            model.locationAbbr = entity.LocationAbbr;
            model.sysLocationId = entity.SysLocationId;
            //model.OrgAccountTypeId = entity.OrgAccountTypeId;
            model.orgTypeId = entity.OrgTypeId;
            //model.OrdInspectionLocationId = entity.OrdInspectionLocationId;
            model.emailFrom = entity.EmailFrom;
            model.emailTo = entity.EmailTo;
            model.isEgdokPrintAlways = entity.IsEgdokPrintAlways;
            model.deleteDate = entity.DeleteDate;
            model.source = entity.Source;
            model.orgAccountingAreaId = entity.OrgAccountingAreaId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }

        protected override void ModelToEntity(OrgOrganizationalUnitModel model, OrgOrganizationalUnit entity, ActionTypes actionType)
        {
            //entity.Id = entity.Id;
            entity.OrgNumber = model.orgNumber;
            entity.Name = model.name;
            entity.Abbr = model.abbr;
            //entity.AccountingArea = model.AccountingArea;
            //entity.LandTag = model.LandTag;
            //entity.OrgTopId = model.OrgTopId;
            entity.LocationAbbr = model.locationAbbr;
            entity.SysLocationId = model.sysLocationId;
            //entity.OrgAccountTypeId = model.OrgAccountTypeId;
            entity.OrgTypeId = model.orgTypeId;
            //entity.OrdInspectionLocationId = model.OrdInspectionLocationId;
            entity.EmailFrom = model.emailFrom;
            entity.EmailTo = model.emailTo;
            entity.IsEgdokPrintAlways = model.isEgdokPrintAlways;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.DeleteDate = model.deleteDate;
            entity.Source = model.source;
            entity.OrgAccountingAreaId = model.orgAccountingAreaId;
        }
    }
}
