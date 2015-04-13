using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Stammdaten Berechtigung  EN: Master data permissiom
    /// </summary>
    public partial class MasterDataRolePermissionRsp: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_ROLE_PERMISSION_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataRolePermissionRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'MASTER_DATA_ROLE_ID' for property <see cref="MasterDataRolePermissionRsp.MasterDataRoleId"/>
            /// </summary>
            public static readonly string MasterDataRoleId = "MASTER_DATA_ROLE_ID";
            /// <summary>
            /// Column name 'MASTER_DATA_PERMISSION_ID' for property <see cref="MasterDataRolePermissionRsp.MasterDataPermissionId"/>
            /// </summary>
            public static readonly string MasterDataPermissionId = "MASTER_DATA_PERMISSION_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataRolePermissionRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataRolePermissionRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataRolePermissionRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="MasterDataRolePermissionRsp.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="MasterDataRolePermissionRsp.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="MasterDataRolePermissionRsp.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="MasterDataRolePermissionRsp.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="MasterDataRolePermissionRsp.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataRolePermissionRsp.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataRolePermissionRsp.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Rolle  EN: Master data role
        /// </summary>
        public int MasterDataRoleId{ get; set; }
        /// <summary>
        ///     DE: Berechtigung  EN: Master data permission
        /// </summary>
        public int MasterDataPermissionId{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
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
        public virtual Permission Permission{ get; set; }
        public virtual Role Role{ get; set; }
        public bool HasPermission
        {
            get { return !ReferenceEquals(Permission, null); }
        }
        public bool HasRole
        {
            get { return !ReferenceEquals(Role, null); }
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
        public MasterDataRolePermissionRsp ShallowCopy()
        {
            return new MasterDataRolePermissionRsp {
                       MasterDataRoleId = MasterDataRoleId,
                       MasterDataPermissionId = MasterDataPermissionId,
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
