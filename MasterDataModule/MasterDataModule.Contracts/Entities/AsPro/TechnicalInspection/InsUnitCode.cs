using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class InsUnitCode: IHasId<int>
        ,IIntervalFields
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_UNIT_CODE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ORG_ACCOUNTING_AREA_ID' for property <see cref="InsUnitCode.OrgAccountingAreaId"/>
            /// </summary>
            public static readonly string OrgAccountingAreaId = "ORG_ACCOUNTING_AREA_ID";
            /// <summary>
            /// Column name 'ORD_FEDERAL_STATE_ID' for property <see cref="InsUnitCode.OrdFederalStateId"/>
            /// </summary>
            public static readonly string OrdFederalStateId = "ORD_FEDERAL_STATE_ID";
            /// <summary>
            /// Column name 'ORD_AREA_OF_WORK_ID' for property <see cref="InsUnitCode.OrdAreaOfWorkId"/>
            /// </summary>
            public static readonly string OrdAreaOfWorkId = "ORD_AREA_OF_WORK_ID";
            /// <summary>
            /// Column name 'UNIT_CODE' for property <see cref="InsUnitCode.UnitCode"/>
            /// </summary>
            public static readonly string UnitCode = "UNIT_CODE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsUnitCode.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsUnitCode.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsUnitCode.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsUnitCode.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsUnitCode.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsUnitCode.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsUnitCode.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsUnitCode.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsUnitCode.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsUnitCode.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsUnitCode.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public int OrgAccountingAreaId{ get; set; }
        public int OrdFederalStateId{ get; set; }
        public int OrdAreaOfWorkId{ get; set; }
        public string UnitCode{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        public DateTime FromDate{ get; set; }
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
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public InsUnitCode ShallowCopy()
        {
            return new InsUnitCode {
                       OrgAccountingAreaId = OrgAccountingAreaId,
                       OrdFederalStateId = OrdFederalStateId,
                       OrdAreaOfWorkId = OrdAreaOfWorkId,
                       UnitCode = UnitCode,
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
