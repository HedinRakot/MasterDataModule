using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class OrdRecognitionAreaOfWorkRsp: IHasId<int>
        ,IIntervalFields
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORD_RECOGNITION_AREA_OF_WORK_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ORD_RECOGNITION_ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.OrdRecognitionId"/>
            /// </summary>
            public static readonly string OrdRecognitionId = "ORD_RECOGNITION_ID";
            /// <summary>
            /// Column name 'ORD_AREA_OF_WORK_ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.OrdAreaOfWorkId"/>
            /// </summary>
            public static readonly string OrdAreaOfWorkId = "ORD_AREA_OF_WORK_ID";
            /// <summary>
            /// Column name 'PRIORITY' for property <see cref="OrdRecognitionAreaOfWorkRsp.Priority"/>
            /// </summary>
            public static readonly string Priority = "PRIORITY";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrdRecognitionAreaOfWorkRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrdRecognitionAreaOfWorkRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrdRecognitionAreaOfWorkRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrdRecognitionAreaOfWorkRsp.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="OrdRecognitionAreaOfWorkRsp.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="OrdRecognitionAreaOfWorkRsp.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrdRecognitionAreaOfWorkRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public int OrdRecognitionId{ get; set; }
        public int OrdAreaOfWorkId{ get; set; }
        public int Priority{ get; set; }
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
        public OrdRecognitionAreaOfWorkRsp ShallowCopy()
        {
            return new OrdRecognitionAreaOfWorkRsp {
                       OrdRecognitionId = OrdRecognitionId,
                       OrdAreaOfWorkId = OrdAreaOfWorkId,
                       Priority = Priority,
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
