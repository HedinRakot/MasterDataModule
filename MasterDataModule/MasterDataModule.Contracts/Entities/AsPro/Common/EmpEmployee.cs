using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class EmpEmployee: IHasId<int>
        ,IIntervalFields
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.EMP_EMPLOYEE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'PERSONAL_NUMBER' for property <see cref="EmpEmployee.PersonalNumber"/>
            /// </summary>
            public static readonly string PersonalNumber = "PERSONAL_NUMBER";
            /// <summary>
            /// Column name 'DOMAIN' for property <see cref="EmpEmployee.Domain"/>
            /// </summary>
            public static readonly string Domain = "DOMAIN";
            /// <summary>
            /// Column name 'USER_NAME' for property <see cref="EmpEmployee.UserName"/>
            /// </summary>
            public static readonly string UserName = "USER_NAME";
            /// <summary>
            /// Column name 'WINDOWS_USER_NAME' for property <see cref="EmpEmployee.WindowsUserName"/>
            /// </summary>
            public static readonly string WindowsUserName = "WINDOWS_USER_NAME";
            /// <summary>
            /// Column name 'IS_SSO_ALLOWED' for property <see cref="EmpEmployee.IsSsoAllowed"/>
            /// </summary>
            public static readonly string IsSsoAllowed = "IS_SSO_ALLOWED";
            /// <summary>
            /// Column name 'IS_PASSWORD_LOGIN_ALLOWED' for property <see cref="EmpEmployee.IsPasswordLoginAllowed"/>
            /// </summary>
            public static readonly string IsPasswordLoginAllowed = "IS_PASSWORD_LOGIN_ALLOWED";
            /// <summary>
            /// Column name 'IS_EMERGENCY_LOGIN_ALLOWED' for property <see cref="EmpEmployee.IsEmergencyLoginAllowed"/>
            /// </summary>
            public static readonly string IsEmergencyLoginAllowed = "IS_EMERGENCY_LOGIN_ALLOWED";
            /// <summary>
            /// Column name 'EMP_CORE_ADDRESS_ID' for property <see cref="EmpEmployee.EmpCoreAddressId"/>
            /// </summary>
            public static readonly string EmpCoreAddressId = "EMP_CORE_ADDRESS_ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="EmpEmployee.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'MIDDLE_NAME' for property <see cref="EmpEmployee.MiddleName"/>
            /// </summary>
            public static readonly string MiddleName = "MIDDLE_NAME";
            /// <summary>
            /// Column name 'LAST_NAME' for property <see cref="EmpEmployee.LastName"/>
            /// </summary>
            public static readonly string LastName = "LAST_NAME";
            /// <summary>
            /// Column name 'COMMENT' for property <see cref="EmpEmployee.Comment"/>
            /// </summary>
            public static readonly string Comment = "COMMENT";
            /// <summary>
            /// Column name 'SEX_TYPE' for property <see cref="EmpEmployee.SexType"/>
            /// </summary>
            public static readonly string SexType = "SEX_TYPE";
            /// <summary>
            /// Column name 'TITLE' for property <see cref="EmpEmployee.Title"/>
            /// </summary>
            public static readonly string Title = "TITLE";
            /// <summary>
            /// Column name 'BIRTHDATE' for property <see cref="EmpEmployee.Birthdate"/>
            /// </summary>
            public static readonly string Birthdate = "BIRTHDATE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="EmpEmployee.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="EmpEmployee.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="EmpEmployee.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="EmpEmployee.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="EmpEmployee.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="EmpEmployee.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="EmpEmployee.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="EmpEmployee.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="EmpEmployee.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="EmpEmployee.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="EmpEmployee.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public string PersonalNumber{ get; set; }
        public string Domain{ get; set; }
        public string UserName{ get; set; }
        public string WindowsUserName{ get; set; }
        public bool? IsSsoAllowed{ get; set; }
        public bool? IsPasswordLoginAllowed{ get; set; }
        public bool? IsEmergencyLoginAllowed{ get; set; }
        public int? EmpCoreAddressId{ get; set; }
        public string Name{ get; set; }
        public string MiddleName{ get; set; }
        public string LastName{ get; set; }
        public string Comment{ get; set; }
        public int? SexType{ get; set; }
        public string Title{ get; set; }
        public DateTime Birthdate{ get; set; }
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
        public EmpEmployee ShallowCopy()
        {
            return new EmpEmployee {
                       PersonalNumber = PersonalNumber,
                       Domain = Domain,
                       UserName = UserName,
                       WindowsUserName = WindowsUserName,
                       IsSsoAllowed = IsSsoAllowed,
                       IsPasswordLoginAllowed = IsPasswordLoginAllowed,
                       IsEmergencyLoginAllowed = IsEmergencyLoginAllowed,
                       EmpCoreAddressId = EmpCoreAddressId,
                       Name = Name,
                       MiddleName = MiddleName,
                       LastName = LastName,
                       Comment = Comment,
                       SexType = SexType,
                       Title = Title,
                       Birthdate = Birthdate,
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
