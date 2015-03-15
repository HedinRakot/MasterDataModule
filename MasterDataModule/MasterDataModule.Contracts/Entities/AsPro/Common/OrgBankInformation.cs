using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class OrgBankInformation: IHasId<int>
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORG_BANK_INFORMATION";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'BANK_NAME' for property <see cref="OrgBankInformation.BankName"/>
            /// </summary>
            public static readonly string BankName = "BANK_NAME";
            /// <summary>
            /// Column name 'BANK_CODE' for property <see cref="OrgBankInformation.BankCode"/>
            /// </summary>
            public static readonly string BankCode = "BANK_CODE";
            /// <summary>
            /// Column name 'BANK_ACCOUNT' for property <see cref="OrgBankInformation.BankAccount"/>
            /// </summary>
            public static readonly string BankAccount = "BANK_ACCOUNT";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrgBankInformation.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrgBankInformation.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrgBankInformation.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrgBankInformation.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrgBankInformation.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrgBankInformation.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrgBankInformation.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrgBankInformation.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'TRANSFER_VALUE' for property <see cref="OrgBankInformation.TransferValue"/>
            /// </summary>
            public static readonly string TransferValue = "TRANSFER_VALUE";
            /// <summary>
            /// Column name 'TRANSFER_X_VALUE' for property <see cref="OrgBankInformation.TransferXValue"/>
            /// </summary>
            public static readonly string TransferXValue = "TRANSFER_X_VALUE";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrgBankInformation.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public string BankName{ get; set; }
        public string BankCode{ get; set; }
        public string BankAccount{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        public string TransferValue{ get; set; }
        public string TransferXValue{ get; set; }
        public int Id{ get; set; }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public OrgBankInformation ShallowCopy()
        {
            return new OrgBankInformation {
                       BankName = BankName,
                       BankCode = BankCode,
                       BankAccount = BankAccount,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       OwnerOrgId = OwnerOrgId,
                       VisibilityOrgId = VisibilityOrgId,
                       CreateEmployeeId = CreateEmployeeId,
                       ChangeEmployeeId = ChangeEmployeeId,
                       Source = Source,
                       TransferValue = TransferValue,
                       TransferXValue = TransferXValue,
        	           };
        }
    }
}
