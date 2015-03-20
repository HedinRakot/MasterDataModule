using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class OrdFederalState: IHasId<int>
        ,IHasTitle
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORD_FEDERAL_STATE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'FEDERAL_STATE_NAME' for property <see cref="OrdFederalState.FederalStateName"/>
            /// </summary>
            public static readonly string FederalStateName = "FEDERAL_STATE_NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="OrdFederalState.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'STATISTIK_KEY' for property <see cref="OrdFederalState.StatistikKey"/>
            /// </summary>
            public static readonly string StatistikKey = "STATISTIK_KEY";
            /// <summary>
            /// Column name 'SYS_COUNTRY_ID' for property <see cref="OrdFederalState.SysCountryId"/>
            /// </summary>
            public static readonly string SysCountryId = "SYS_COUNTRY_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrdFederalState.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrdFederalState.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrdFederalState.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrdFederalState.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrdFederalState.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrdFederalState.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrdFederalState.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrdFederalState.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="OrdFederalState.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="OrdFederalState.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrdFederalState.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public string FederalStateName{ get; set; }
        public string Description{ get; set; }
        public int? StatistikKey{ get; set; }
        public int? SysCountryId{ get; set; }
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
        string IHasTitle.EntityTitle
        {
            get { return FederalStateName; }
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
        public OrdFederalState ShallowCopy()
        {
            return new OrdFederalState {
                       FederalStateName = FederalStateName,
                       Description = Description,
                       StatistikKey = StatistikKey,
                       SysCountryId = SysCountryId,
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
