using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Rechtsgrund  EN: Legal basis
    /// </summary>
    public partial class LegalBasis: IHasId<int>
        ,IHasTitle<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DATA.DRL_LEGAL_BASIS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="LegalBasis.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="LegalBasis.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="LegalBasis.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'EDUCATION_CERTIFICATE_REQUIRED' for property <see cref="LegalBasis.EducationCertificateRequired"/>
            /// </summary>
            public static readonly string EducationCertificateRequired = "EDUCATION_CERTIFICATE_REQUIRED";
            /// <summary>
            /// Column name 'FIRST_ASSIGNATION' for property <see cref="LegalBasis.FirstAssignation"/>
            /// </summary>
            public static readonly string FirstAssignation = "FIRST_ASSIGNATION";
            /// <summary>
            /// Column name 'MESSAGE_REASON' for property <see cref="LegalBasis.MessageReason"/>
            /// </summary>
            public static readonly string MessageReason = "MESSAGE_REASON";
            /// <summary>
            /// Column name 'MESSAGE_REASON_STYLE' for property <see cref="LegalBasis.MessageReasonStyle"/>
            /// </summary>
            public static readonly string MessageReasonStyle = "MESSAGE_REASON_STYLE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="LegalBasis.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="LegalBasis.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="LegalBasis.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="LegalBasis.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="LegalBasis.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="LegalBasis.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="LegalBasis.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="LegalBasis.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="LegalBasis.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="LegalBasis.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'REPLACEMENT_ID' for property <see cref="LegalBasis.ReplacementId"/>
            /// </summary>
            public static readonly string ReplacementId = "REPLACEMENT_ID";
            /// <summary>
            /// Column name 'PRINT_NAME' for property <see cref="LegalBasis.PrintName"/>
            /// </summary>
            public static readonly string PrintName = "PRINT_NAME";
          
        }
        #endregion
        /// <summary>
        ///     EN: PK  DE: Primaerschluessel
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Kurz-Bezeichnung des FE-Rechtsgrunds  EN: Legal Basis
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: Beschreibung der FE-Rechtsgrunds  EN: Description
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        ///     DE: Angabe, ob eine Ausbildungsbescheinigung notwendig ist   EN: Indication whether Education Certificate is required
        /// </summary>
        public bool EducationCertificateRequired{ get; set; }
        /// <summary>
        ///     DE: Angabe, ob es sich um eine Ersterteilung handelt  EN: Indication whether it is first assignation of the driver licence
        /// </summary>
        public int FirstAssignation{ get; set; }
        /// <summary>
        ///     DE: Mitteilungsgrund  EN: Statement regarding Message Reason
        /// </summary>
        public string MessageReason{ get; set; }
        /// <summary>
        ///     DE: Art der Mitteilung  EN: Statement regarding ADMI2 (Type of Message)
        /// </summary>
        public string MessageReasonStyle{ get; set; }
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
        ///     DE: Von Datum  EN: From date
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE: Bis Datum  EN: To date
        /// </summary>
        public DateTime ToDate{ get; set; }
        /// <summary>
        ///     DE: Erzarz-Rechtsgrund die wird beim Wechsel von Ersterteilung nach Erweiterung benutzt (falls eine Theorie bestanden)  EN: Legal basis for replacement First assignation on Extending
        /// </summary>
        public int? ReplacementId{ get; set; }
        /// <summary>
        ///     DE: Name auf dem Druckformular  EN: Print name
        /// </summary>
        public string PrintName{ get; set; }
        public virtual ICollection<CoreDataProductClassBasis> CoreDataProductClassBases{ get; set; }
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
        public LegalBasis ShallowCopy()
        {
            return new LegalBasis {
                       Name = Name,
                       Description = Description,
                       EducationCertificateRequired = EducationCertificateRequired,
                       FirstAssignation = FirstAssignation,
                       MessageReason = MessageReason,
                       MessageReasonStyle = MessageReasonStyle,
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
                       ReplacementId = ReplacementId,
                       PrintName = PrintName,
        	           };
        }
    }
}
