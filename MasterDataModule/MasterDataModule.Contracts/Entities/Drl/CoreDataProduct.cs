using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     EN: 5.3.5.15 Product - assign Additional Details  DE: 5.3.5.15 Produkt - FE-Zusatzdaten zuordnen
    /// </summary>
    public partial class CoreDataProduct: IHasId<int>
        ,IHasTitle
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DATA.DRL_CORE_DATA_PRODUCT";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="CoreDataProduct.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'INS_CORE_DATA_PRODUCT_ID' for property <see cref="CoreDataProduct.InsCoreDataProductId"/>
            /// </summary>
            public static readonly string InsCoreDataProductId = "INS_CORE_DATA_PRODUCT_ID";
            /// <summary>
            /// Column name 'POINT_AMOUNT' for property <see cref="CoreDataProduct.PointAmount"/>
            /// </summary>
            public static readonly string PointAmount = "POINT_AMOUNT";
            /// <summary>
            /// Column name 'MIN_AGE' for property <see cref="CoreDataProduct.MinAge"/>
            /// </summary>
            public static readonly string MinAge = "MIN_AGE";
            /// <summary>
            /// Column name 'MAX_AGE' for property <see cref="CoreDataProduct.MaxAge"/>
            /// </summary>
            public static readonly string MaxAge = "MAX_AGE";
            /// <summary>
            /// Column name 'EXAM_TYPE' for property <see cref="CoreDataProduct.ExamType"/>
            /// </summary>
            public static readonly string ExamType = "EXAM_TYPE";
            /// <summary>
            /// Column name 'PRIOR_TIME_IN_MONTHS' for property <see cref="CoreDataProduct.PriorTimeInMonths"/>
            /// </summary>
            public static readonly string PriorTimeInMonths = "PRIOR_TIME_IN_MONTHS";
            /// <summary>
            /// Column name 'EXPIRATION_IN_MONTH' for property <see cref="CoreDataProduct.ExpirationInMonth"/>
            /// </summary>
            public static readonly string ExpirationInMonth = "EXPIRATION_IN_MONTH";
            /// <summary>
            /// Column name 'REPEAT_TIME_IN_DAYS' for property <see cref="CoreDataProduct.RepeatTimeInDays"/>
            /// </summary>
            public static readonly string RepeatTimeInDays = "REPEAT_TIME_IN_DAYS";
            /// <summary>
            /// Column name 'TRAINING_CERT_FLAG' for property <see cref="CoreDataProduct.TrainingCertFlag"/>
            /// </summary>
            public static readonly string TrainingCertFlag = "TRAINING_CERT_FLAG";
            /// <summary>
            /// Column name 'RESULT_FLAG' for property <see cref="CoreDataProduct.ResultFlag"/>
            /// </summary>
            public static readonly string ResultFlag = "RESULT_FLAG";
            /// <summary>
            /// Column name 'MULTIPLY_FLAG' for property <see cref="CoreDataProduct.MultiplyFlag"/>
            /// </summary>
            public static readonly string MultiplyFlag = "MULTIPLY_FLAG";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="CoreDataProduct.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="CoreDataProduct.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="CoreDataProduct.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="CoreDataProduct.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="CoreDataProduct.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="CoreDataProduct.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="CoreDataProduct.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="CoreDataProduct.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="CoreDataProduct.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="CoreDataProduct.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'IS_MOFA_PRINT' for property <see cref="CoreDataProduct.IsMofaPrint"/>
            /// </summary>
            public static readonly string IsMofaPrint = "IS_MOFA_PRINT";
            /// <summary>
            /// Column name 'IS_ADDITIONAL_PRODUCT' for property <see cref="CoreDataProduct.IsAdditionalProduct"/>
            /// </summary>
            public static readonly string IsAdditionalProduct = "IS_ADDITIONAL_PRODUCT";
            /// <summary>
            /// Column name 'IS_PREPAYMENT_REQUIRED' for property <see cref="CoreDataProduct.IsPrepaymentRequired"/>
            /// </summary>
            public static readonly string IsPrepaymentRequired = "IS_PREPAYMENT_REQUIRED";
            /// <summary>
            /// Column name 'IS_MANDATORY' for property <see cref="CoreDataProduct.IsMandatory"/>
            /// </summary>
            public static readonly string IsMandatory = "IS_MANDATORY";
            /// <summary>
            /// Column name 'FE_PRODUCT_NUMBER' for property <see cref="CoreDataProduct.FeProductNumber"/>
            /// </summary>
            public static readonly string FeProductNumber = "FE_PRODUCT_NUMBER";
            /// <summary>
            /// Column name 'REPEAT_TIME_IN_DAYS_REDUCED' for property <see cref="CoreDataProduct.RepeatTimeInDaysReduced"/>
            /// </summary>
            public static readonly string RepeatTimeInDaysReduced = "REPEAT_TIME_IN_DAYS_REDUCED";
          
        }
        #endregion
        /// <summary>
        ///     EN: PK  DE: Primaerschluessel
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        ///     EN: Product  DE: FE-Produkt
        /// </summary>
        public int InsCoreDataProductId{ get; set; }
        /// <summary>
        ///     EN: Point Amount  DE: Punkte
        /// </summary>
        public decimal PointAmount{ get; set; }
        /// <summary>
        ///     EN: Minimum Age  DE: Mindestalter
        /// </summary>
        public byte MinAge{ get; set; }
        /// <summary>
        ///     EN: Maximum Age  DE: Hoechstalter
        /// </summary>
        public byte? MaxAge{ get; set; }
        /// <summary>
        ///     EN: Exam Type (Enum: 1 - Theorie, 2 - Praxis, 3 - Theorie und Praxis, 4 - not relevant)  DE: Pruefart (Enum: 1 - Theorie, 2 - Praxis, 3 - Theorie und Praxis, 4 - nicht relevant)
        /// </summary>
        public int ExamType{ get; set; }
        /// <summary>
        ///     EN: Prior Time in Months  DE: Vorzeit in Monaten
        /// </summary>
        public short PriorTimeInMonths{ get; set; }
        /// <summary>
        ///     EN: Exparation date in months  DE: Verfallsfrist in Monaten
        /// </summary>
        public short ExpirationInMonth{ get; set; }
        /// <summary>
        ///     EN: Repetition time in days  DE: Wiederholungsfrist in Tagen
        /// </summary>
        public short RepeatTimeInDays{ get; set; }
        /// <summary>
        ///     EN: Indication whether Attestation is possible  DE: Angabe ob Ausbildungsbescheinigung moeglich
        /// </summary>
        public bool TrainingCertFlag{ get; set; }
        /// <summary>
        ///     EN: Indication whether Result is possible  DE: Angabe ob Ergebnis moglich
        /// </summary>
        public bool ResultFlag{ get; set; }
        /// <summary>
        ///     EN: Indication whether Product is possible several time per position  DE: Angabe ob Leistung mehrfach pro Position moeglich
        /// </summary>
        public bool MultiplyFlag{ get; set; }
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
        ///     DE: Zeigt an, ob Mofa Pruefbescheinigung zu druecken ist EN: Indication whether Mofa certificate should be printed
        /// </summary>
        public bool IsMofaPrint{ get; set; }
        /// <summary>
        ///     DE: Zeigt an, ob es eine Zusatzleistung ist EN: Additional product indication
        /// </summary>
        public bool IsAdditionalProduct{ get; set; }
        /// <summary>
        ///     DE: Zeigt an, ob Vorzahlung im  Vorinkasso-Fall notwendig ist EN: Indication whether pre-payment is necessary
        /// </summary>
        public bool IsPrepaymentRequired{ get; set; }
        /// <summary>
        ///     EN: Indication whether Exam Product is mandatory DE: Angabe ob es eine pflicht Pruefleistung
        /// </summary>
        public bool IsMandatory{ get; set; }
        /// <summary>
        ///     DE: Eindeutige Nummer der FE Pruefleistung EN: FE Produkt Number , unique
        /// </summary>
        public string FeProductNumber{ get; set; }
        /// <summary>
        ///     EN: Reduced repetition time in days  DE: Abgekuerzte Wiederholungsfrist in Tagen
        /// </summary>
        public short RepeatTimeInDaysReduced{ get; set; }
        public virtual ICollection<CoreDataProductClassBasis> CoreDataProductClassBases{ get; set; }
        public virtual ICollection<CoreDataProductLocalization> CoreDataProductLocalizations{ get; set; }
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
            get { return ProductName; }
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
        public CoreDataProduct ShallowCopy()
        {
            return new CoreDataProduct {
                       InsCoreDataProductId = InsCoreDataProductId,
                       PointAmount = PointAmount,
                       MinAge = MinAge,
                       MaxAge = MaxAge,
                       ExamType = ExamType,
                       PriorTimeInMonths = PriorTimeInMonths,
                       ExpirationInMonth = ExpirationInMonth,
                       RepeatTimeInDays = RepeatTimeInDays,
                       TrainingCertFlag = TrainingCertFlag,
                       ResultFlag = ResultFlag,
                       MultiplyFlag = MultiplyFlag,
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
                       IsMofaPrint = IsMofaPrint,
                       IsAdditionalProduct = IsAdditionalProduct,
                       IsPrepaymentRequired = IsPrepaymentRequired,
                       IsMandatory = IsMandatory,
                       FeProductNumber = FeProductNumber,
                       RepeatTimeInDaysReduced = RepeatTimeInDaysReduced,
        	           };
        }
    }
}
