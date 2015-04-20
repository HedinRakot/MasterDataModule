using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Lokalisierung  EN: Localization
    /// </summary>
    public partial class InsCoreDataProductLocalization: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_CORE_DATA_PRODUCT_LOCALIZATION";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'INS_CORE_DATA_PRODUCT_ID' for property <see cref="InsCoreDataProductLocalization.InsCoreDataProductId"/>
            /// </summary>
            public static readonly string InsCoreDataProductId = "INS_CORE_DATA_PRODUCT_ID";
            /// <summary>
            /// Column name 'SYS_LANGUAGE_ID' for property <see cref="InsCoreDataProductLocalization.SysLanguageId"/>
            /// </summary>
            public static readonly string SysLanguageId = "SYS_LANGUAGE_ID";
            /// <summary>
            /// Column name 'PRODUCT_NAME' for property <see cref="InsCoreDataProductLocalization.ProductName"/>
            /// </summary>
            public static readonly string ProductName = "PRODUCT_NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="InsCoreDataProductLocalization.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsCoreDataProductLocalization.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsCoreDataProductLocalization.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsCoreDataProductLocalization.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsCoreDataProductLocalization.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsCoreDataProductLocalization.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsCoreDataProductLocalization.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsCoreDataProductLocalization.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsCoreDataProductLocalization.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsCoreDataProductLocalization.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsCoreDataProductLocalization.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsCoreDataProductLocalization.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     DE: Produkt  EN: Product
        /// </summary>
        public int InsCoreDataProductId{ get; set; }
        /// <summary>
        ///     DE: Sprachschlüssel   EN: Language
        /// </summary>
        public int SysLanguageId{ get; set; }
        /// <summary>
        ///     DE: Name  EN: Name
        /// </summary>
        public string ProductName{ get; set; }
        /// <summary>
        ///     DE: Bescreibung  EN: Description
        /// </summary>
        public string Description{ get; set; }
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
        public InsCoreDataProductLocalization ShallowCopy()
        {
            return new InsCoreDataProductLocalization {
                       InsCoreDataProductId = InsCoreDataProductId,
                       SysLanguageId = SysLanguageId,
                       ProductName = ProductName,
                       Description = Description,
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
