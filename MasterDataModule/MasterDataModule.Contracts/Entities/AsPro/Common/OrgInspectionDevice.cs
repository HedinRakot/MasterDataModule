using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: OE-Prüfmittel  EN: Organization inspection device
    /// </summary>
    public partial class OrgInspectionDevice: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORG_INSPECTION_DEVICE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'DEBITOR_CUSTOMER_NUMBER' for property <see cref="OrgInspectionDevice.DebitorCustomerNumber"/>
            /// </summary>
            public static readonly string DebitorCustomerNumber = "DEBITOR_CUSTOMER_NUMBER";
            /// <summary>
            /// Column name 'IDENTIFICATION' for property <see cref="OrgInspectionDevice.Identification"/>
            /// </summary>
            public static readonly string Identification = "IDENTIFICATION";
            /// <summary>
            /// Column name 'NEW_IDENTIFICATION' for property <see cref="OrgInspectionDevice.NewIdentification"/>
            /// </summary>
            public static readonly string NewIdentification = "NEW_IDENTIFICATION";
            /// <summary>
            /// Column name 'OLD_IDENTIFICATION' for property <see cref="OrgInspectionDevice.OldIdentification"/>
            /// </summary>
            public static readonly string OldIdentification = "OLD_IDENTIFICATION";
            /// <summary>
            /// Column name 'TYPE' for property <see cref="OrgInspectionDevice.Type"/>
            /// </summary>
            public static readonly string Type = "TYPE";
            /// <summary>
            /// Column name 'SERIAL_NUMBER' for property <see cref="OrgInspectionDevice.SerialNumber"/>
            /// </summary>
            public static readonly string SerialNumber = "SERIAL_NUMBER";
            /// <summary>
            /// Column name 'NAME' for property <see cref="OrgInspectionDevice.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="OrgInspectionDevice.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'LAST_INSPECTION_DATE' for property <see cref="OrgInspectionDevice.LastInspectionDate"/>
            /// </summary>
            public static readonly string LastInspectionDate = "LAST_INSPECTION_DATE";
            /// <summary>
            /// Column name 'LAST_INSPECTION_RESULT' for property <see cref="OrgInspectionDevice.LastInspectionResult"/>
            /// </summary>
            public static readonly string LastInspectionResult = "LAST_INSPECTION_RESULT";
            /// <summary>
            /// Column name 'INSPECTION_DATE' for property <see cref="OrgInspectionDevice.InspectionDate"/>
            /// </summary>
            public static readonly string InspectionDate = "INSPECTION_DATE";
            /// <summary>
            /// Column name 'INSPECTION_INTERVAL' for property <see cref="OrgInspectionDevice.InspectionInterval"/>
            /// </summary>
            public static readonly string InspectionInterval = "INSPECTION_INTERVAL";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrgInspectionDevice.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrgInspectionDevice.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrgInspectionDevice.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrgInspectionDevice.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrgInspectionDevice.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrgInspectionDevice.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrgInspectionDevice.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrgInspectionDevice.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrgInspectionDevice.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="OrgInspectionDevice.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="OrgInspectionDevice.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        /// <summary>
        ///     DE: Debitornummer des Kunden  EN: Debitor number
        /// </summary>
        public string DebitorCustomerNumber{ get; set; }
        /// <summary>
        ///     DE: Identifizierung des Prüfmittels  EN: Identification
        /// </summary>
        public string Identification{ get; set; }
        /// <summary>
        ///     DE: Neue Identifizierung des Prüfmittels  EN: New identification
        /// </summary>
        public string NewIdentification{ get; set; }
        /// <summary>
        ///     DE: Alte Identifizierung des Prüfmittels  EN: Old identification
        /// </summary>
        public string OldIdentification{ get; set; }
        /// <summary>
        ///     DE: Prüfmitteltyp  EN: Type
        /// </summary>
        public string Type{ get; set; }
        /// <summary>
        ///     DE: Seriennummer  EN: Serial number
        /// </summary>
        public string SerialNumber{ get; set; }
        /// <summary>
        ///     DE: Name der Prüfmittel-Prüfung  EN: Name
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: Beschreibung der Prüfmittel-Prüfung  EN: Description
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        ///     DE: Letztes Prüfungsdatum  EN: Last inspection date
        /// </summary>
        public DateTime? LastInspectionDate{ get; set; }
        /// <summary>
        ///     DE: Ergebnis der letzten Prüfung  EN: Last inspection result
        /// </summary>
        public string LastInspectionResult{ get; set; }
        /// <summary>
        ///     DE: Prüfungsdatum  EN: Inspection date
        /// </summary>
        public DateTime? InspectionDate{ get; set; }
        /// <summary>
        ///     DE: Prüfungsintervall  EN: Inspection interval
        /// </summary>
        public int? InspectionInterval{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Von Datum  EN: From date
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE: Bis Datum  EN: To date
        /// </summary>
        public DateTime ToDate{ get; set; }
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
        public OrgInspectionDevice ShallowCopy()
        {
            return new OrgInspectionDevice {
                       DebitorCustomerNumber = DebitorCustomerNumber,
                       Identification = Identification,
                       NewIdentification = NewIdentification,
                       OldIdentification = OldIdentification,
                       Type = Type,
                       SerialNumber = SerialNumber,
                       Name = Name,
                       Description = Description,
                       LastInspectionDate = LastInspectionDate,
                       LastInspectionResult = LastInspectionResult,
                       InspectionDate = InspectionDate,
                       InspectionInterval = InspectionInterval,
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
        	           };
        }
    }
}
