using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class OrgInspectionDevice: IHasId<int>
        ,IRemovable
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORG_INSPECTION_DEVICE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'DEBITOR_CUSTOMER_NUMBER' for property <see cref="OrgInspectionDevice.DebitorCustomerNumber"/>
            /// </summary>
            public static readonly string DebitorCustomerNumber = "DEBITOR_CUSTOMER_NUMBER";
            /// <summary>
            /// Column name 'IDENTIFICATION' for property <see cref="OrgInspectionDevice.Identification"/>
            /// </summary>
            public static readonly string Identification = "IDENTIFICATION";
            /// <summary>
            /// Column name 'NEW_IDENTIFICATION' for property <see cref="OrgInspectionDevice.NewIdentification"/>
            /// </summary>
            public static readonly string NewIdentification = "NEW_IDENTIFICATION";
            /// <summary>
            /// Column name 'OLD_IDENTIFICATION' for property <see cref="OrgInspectionDevice.OldIdentification"/>
            /// </summary>
            public static readonly string OldIdentification = "OLD_IDENTIFICATION";
            /// <summary>
            /// Column name 'TYPE' for property <see cref="OrgInspectionDevice.Type"/>
            /// </summary>
            public static readonly string Type = "TYPE";
            /// <summary>
            /// Column name 'SERIAL_NUMBER' for property <see cref="OrgInspectionDevice.SerialNumber"/>
            /// </summary>
            public static readonly string SerialNumber = "SERIAL_NUMBER";
            /// <summary>
            /// Column name 'NAME' for property <see cref="OrgInspectionDevice.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="OrgInspectionDevice.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'LAST_INSPECTION_DATE' for property <see cref="OrgInspectionDevice.LastInspectionDate"/>
            /// </summary>
            public static readonly string LastInspectionDate = "LAST_INSPECTION_DATE";
            /// <summary>
            /// Column name 'LAST_INSPECTION_RESULT' for property <see cref="OrgInspectionDevice.LastInspectionResult"/>
            /// </summary>
            public static readonly string LastInspectionResult = "LAST_INSPECTION_RESULT";
            /// <summary>
            /// Column name 'INSPECTION_DATE' for property <see cref="OrgInspectionDevice.InspectionDate"/>
            /// </summary>
            public static readonly string InspectionDate = "INSPECTION_DATE";
            /// <summary>
            /// Column name 'INSPECTION_INTERVAL' for property <see cref="OrgInspectionDevice.InspectionInterval"/>
            /// </summary>
            public static readonly string InspectionInterval = "INSPECTION_INTERVAL";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrgInspectionDevice.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrgInspectionDevice.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrgInspectionDevice.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrgInspectionDevice.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrgInspectionDevice.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrgInspectionDevice.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrgInspectionDevice.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrgInspectionDevice.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrgInspectionDevice.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public string DebitorCustomerNumber{ get; set; }
        public string Identification{ get; set; }
        public string NewIdentification{ get; set; }
        public string OldIdentification{ get; set; }
        public string Type{ get; set; }
        public string SerialNumber{ get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public DateTime? LastInspectionDate{ get; set; }
        public string LastInspectionResult{ get; set; }
        public DateTime? InspectionDate{ get; set; }
        public int? InspectionInterval{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        public int Id{ get; set; }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public OrgInspectionDevice ShallowCopy()
        {
            return new OrgInspectionDevice {
                       DebitorCustomerNumber = DebitorCustomerNumber,
                       Identification = Identification,
                       NewIdentification = NewIdentification,
                       OldIdentification = OldIdentification,
                       Type = Type,
                       SerialNumber = SerialNumber,
                       Name = Name,
                       Description = Description,
                       LastInspectionDate = LastInspectionDate,
                       LastInspectionResult = LastInspectionResult,
                       InspectionDate = InspectionDate,
                       InspectionInterval = InspectionInterval,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       OwnerOrgId = OwnerOrgId,
                       VisibilityOrgId = VisibilityOrgId,
                       CreateEmployeeId = CreateEmployeeId,
                       ChangeEmployeeId = ChangeEmployeeId,
                       Source = Source,
        	           };
        }
    }
}
