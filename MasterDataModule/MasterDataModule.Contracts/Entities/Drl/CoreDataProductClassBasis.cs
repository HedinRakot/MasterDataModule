using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     EN: 5.3.5.20 Reference table: Assignment of the Legal_Basis/Class to the Product  DE: 5.3.5.20 Produkt - FE-Rechtsgrund/Klasse zuordnen
    /// </summary>
    public partial class CoreDataProductClassBasis: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DATA.DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="CoreDataProductClassBasis.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'DRL_EXAM_CLASS_ID' for property <see cref="CoreDataProductClassBasis.ExamClassId"/>
            /// </summary>
            public static readonly string ExamClassId = "DRL_EXAM_CLASS_ID";
            /// <summary>
            /// Column name 'DRL_CORE_DATA_PRODUCT_ID' for property <see cref="CoreDataProductClassBasis.CoreDataProductId"/>
            /// </summary>
            public static readonly string CoreDataProductId = "DRL_CORE_DATA_PRODUCT_ID";
            /// <summary>
            /// Column name 'DRL_LEGAL_BASIS_ID' for property <see cref="CoreDataProductClassBasis.LegalBasisId"/>
            /// </summary>
            public static readonly string LegalBasisId = "DRL_LEGAL_BASIS_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="CoreDataProductClassBasis.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="CoreDataProductClassBasis.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="CoreDataProductClassBasis.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="CoreDataProductClassBasis.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="CoreDataProductClassBasis.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="CoreDataProductClassBasis.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="CoreDataProductClassBasis.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="CoreDataProductClassBasis.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="CoreDataProductClassBasis.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="CoreDataProductClassBasis.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'SORT_ORDER' for property <see cref="CoreDataProductClassBasis.SortOrder"/>
            /// </summary>
            public static readonly string SortOrder = "SORT_ORDER";
          
        }
        #endregion
        /// <summary>
        ///     EN: PK  DE: Primaerschluessel
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        ///     EN: Class  DE: FE-Klasse
        /// </summary>
        public int ExamClassId{ get; set; }
        /// <summary>
        ///     EN: Product  DE: FE-Produkt
        /// </summary>
        public int CoreDataProductId{ get; set; }
        /// <summary>
        ///     EN: Legal Bases  DE: Rechtsgrund
        /// </summary>
        public int LegalBasisId{ get; set; }
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
        ///     DE: Reihenfolge fuer die Anzeige im GUI EN: Sort Order for GUI
        /// </summary>
        public int SortOrder{ get; set; }
        public virtual ExamClass ExamClass{ get; set; }
        public virtual LegalBasis LegalBasis{ get; set; }
        public virtual CoreDataProduct CoreDataProduct{ get; set; }
        public bool HasExamClass
        {
            get { return !ReferenceEquals(ExamClass, null); }
        }
        public bool HasLegalBasis
        {
            get { return !ReferenceEquals(LegalBasis, null); }
        }
        public bool HasCoreDataProduct
        {
            get { return !ReferenceEquals(CoreDataProduct, null); }
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
        public CoreDataProductClassBasis ShallowCopy()
        {
            return new CoreDataProductClassBasis {
                       ExamClassId = ExamClassId,
                       CoreDataProductId = CoreDataProductId,
                       LegalBasisId = LegalBasisId,
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
                       SortOrder = SortOrder,
        	           };
        }
    }
}
