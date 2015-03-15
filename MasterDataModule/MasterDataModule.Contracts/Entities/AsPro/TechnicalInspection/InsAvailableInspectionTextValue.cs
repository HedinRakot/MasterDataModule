using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class InsAvailableInspectionTextValue: IHasId<int>
        ,IIntervalFields
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_AVAILABLE_INSPECTION_TEXT_VALUE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'INS_AVAILABLE_INSPECTION_TEXT_ID' for property <see cref="InsAvailableInspectionTextValue.InsAvailableInspectionTextId"/>
            /// </summary>
            public static readonly string InsAvailableInspectionTextId = "INS_AVAILABLE_INSPECTION_TEXT_ID";
            /// <summary>
            /// Column name 'SYS_LANGUAGE_ID' for property <see cref="InsAvailableInspectionTextValue.SysLanguageId"/>
            /// </summary>
            public static readonly string SysLanguageId = "SYS_LANGUAGE_ID";
            /// <summary>
            /// Column name 'TEXT' for property <see cref="InsAvailableInspectionTextValue.Text"/>
            /// </summary>
            public static readonly string Text = "TEXT";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsAvailableInspectionTextValue.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsAvailableInspectionTextValue.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsAvailableInspectionTextValue.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsAvailableInspectionTextValue.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsAvailableInspectionTextValue.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsAvailableInspectionTextValue.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsAvailableInspectionTextValue.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsAvailableInspectionTextValue.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsAvailableInspectionTextValue.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsAvailableInspectionTextValue.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsAvailableInspectionTextValue.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public int InsAvailableInspectionTextId{ get; set; }
        public int SysLanguageId{ get; set; }
        public string Text{ get; set; }
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
        public InsAvailableInspectionTextValue ShallowCopy()
        {
            return new InsAvailableInspectionTextValue {
                       InsAvailableInspectionTextId = InsAvailableInspectionTextId,
                       SysLanguageId = SysLanguageId,
                       Text = Text,
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
