using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class OrgAccountingArea: IHasId<int>
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORG_ACCOUNTING_AREA";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="OrgAccountingArea.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'ACCOUNTING_AREA' for property <see cref="OrgAccountingArea.AccountingArea"/>
            /// </summary>
            public static readonly string AccountingArea = "ACCOUNTING_AREA";
            /// <summary>
            /// Column name 'MAX_ORDER_SUM' for property <see cref="OrgAccountingArea.MaxOrderSum"/>
            /// </summary>
            public static readonly string MaxOrderSum = "MAX_ORDER_SUM";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrgAccountingArea.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrgAccountingArea.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrgAccountingArea.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrgAccountingArea.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrgAccountingArea.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrgAccountingArea.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrgAccountingArea.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrgAccountingArea.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
          
        }
        #endregion
        public int Id{ get; set; }
        public string AccountingArea{ get; set; }
        public decimal MaxOrderSum{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public OrgAccountingArea ShallowCopy()
        {
            return new OrgAccountingArea {
                       AccountingArea = AccountingArea,
                       MaxOrderSum = MaxOrderSum,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       OwnerOrgId = OwnerOrgId,
                       VisibilityOrgId = VisibilityOrgId,
                       CreateEmployeeId = CreateEmployeeId,
                       ChangeEmployeeId = ChangeEmployeeId,
                       Source = Source,
        	           };
        }
    }
}