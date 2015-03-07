using System;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData
{
    public class OrgOrganizationalUnitModel : BaseModel
    {
        public int OrgNumber { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public string AccountingArea { get; set; }
        public int? LandTag { get; set; }
        public int? OrgTopId { get; set; }
        public string LocationAbbr { get; set; }
        public int? SysLocationId { get; set; }
        public int? OrgAccountTypeId { get; set; }
        public int OrgTypeId { get; set; }
        public int? OrdInspectionLocationId { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public bool IsEgdokPrintAlways { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string Source { get; set; }
        public int? OrgAccountingAreaId { get; set; }
        /// <summary>
        /// Validity start date. Original table: ORG_ORGANIZATIONAL_UNIT, Column: FROM_DATE  
        /// </summary>
        public System.DateTime FromDate { get; set; }
        /// <summary>
        /// Validity end date. Original table: ORG_ORGANIZATIONAL_UNIT, Column: TO_DATE  
        /// </summary>
        public System.DateTime ToDate { get; set; }
        
    }
}
