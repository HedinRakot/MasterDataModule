using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Zuordnung PFP-Prüfpositionen zu PFP-Baugruppe  EN: PFP inspection type to position
    /// </summary>
    public partial class InsPfpInspectionTypePfpPositionRsp: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'INS_PFP_POSITION_ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.InsPfpPositionId"/>
            /// </summary>
            public static readonly string InsPfpPositionId = "INS_PFP_POSITION_ID";
            /// <summary>
            /// Column name 'INS_PFP_INSPECTION_TYPE_ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.InsPfpInspectionTypeId"/>
            /// </summary>
            public static readonly string InsPfpInspectionTypeId = "INS_PFP_INSPECTION_TYPE_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsPfpInspectionTypePfpPositionRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsPfpInspectionTypePfpPositionRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsPfpInspectionTypePfpPositionRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsPfpInspectionTypePfpPositionRsp.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsPfpInspectionTypePfpPositionRsp.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsPfpInspectionTypePfpPositionRsp.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsPfpInspectionTypePfpPositionRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     DE: PFP-Prüfposition   EN: Position
        /// </summary>
        public int InsPfpPositionId{ get; set; }
        /// <summary>
        ///     DE: PFP-Baugruppe   EN: Inspection type
        /// </summary>
        public int InsPfpInspectionTypeId{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
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
        public InsPfpInspectionTypePfpPositionRsp ShallowCopy()
        {
            return new InsPfpInspectionTypePfpPositionRsp {
                       InsPfpPositionId = InsPfpPositionId,
                       InsPfpInspectionTypeId = InsPfpInspectionTypeId,
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
