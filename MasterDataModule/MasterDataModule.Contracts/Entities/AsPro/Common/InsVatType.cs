using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Mehrwertsteuersatz  EN: Tax code
    /// </summary>
    public partial class InsVatType: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_VAT_TYPE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="InsVatType.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'TAX_CODE' for property <see cref="InsVatType.TaxCode"/>
            /// </summary>
            public static readonly string TaxCode = "TAX_CODE";
            /// <summary>
            /// Column name 'PERCENT' for property <see cref="InsVatType.Percent"/>
            /// </summary>
            public static readonly string Percent = "PERCENT";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsVatType.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsVatType.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsVatType.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsVatType.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsVatType.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsVatType.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsVatType.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsVatType.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsVatType.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsVatType.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsVatType.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        /// <summary>
        ///     DE: Beschreibung des Mehrwertsteuersatzes  EN: Description
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        ///     DE: SAP-Steuercode   EN: Tax code
        /// </summary>
        public string TaxCode{ get; set; }
        /// <summary>
        ///     DE: Prozentsatz des Mehrwertsteuersatzes  EN: Percent
        /// </summary>
        public decimal? Percent{ get; set; }
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
        public InsVatType ShallowCopy()
        {
            return new InsVatType {
                       Description = Description,
                       TaxCode = TaxCode,
                       Percent = Percent,
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
