using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Zuordnung Verfügbarer Prüfschritt zu Prüfschritt  EN: Available inspection step
    /// </summary>
    public partial class InsAvailableInspectionStep: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_AVAILABLE_INSPECTION_STEP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'INS_INSPECTION_STEP_ID' for property <see cref="InsAvailableInspectionStep.InsInspectionStepId"/>
            /// </summary>
            public static readonly string InsInspectionStepId = "INS_INSPECTION_STEP_ID";
            /// <summary>
            /// Column name 'IS_MANDATORY' for property <see cref="InsAvailableInspectionStep.IsMandatory"/>
            /// </summary>
            public static readonly string IsMandatory = "IS_MANDATORY";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsAvailableInspectionStep.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsAvailableInspectionStep.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsAvailableInspectionStep.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsAvailableInspectionStep.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsAvailableInspectionStep.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsAvailableInspectionStep.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsAvailableInspectionStep.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsAvailableInspectionStep.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsAvailableInspectionStep.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsAvailableInspectionStep.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsAvailableInspectionStep.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     DE: Beschreibung des Prüfschritts   EN: Description
        /// </summary>
        public int InsInspectionStepId{ get; set; }
        /// <summary>
        ///     DE: Angabe, ob Prüfschritt ein Pflichtprüfschritt ist  EN: Is mandatory
        /// </summary>
        public bool IsMandatory{ get; set; }
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
        public InsAvailableInspectionStep ShallowCopy()
        {
            return new InsAvailableInspectionStep {
                       InsInspectionStepId = InsInspectionStepId,
                       IsMandatory = IsMandatory,
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
