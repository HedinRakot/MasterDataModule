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
            model.OrgNumber = entity.OrgNumber;
            model.Name = entity.Name;
            model.Abbr = entity.Abbr;
            //model.AccountingArea = entity.AccountingArea;
            //model.LandTag = entity.LandTag;
            //model.OrgTopId = entity.OrgTopId;
            model.LocationAbbr = entity.LocationAbbr;
            model.SysLocationId = entity.SysLocationId;
            //model.OrgAccountTypeId = entity.OrgAccountTypeId;
            model.OrgTypeId = entity.OrgTypeId;
            //model.OrdInspectionLocationId = entity.OrdInspectionLocationId;
            model.EmailFrom = entity.EmailFrom;
            model.EmailTo = entity.EmailTo;
            model.IsEgdokPrintAlways = entity.IsEgdokPrintAlways;
            model.DeleteDate = entity.DeleteDate;
            model.Source = entity.Source;
            model.OrgAccountingAreaId = entity.OrgAccountingAreaId;
            model.FromDate = entity.FromDate;
            model.ToDate = entity.ToDate;
        }

        protected override void ModelToEntity(OrgOrganizationalUnitModel model, OrgOrganizationalUnit entity, ActionTypes actionType)
        {
            //entity.Id = entity.Id;
            entity.OrgNumber = model.OrgNumber;
            entity.Name = model.Name;
            entity.Abbr = model.Abbr;
            //entity.AccountingArea = model.AccountingArea;
            //entity.LandTag = model.LandTag;
            //entity.OrgTopId = model.OrgTopId;
            entity.LocationAbbr = model.LocationAbbr;
            entity.SysLocationId = model.SysLocationId;
            //entity.OrgAccountTypeId = model.OrgAccountTypeId;
            entity.OrgTypeId = model.OrgTypeId;
            //entity.OrdInspectionLocationId = model.OrdInspectionLocationId;
            entity.EmailFrom = model.EmailFrom;
            entity.EmailTo = model.EmailTo;
            entity.IsEgdokPrintAlways = model.IsEgdokPrintAlways;
            entity.DeleteDate = model.DeleteDate;
            entity.Source = model.Source;
            entity.OrgAccountingAreaId = model.OrgAccountingAreaId;
        }
    }
}
