using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Auszahlungsgrund  EN: Expense ground
    /// </summary>
    public partial class KssExpenseGround: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.KSS_EXPENSE_GROUND";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="KssExpenseGround.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'ACCOUNT' for property <see cref="KssExpenseGround.Account"/>
            /// </summary>
            public static readonly string Account = "ACCOUNT";
            /// <summary>
            /// Column name 'INS_VAT_TYPE_ID' for property <see cref="KssExpenseGround.InsVatTypeId"/>
            /// </summary>
            public static readonly string InsVatTypeId = "INS_VAT_TYPE_ID";
            /// <summary>
            /// Column name 'MAX_AMOUNT' for property <see cref="KssExpenseGround.MaxAmount"/>
            /// </summary>
            public static readonly string MaxAmount = "MAX_AMOUNT";
            /// <summary>
            /// Column name 'PAYER' for property <see cref="KssExpenseGround.Payer"/>
            /// </summary>
            public static readonly string Payer = "PAYER";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="KssExpenseGround.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="KssExpenseGround.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="KssExpenseGround.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="KssExpenseGround.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="KssExpenseGround.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="KssExpenseGround.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="KssExpenseGround.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="KssExpenseGround.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="KssExpenseGround.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="KssExpenseGround.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="KssExpenseGround.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     DE: Auszahlungsgrund  EN: Description
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        ///     DE: Kostenstelle  EN: Account
        /// </summary>
        public string Account{ get; set; }
        /// <summary>
        ///     DE: Mehrwertsteuerkennzeichen   EN: Vat type
        /// </summary>
        public int? InsVatTypeId{ get; set; }
        /// <summary>
        ///     DE: Maximaler Auszahlungsbetrag  EN: Max amount
        /// </summary>
        public decimal? MaxAmount{ get; set; }
        /// <summary>
        ///     DE: ???  EN: 
        /// </summary>
        public string Payer{ get; set; }
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
        public KssExpenseGround ShallowCopy()
        {
            return new KssExpenseGround {
                       Description = Description,
                       Account = Account,
                       InsVatTypeId = InsVatTypeId,
                       MaxAmount = MaxAmount,
                       Payer = Payer,
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
