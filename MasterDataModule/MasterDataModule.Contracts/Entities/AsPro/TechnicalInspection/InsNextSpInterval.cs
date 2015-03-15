using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class InsNextSpInterval: IHasId<int>
        ,IIntervalFields
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_NEXT_SP_INTERVAL";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'INS_PRODUCT_OBJECT_TYPE_ID' for property <see cref="InsNextSpInterval.InsProductObjectTypeId"/>
            /// </summary>
            public static readonly string InsProductObjectTypeId = "INS_PRODUCT_OBJECT_TYPE_ID";
            /// <summary>
            /// Column name 'INS_PRODUCT_OBJECT_CLASS_ID' for property <see cref="InsNextSpInterval.InsProductObjectClassId"/>
            /// </summary>
            public static readonly string InsProductObjectClassId = "INS_PRODUCT_OBJECT_CLASS_ID";
            /// <summary>
            /// Column name 'AGE_MONTH_FROM' for property <see cref="InsNextSpInterval.AgeMonthFrom"/>
            /// </summary>
            public static readonly string AgeMonthFrom = "AGE_MONTH_FROM";
            /// <summary>
            /// Column name 'AGE_MONTH_TO' for property <see cref="InsNextSpInterval.AgeMonthTo"/>
            /// </summary>
            public static readonly string AgeMonthTo = "AGE_MONTH_TO";
            /// <summary>
            /// Column name 'SP_INTERVAL' for property <see cref="InsNextSpInterval.SpInterval"/>
            /// </summary>
            public static readonly string SpInterval = "SP_INTERVAL";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsNextSpInterval.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsNextSpInterval.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsNextSpInterval.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsNextSpInterval.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsNextSpInterval.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsNextSpInterval.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsNextSpInterval.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsNextSpInterval.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsNextSpInterval.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsNextSpInterval.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsNextSpInterval.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int InsProductObjectTypeId{ get; set; }
        public int InsProductObjectClassId{ get; set; }
        public int AgeMonthFrom{ get; set; }
        public int? AgeMonthTo{ get; set; }
        public int SpInterval{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        public int Id{ get; set; }
        public DateTime FromDate{ get; set; }
        public DateTime ToDate{ get; set; }
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
        public InsNextSpInterval ShallowCopy()
        {
            return new InsNextSpInterval {
                       InsProductObjectTypeId = InsProductObjectTypeId,
                       InsProductObjectClassId = InsProductObjectClassId,
                       AgeMonthFrom = AgeMonthFrom,
                       AgeMonthTo = AgeMonthTo,
                       SpInterval = SpInterval,
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
