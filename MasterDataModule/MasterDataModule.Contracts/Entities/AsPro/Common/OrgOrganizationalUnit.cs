using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Organisationseinheit  EN: Organizational unit
    /// </summary>
    public partial class OrgOrganizationalUnit: IHasId<int>
        ,IHasTitle<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORG_ORGANIZATIONAL_UNIT";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ORG_NUMBER' for property <see cref="OrgOrganizationalUnit.OrgNumber"/>
            /// </summary>
            public static readonly string OrgNumber = "ORG_NUMBER";
            /// <summary>
            /// Column name 'NAME' for property <see cref="OrgOrganizationalUnit.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'ABBR' for property <see cref="OrgOrganizationalUnit.Abbr"/>
            /// </summary>
            public static readonly string Abbr = "ABBR";
            /// <summary>
            /// Column name 'LOCATION_ABBR' for property <see cref="OrgOrganizationalUnit.LocationAbbr"/>
            /// </summary>
            public static readonly string LocationAbbr = "LOCATION_ABBR";
            /// <summary>
            /// Column name 'SYS_LOCATION_ID' for property <see cref="OrgOrganizationalUnit.SysLocationId"/>
            /// </summary>
            public static readonly string SysLocationId = "SYS_LOCATION_ID";
            /// <summary>
            /// Column name 'ORG_TYPE_ID' for property <see cref="OrgOrganizationalUnit.OrgTypeId"/>
            /// </summary>
            public static readonly string OrgTypeId = "ORG_TYPE_ID";
            /// <summary>
            /// Column name 'EMAIL_FROM' for property <see cref="OrgOrganizationalUnit.EmailFrom"/>
            /// </summary>
            public static readonly string EmailFrom = "EMAIL_FROM";
            /// <summary>
            /// Column name 'EMAIL_TO' for property <see cref="OrgOrganizationalUnit.EmailTo"/>
            /// </summary>
            public static readonly string EmailTo = "EMAIL_TO";
            /// <summary>
            /// Column name 'IS_EGDOK_PRINT_ALWAYS' for property <see cref="OrgOrganizationalUnit.IsEgdokPrintAlways"/>
            /// </summary>
            public static readonly string IsEgdokPrintAlways = "IS_EGDOK_PRINT_ALWAYS";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrgOrganizationalUnit.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrgOrganizationalUnit.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrgOrganizationalUnit.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrgOrganizationalUnit.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrgOrganizationalUnit.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrgOrganizationalUnit.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrgOrganizationalUnit.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrgOrganizationalUnit.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="OrgOrganizationalUnit.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="OrgOrganizationalUnit.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ORG_ACCOUNTING_AREA_ID' for property <see cref="OrgOrganizationalUnit.OrgAccountingAreaId"/>
            /// </summary>
            public static readonly string OrgAccountingAreaId = "ORG_ACCOUNTING_AREA_ID";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrgOrganizationalUnit.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     DE: OE-Nummer  EN: Org Number
        /// </summary>
        public int OrgNumber{ get; set; }
        /// <summary>
        ///     DE: OE-Bezeichnung  EN: Name
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: OE-Kürzel  EN: Abbreviation
        /// </summary>
        public string Abbr{ get; set; }
        /// <summary>
        ///     DE: Standortcode-Kürzel  EN: Location abbreviation
        /// </summary>
        public string LocationAbbr{ get; set; }
        /// <summary>
        ///     DE: Standortcode   EN: Location
        /// </summary>
        public int? SysLocationId{ get; set; }
        /// <summary>
        ///     DE: OE-Typ   EN: Org type
        /// </summary>
        public int OrgTypeId{ get; set; }
        /// <summary>
        ///     DE: Email von  EN: Email from
        /// </summary>
        public string EmailFrom{ get; set; }
        /// <summary>
        ///     DE: Email bis  EN: Email to
        /// </summary>
        public string EmailTo{ get; set; }
        /// <summary>
        ///     DE: Angabe, ob EGDok-Dokumente für diese OE auch bei negativem Ergebnis gedruckt werden können  EN: EGDok print always
        /// </summary>
        public bool IsEgdokPrintAlways{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        /// <summary>
        ///     DE: Von Datum  EN: From date
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE: Bis Datum  EN: To date
        /// </summary>
        public DateTime ToDate{ get; set; }
        /// <summary>
        ///     DE: Buchungskreis  EN: Accounting area
        /// </summary>
        public int? OrgAccountingAreaId{ get; set; }
        public int Id{ get; set; }
        DateTime? IIntervalFields.FromDate
        {
            get { return FromDate; }
            set { if(value.HasValue)FromDate = value.Value; else throw new ArgumentNullException("value"); }
        }
        DateTime? IIntervalFields.ToDate
        {
            get { return ToDate; }
            set { if(value.HasValue)ToDate = value.Value; else throw new ArgumentNullException("value"); }
        }
        string IHasTitle<int>.EntityTitle
        {
            get { return Name; }
        }
        DateTime ISystemFields.CreateDate
        {
            get { if(CreateDate.HasValue) return CreateDate.Value; else return DateTime.Now; }
            set { CreateDate = value; }
        }
        DateTime ISystemFields.ChangeDate
        {
            get { if(ChangeDate.HasValue) return ChangeDate.Value; else return CreateDate ?? DateTime.Now; }
            set { ChangeDate = value; }
        }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public OrgOrganizationalUnit ShallowCopy()
        {
            return new OrgOrganizationalUnit {
                       OrgNumber = OrgNumber,
                       Name = Name,
                       Abbr = Abbr,
                       LocationAbbr = LocationAbbr,
                       SysLocationId = SysLocationId,
                       OrgTypeId = OrgTypeId,
                       EmailFrom = EmailFrom,
                       EmailTo = EmailTo,
                       IsEgdokPrintAlways = IsEgdokPrintAlways,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       OwnerOrgId = OwnerOrgId,
                       VisibilityOrgId = VisibilityOrgId,
                       CreateEmployeeId = CreateEmployeeId,
                       ChangeEmployeeId = ChangeEmployeeId,
                       Source = Source,
                       FromDate = FromDate,
                       ToDate = ToDate,
                       OrgAccountingAreaId = OrgAccountingAreaId,
        	           };
        }
    }
}
