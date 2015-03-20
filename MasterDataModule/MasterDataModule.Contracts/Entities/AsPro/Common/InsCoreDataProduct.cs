using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    public partial class InsCoreDataProduct: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.INS_CORE_DATA_PRODUCT";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'PRODUCT_NUMBER' for property <see cref="InsCoreDataProduct.ProductNumber"/>
            /// </summary>
            public static readonly string ProductNumber = "PRODUCT_NUMBER";
            /// <summary>
            /// Column name 'IS_NEXT_INSPECTION_PRODUCT' for property <see cref="InsCoreDataProduct.IsNextInspectionProduct"/>
            /// </summary>
            public static readonly string IsNextInspectionProduct = "IS_NEXT_INSPECTION_PRODUCT";
            /// <summary>
            /// Column name 'IS_PROVISION_COST_MAY_BE_CALCULATED' for property <see cref="InsCoreDataProduct.IsProvisionCostMayBeCalculated"/>
            /// </summary>
            public static readonly string IsProvisionCostMayBeCalculated = "IS_PROVISION_COST_MAY_BE_CALCULATED";
            /// <summary>
            /// Column name 'PRICE_REPORT_REQUIRED' for property <see cref="InsCoreDataProduct.PriceReportRequired"/>
            /// </summary>
            public static readonly string PriceReportRequired = "PRICE_REPORT_REQUIRED";
            /// <summary>
            /// Column name 'INS_PRODUCT_TYPE_ID' for property <see cref="InsCoreDataProduct.InsProductTypeId"/>
            /// </summary>
            public static readonly string InsProductTypeId = "INS_PRODUCT_TYPE_ID";
            /// <summary>
            /// Column name 'INS_PRODUCT_OBJECT_CLASS_ID' for property <see cref="InsCoreDataProduct.InsProductObjectClassId"/>
            /// </summary>
            public static readonly string InsProductObjectClassId = "INS_PRODUCT_OBJECT_CLASS_ID";
            /// <summary>
            /// Column name 'INS_PRODUCT_OBJECT_TYPE_ID' for property <see cref="InsCoreDataProduct.InsProductObjectTypeId"/>
            /// </summary>
            public static readonly string InsProductObjectTypeId = "INS_PRODUCT_OBJECT_TYPE_ID";
            /// <summary>
            /// Column name 'INS_PRODUCT_MATERIAL_GROUP_ID' for property <see cref="InsCoreDataProduct.InsProductMaterialGroupId"/>
            /// </summary>
            public static readonly string InsProductMaterialGroupId = "INS_PRODUCT_MATERIAL_GROUP_ID";
            /// <summary>
            /// Column name 'INS_PRODUCT_CLASS_ID' for property <see cref="InsCoreDataProduct.InsProductClassId"/>
            /// </summary>
            public static readonly string InsProductClassId = "INS_PRODUCT_CLASS_ID";
            /// <summary>
            /// Column name 'INS_CORE_DATA_PRODUCT_GROUP_ID' for property <see cref="InsCoreDataProduct.InsCoreDataProductGroupId"/>
            /// </summary>
            public static readonly string InsCoreDataProductGroupId = "INS_CORE_DATA_PRODUCT_GROUP_ID";
            /// <summary>
            /// Column name 'IS_INGENER' for property <see cref="InsCoreDataProduct.IsIngener"/>
            /// </summary>
            public static readonly string IsIngener = "IS_INGENER";
            /// <summary>
            /// Column name 'IS_PRODUCTIVE' for property <see cref="InsCoreDataProduct.IsProductive"/>
            /// </summary>
            public static readonly string IsProductive = "IS_PRODUCTIVE";
            /// <summary>
            /// Column name 'IS_KM_GELD' for property <see cref="InsCoreDataProduct.IsKmGeld"/>
            /// </summary>
            public static readonly string IsKmGeld = "IS_KM_GELD";
            /// <summary>
            /// Column name 'IS_OTHER_MATERIAL' for property <see cref="InsCoreDataProduct.IsOtherMaterial"/>
            /// </summary>
            public static readonly string IsOtherMaterial = "IS_OTHER_MATERIAL";
            /// <summary>
            /// Column name 'IS_TRIP' for property <see cref="InsCoreDataProduct.IsTrip"/>
            /// </summary>
            public static readonly string IsTrip = "IS_TRIP";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="InsCoreDataProduct.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="InsCoreDataProduct.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="InsCoreDataProduct.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="InsCoreDataProduct.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="InsCoreDataProduct.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="InsCoreDataProduct.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="InsCoreDataProduct.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="InsCoreDataProduct.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="InsCoreDataProduct.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="InsCoreDataProduct.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'REUSAGE_TYPE' for property <see cref="InsCoreDataProduct.ReusageType"/>
            /// </summary>
            public static readonly string ReusageType = "REUSAGE_TYPE";
            /// <summary>
            /// Column name 'INS_TAX_CODE_ID' for property <see cref="InsCoreDataProduct.InsTaxCodeId"/>
            /// </summary>
            public static readonly string InsTaxCodeId = "INS_TAX_CODE_ID";
            /// <summary>
            /// Column name 'OLD_PRODUCT_NUMBER' for property <see cref="InsCoreDataProduct.OldProductNumber"/>
            /// </summary>
            public static readonly string OldProductNumber = "OLD_PRODUCT_NUMBER";
            /// <summary>
            /// Column name 'ID' for property <see cref="InsCoreDataProduct.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        public string ProductNumber{ get; set; }
        public bool? IsNextInspectionProduct{ get; set; }
        public bool? IsProvisionCostMayBeCalculated{ get; set; }
        public bool? PriceReportRequired{ get; set; }
        public int InsProductTypeId{ get; set; }
        public int? InsProductObjectClassId{ get; set; }
        public int? InsProductObjectTypeId{ get; set; }
        public int? InsProductMaterialGroupId{ get; set; }
        public int? InsProductClassId{ get; set; }
        public int? InsCoreDataProductGroupId{ get; set; }
        public bool? IsIngener{ get; set; }
        public int IsProductive{ get; set; }
        public bool IsKmGeld{ get; set; }
        public bool IsOtherMaterial{ get; set; }
        public bool IsTrip{ get; set; }
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
        public int ReusageType{ get; set; }
        public int? InsTaxCodeId{ get; set; }
        public string OldProductNumber{ get; set; }
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
        public InsCoreDataProduct ShallowCopy()
        {
            return new InsCoreDataProduct {
                       ProductNumber = ProductNumber,
                       IsNextInspectionProduct = IsNextInspectionProduct,
                       IsProvisionCostMayBeCalculated = IsProvisionCostMayBeCalculated,
                       PriceReportRequired = PriceReportRequired,
                       InsProductTypeId = InsProductTypeId,
                       InsProductObjectClassId = InsProductObjectClassId,
                       InsProductObjectTypeId = InsProductObjectTypeId,
                       InsProductMaterialGroupId = InsProductMaterialGroupId,
                       InsProductClassId = InsProductClassId,
                       InsCoreDataProductGroupId = InsCoreDataProductGroupId,
                       IsIngener = IsIngener,
                       IsProductive = IsProductive,
                       IsKmGeld = IsKmGeld,
                       IsOtherMaterial = IsOtherMaterial,
                       IsTrip = IsTrip,
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
                       ReusageType = ReusageType,
                       InsTaxCodeId = InsTaxCodeId,
                       OldProductNumber = OldProductNumber,
        	           };
        }
    }
}
