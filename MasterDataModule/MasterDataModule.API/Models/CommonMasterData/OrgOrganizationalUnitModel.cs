using System;
using System.Runtime.Serialization;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData
{
    [DataContract]
    public class OrgOrganizationalUnitModel : BaseModel,  ISystemModelFields
    {
        [DataMember]
        public int orgNumber { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string abbr { get; set; }
        [DataMember]
        public string accountingArea { get; set; }
        [DataMember]
        public int? landTag { get; set; }
        [DataMember]
        public int? orgTopId { get; set; }
        [DataMember]
        public string locationAbbr { get; set; }
        [DataMember]
        public int? sysLocationId { get; set; }
        [DataMember]
        public int? orgAccountTypeId { get; set; }
        [DataMember]
        public int orgTypeId { get; set; }
        [DataMember]
        public int? ordInspectionLocationId { get; set; }
        [DataMember]
        public string emailFrom { get; set; }
        [DataMember]
        public string emailTo { get; set; }
        [DataMember]
        public bool isEgdokPrintAlways { get; set; }
        [DataMember]
        public DateTime? deleteDate { get; set; }
        [DataMember]
        public string source { get; set; }
        [DataMember]
        public int? orgAccountingAreaId { get; set; }
        /// <summary>
        /// Validity start date. Original table: ORG_ORGANIZATIONAL_UNIT, Column: FROM_DATE  
        /// </summary>
        [DataMember]
        public System.DateTime fromDate { get; set; }
        /// <summary>
        /// Validity end date. Original table: ORG_ORGANIZATIONAL_UNIT, Column: TO_DATE  
        /// </summary>
        [DataMember]
        public System.DateTime toDate { get; set; }
        
    }
}
