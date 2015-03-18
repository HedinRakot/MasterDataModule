using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class EmpEmployeeOrgOrganizationalUnitRsp: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'EMP_EMPLOYEE_ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.EmpEmployeeId"/>
            /// </summary>
            public static readonly string EmpEmployeeId = "EMP_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'ORG_ORGANIZATIONAL_UNIT_ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.OrgOrganizationalUnitId"/>
            /// </summary>
            public static readonly string OrgOrganizationalUnitId = "ORG_ORGANIZATIONAL_UNIT_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="EmpEmployeeOrgOrganizationalUnitRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public int EmpEmployeeId{ get; set; }
        public int OrgOrganizationalUnitId{ get; set; }
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
        public EmpEmployeeOrgOrganizationalUnitRsp ShallowCopy()
        {
            return new EmpEmployeeOrgOrganizationalUnitRsp {
                       EmpEmployeeId = EmpEmployeeId,
                       OrgOrganizationalUnitId = OrgOrganizationalUnitId,
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
