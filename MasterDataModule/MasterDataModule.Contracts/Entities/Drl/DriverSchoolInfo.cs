using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     EN: 5.3.2.4 Reference table: Driver School - Information regarding Driver School  DE: 5.3.2.4 Fahrschule - Information zuordnen
    /// </summary>
    public partial class DriverSchoolInfo: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DATA.DRL_DRIVER_SCHOOL_INFO_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="DriverSchoolInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'DRL_SCHOOL_INFO_ID' for property <see cref="DriverSchoolInfo.SchoolInfoId"/>
            /// </summary>
            public static readonly string SchoolInfoId = "DRL_SCHOOL_INFO_ID";
            /// <summary>
            /// Column name 'DRL_DRIVER_SCHOOL_ID' for property <see cref="DriverSchoolInfo.DriverSchoolId"/>
            /// </summary>
            public static readonly string DriverSchoolId = "DRL_DRIVER_SCHOOL_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="DriverSchoolInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="DriverSchoolInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="DriverSchoolInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="DriverSchoolInfo.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="DriverSchoolInfo.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="DriverSchoolInfo.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="DriverSchoolInfo.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="DriverSchoolInfo.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="DriverSchoolInfo.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="DriverSchoolInfo.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        /// <summary>
        ///     EN: PK  DE: Primaerschluessel
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        ///     EN: Driver School Information  DE: Fahrschule Information
        /// </summary>
        public int SchoolInfoId{ get; set; }
        /// <summary>
        ///     EN: Driver School  DE: Fahrschule
        /// </summary>
        public int DriverSchoolId{ get; set; }
        /// <summary>
        ///     ANLAGEDATUM (INSERT-DATUM)
        /// </summary>
        public DateTime CreateDate{ get; set; }
        /// <summary>
        ///     AENDERUNGSDATUM (UPDATE-DATUM)
        /// </summary>
        public DateTime ChangeDate{ get; set; }
        /// <summary>
        ///     LOESCHDATUM FUER LOGISCHE LOESCHUNG VON DATENSAETZEN (DELETE-DATUM)
        /// </summary>
        public DateTime? DeleteDate{ get; set; }
        /// <summary>
        ///     OWNER (SCHLUESSEL EINER ORGANISATIONSEINHEIT, WELCHE FUER DIE PFLEGE EINES DATENSATZES
        /// </summary>
        public int? OwnerOrgId{ get; set; }
        /// <summary>
        ///     SICHTBARKEIT (SCHLUESSEL EINER ORGANISATIONSEINHEIT, AB WELCHER IM HIERACHIEBAUM ABWAERTS EIN DATENSATZ SICHTBAR IST)
        /// </summary>
        public int? VisibilityOrgId{ get; set; }
        /// <summary>
        ///     ANLEGER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ANGELEGT HAT)
        /// </summary>
        public int? CreateEmployeeId{ get; set; }
        /// <summary>
        ///     AENDERER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ALS LETZTES GEAENDERT HAT, BEI NEUANLAGE IST DIESER WERT GLEICH DEM ANLEGER)
        /// </summary>
        public int? ChangeEmployeeId{ get; set; }
        /// <summary>
        ///     QUELLSYSTEM
        /// </summary>
        public string Source{ get; set; }
        /// <summary>
        ///     VON-DATUM DER GUELTIGKEIT
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     ENDE-DATUM DER GUELTIGKEIT
        /// </summary>
        public DateTime ToDate{ get; set; }
        public virtual DriverSchool DriverSchool{ get; set; }
        public virtual SchoolInfo SchoolInfo{ get; set; }
        public bool HasDriverSchool
        {
            get { return !ReferenceEquals(DriverSchool, null); }
        }
        public bool HasSchoolInfo
        {
            get { return !ReferenceEquals(SchoolInfo, null); }
        }
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
            get { return CreateDate; }
            set { CreateDate = value; }
        }
        DateTime ISystemFields.ChangeDate
        {
            get { return ChangeDate; }
            set { ChangeDate = value; }
        }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public DriverSchoolInfo ShallowCopy()
        {
            return new DriverSchoolInfo {
                       SchoolInfoId = SchoolInfoId,
                       DriverSchoolId = DriverSchoolId,
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
