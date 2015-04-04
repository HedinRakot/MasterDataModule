using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     EN: 5.2.12.6 Possible Exam Results  DE: 5.2.12.6 Fahrerlaubnis - Pruefleistungsergebnisse
    /// </summary>
    public partial class ExamPossibleResult: IHasId<int>
        ,IHasTitle
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DATA.DRL_EXAM_POSSIBLE_RESULT";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'NAME' for property <see cref="ExamPossibleResult.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="ExamPossibleResult.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'IS_FEE_PAYABLE' for property <see cref="ExamPossibleResult.IsFeePayable"/>
            /// </summary>
            public static readonly string IsFeePayable = "IS_FEE_PAYABLE";
            /// <summary>
            /// Column name 'EXAM_COUNTER_FLAG' for property <see cref="ExamPossibleResult.ExamCounterFlag"/>
            /// </summary>
            public static readonly string ExamCounterFlag = "EXAM_COUNTER_FLAG";
            /// <summary>
            /// Column name 'NEXT_EXAM_PRODUCT_FLAG' for property <see cref="ExamPossibleResult.NextExamProductFlag"/>
            /// </summary>
            public static readonly string NextExamProductFlag = "NEXT_EXAM_PRODUCT_FLAG";
            /// <summary>
            /// Column name 'DRIVER_LICENCE_FLAG' for property <see cref="ExamPossibleResult.DriverLicenceFlag"/>
            /// </summary>
            public static readonly string DriverLicenceFlag = "DRIVER_LICENCE_FLAG";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="ExamPossibleResult.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="ExamPossibleResult.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="ExamPossibleResult.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="ExamPossibleResult.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="ExamPossibleResult.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="ExamPossibleResult.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="ExamPossibleResult.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="ExamPossibleResult.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="ExamPossibleResult.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="ExamPossibleResult.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'IS_MEDICAL_ATTEST_REQUIRED' for property <see cref="ExamPossibleResult.IsMedicalAttestRequired"/>
            /// </summary>
            public static readonly string IsMedicalAttestRequired = "IS_MEDICAL_ATTEST_REQUIRED";
            /// <summary>
            /// Column name 'ID' for property <see cref="ExamPossibleResult.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     EN: Exam Result (for example 90, --, 1, 2, ...)  DE: Pruefleistungsergebnis (z.B. 90, --, 1, 2, ...)
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     EN: Description  DE: Beschreibung
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        ///     EN: Indication whether fee is due  DE: Angabe, ob Gebuehr faellig
        /// </summary>
        public bool IsFeePayable{ get; set; }
        /// <summary>
        ///     EN: Indication whether exam counter increases  DE: Angabe, ob Pruefungszaehler hochgesetzt wird
        /// </summary>
        public bool ExamCounterFlag{ get; set; }
        /// <summary>
        ///     EN: Indication whether next exam product is required  DE: Angabe, ob Folgeleistung angelegt wird
        /// </summary>
        public bool NextExamProductFlag{ get; set; }
        /// <summary>
        ///     EN: Indication whether Driver Licence can be handed over  DE: Angabe, ob Fuehrerschein ausgehaendigt werden kann
        /// </summary>
        public bool DriverLicenceFlag{ get; set; }
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
        /// <summary>
        ///     Is medical attest requared
        /// </summary>
        public bool IsMedicalAttestRequired{ get; set; }
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
        string IHasTitle.EntityTitle
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
        public ExamPossibleResult ShallowCopy()
        {
            return new ExamPossibleResult {
                       Name = Name,
                       Description = Description,
                       IsFeePayable = IsFeePayable,
                       ExamCounterFlag = ExamCounterFlag,
                       NextExamProductFlag = NextExamProductFlag,
                       DriverLicenceFlag = DriverLicenceFlag,
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
                       IsMedicalAttestRequired = IsMedicalAttestRequired,
        	           };
        }
    }
}
