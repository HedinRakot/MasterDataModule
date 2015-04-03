






using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using System.Data.Entity;
using System.Linq;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Database context for for AsPro
    /// </summary>
    public partial class AsProEntities: IAsProEntities
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(InsNextSpIntervalMapping.Instance);
            modelBuilder.Configurations.Add(InsObdStatusMapping.Instance);
            modelBuilder.Configurations.Add(InsOpticalDefectMapping.Instance);
            modelBuilder.Configurations.Add(InsProductClassGroupMapping.Instance);
            modelBuilder.Configurations.Add(InsSeverityTypeMapping.Instance);
            modelBuilder.Configurations.Add(SysLanguageMapping.Instance);
            modelBuilder.Configurations.Add(InsValidPeriodMapping.Instance);
            modelBuilder.Configurations.Add(InsCoreDataProductMapping.Instance);
            modelBuilder.Configurations.Add(InsPfpPositionMapping.Instance);
            modelBuilder.Configurations.Add(InsPfpInspectionTypePfpPositionRspMapping.Instance);
            modelBuilder.Configurations.Add(InsCoreDataProductLocalizationMapping.Instance);
            modelBuilder.Configurations.Add(InsPfpVehicleTypeMapping.Instance);
            modelBuilder.Configurations.Add(EmpEmployeeMapping.Instance);
            modelBuilder.Configurations.Add(InsUnitCodeMapping.Instance);
            modelBuilder.Configurations.Add(SysLocationMapping.Instance);
            modelBuilder.Configurations.Add(SysRoleMapping.Instance);
            modelBuilder.Configurations.Add(EmpCashPermissionTypeMapping.Instance);
            modelBuilder.Configurations.Add(SysRoleSysPermissionRspMapping.Instance);
            modelBuilder.Configurations.Add(EmpOrgAssociationTypeMapping.Instance);
            modelBuilder.Configurations.Add(OrgAccountTypeMapping.Instance);
            modelBuilder.Configurations.Add(InsAvailableInspectionTextMapping.Instance);
            modelBuilder.Configurations.Add(OrgAccountingAreaMapping.Instance);
            modelBuilder.Configurations.Add(InsAvailableInspectionTextValueMapping.Instance);
            modelBuilder.Configurations.Add(OrgBankInformationMapping.Instance);
            modelBuilder.Configurations.Add(OrgCostCenterMapping.Instance);
            modelBuilder.Configurations.Add(OrdFederalGroupMapping.Instance);
            modelBuilder.Configurations.Add(OrgCostCenterResponsibleEmployeeRspMapping.Instance);
            modelBuilder.Configurations.Add(OrdFederalStateMapping.Instance);
            modelBuilder.Configurations.Add(OrgCostCenterPriceMapping.Instance);
            modelBuilder.Configurations.Add(SysCountryMapping.Instance);
            modelBuilder.Configurations.Add(SysPostCodeMapping.Instance);
            modelBuilder.Configurations.Add(OrdOrderCancelationReasonMapping.Instance);
            modelBuilder.Configurations.Add(OrgRelationshipTypeMapping.Instance);
            modelBuilder.Configurations.Add(KssExpenseGroundMapping.Instance);
            modelBuilder.Configurations.Add(OrgInformationMapping.Instance);
            modelBuilder.Configurations.Add(ExpPassengersTypeMapping.Instance);
            modelBuilder.Configurations.Add(OrgTypeMapping.Instance);
            modelBuilder.Configurations.Add(InsVatTypeMapping.Instance);
            modelBuilder.Configurations.Add(OrgInspectionDeviceMapping.Instance);
            modelBuilder.Configurations.Add(EmpEmployeeOrgCostCenterRspMapping.Instance);
            modelBuilder.Configurations.Add(OrdBillingParameterMapping.Instance);
            modelBuilder.Configurations.Add(EmpEmployeeOrgOrganizationalUnitRspMapping.Instance);
            modelBuilder.Configurations.Add(OrdContactPersonFunctionMapping.Instance);
            modelBuilder.Configurations.Add(EmpEmployeeTopEmployeeRspMapping.Instance);
            modelBuilder.Configurations.Add(OrdCustomerInfoMapping.Instance);
            modelBuilder.Configurations.Add(EmpEmployeeSysRoleRspMapping.Instance);
            modelBuilder.Configurations.Add(OrdPartnerRoleMapping.Instance);
            modelBuilder.Configurations.Add(InsTaxClassMapping.Instance);
            modelBuilder.Configurations.Add(InsCoreDataProductGroupMapping.Instance);
            modelBuilder.Configurations.Add(InsProductCombinationTypeMapping.Instance);
            modelBuilder.Configurations.Add(InsProductMaterialGroupMapping.Instance);
            modelBuilder.Configurations.Add(InsProductObjectClassMapping.Instance);
            modelBuilder.Configurations.Add(InsProductObjectTypeMapping.Instance);
            modelBuilder.Configurations.Add(OrgOrganizationalUnitMapping.Instance);
            modelBuilder.Configurations.Add(InsProductTypeMapping.Instance);
            modelBuilder.Configurations.Add(InsStatisticGroupMapping.Instance);
            modelBuilder.Configurations.Add(OrdAreaOfWorkMapping.Instance);
            modelBuilder.Configurations.Add(OrdRecognitionTypeMapping.Instance);
            modelBuilder.Configurations.Add(OrdRecognitionMapping.Instance);
            modelBuilder.Configurations.Add(OrdRecognitionAreaOfWorkRspMapping.Instance);
            modelBuilder.Configurations.Add(InsTaxCodeMapping.Instance);
            modelBuilder.Configurations.Add(InsInspectionStepMapping.Instance);
            modelBuilder.Configurations.Add(InsAvailableInspectionStepMapping.Instance);
            modelBuilder.Configurations.Add(InsSummaryFieldMapping.Instance);
            modelBuilder.Configurations.Add(InsNextInspectionMapping.Instance);
        }

        /// <summary>
        ///     Set of <see cref="InsNextSpInterval"/> entities from table dbo.INS_NEXT_SP_INTERVAL
        /// </summary>
        public IQueryable<InsNextSpInterval> InsNextSpInterval{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsObdStatus"/> entities from table dbo.INS_OBD_STATUS
        /// </summary>
        public IQueryable<InsObdStatus> InsObdStatus{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsOpticalDefect"/> entities from table dbo.INS_OPTICAL_DEFECT
        /// </summary>
        public IQueryable<InsOpticalDefect> InsOpticalDefect{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsProductClassGroup"/> entities from table dbo.INS_PRODUCT_CLASS_GROUP
        /// </summary>
        public IQueryable<InsProductClassGroup> InsProductClassGroup{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsSeverityType"/> entities from table dbo.INS_SEVERITY_TYPE
        /// </summary>
        public IQueryable<InsSeverityType> InsSeverityType{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysLanguage"/> entities from table dbo.SYS_LANGUAGE
        /// </summary>
        public IQueryable<SysLanguage> SysLanguage{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsValidPeriod"/> entities from table dbo.INS_VALID_PERIOD
        /// </summary>
        public IQueryable<InsValidPeriod> InsValidPeriod{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsCoreDataProduct"/> entities from table dbo.INS_CORE_DATA_PRODUCT
        /// </summary>
        public IQueryable<InsCoreDataProduct> InsCoreDataProduct{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsPfpPosition"/> entities from table dbo.INS_PFP_POSITION
        /// </summary>
        public IQueryable<InsPfpPosition> InsPfpPosition{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsPfpInspectionTypePfpPositionRsp"/> entities from table dbo.INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP
        /// </summary>
        public IQueryable<InsPfpInspectionTypePfpPositionRsp> InsPfpInspectionTypePfpPositionRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsCoreDataProductLocalization"/> entities from table dbo.INS_CORE_DATA_PRODUCT_LOCALIZATION
        /// </summary>
        public IQueryable<InsCoreDataProductLocalization> InsCoreDataProductLocalization{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsPfpVehicleType"/> entities from table dbo.INS_PFP_VEHICLE_TYPE
        /// </summary>
        public IQueryable<InsPfpVehicleType> InsPfpVehicleType{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpEmployee"/> entities from table dbo.EMP_EMPLOYEE
        /// </summary>
        public IQueryable<EmpEmployee> EmpEmployee{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsUnitCode"/> entities from table dbo.INS_UNIT_CODE
        /// </summary>
        public IQueryable<InsUnitCode> InsUnitCode{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysLocation"/> entities from table dbo.SYS_LOCATION
        /// </summary>
        public IQueryable<SysLocation> SysLocation{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysRole"/> entities from table dbo.SYS_ROLE
        /// </summary>
        public IQueryable<SysRole> SysRole{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpCashPermissionType"/> entities from table dbo.EMP_CASH_PERMISSION_TYPE
        /// </summary>
        public IQueryable<EmpCashPermissionType> EmpCashPermissionType{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysRoleSysPermissionRsp"/> entities from table dbo.SYS_ROLE_SYS_PERMISSION_RSP
        /// </summary>
        public IQueryable<SysRoleSysPermissionRsp> SysRoleSysPermissionRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpOrgAssociationType"/> entities from table dbo.EMP_ORG_ASSOCIATION_TYPE
        /// </summary>
        public IQueryable<EmpOrgAssociationType> EmpOrgAssociationType{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgAccountType"/> entities from table dbo.ORG_ACCOUNT_TYPE
        /// </summary>
        public IQueryable<OrgAccountType> OrgAccountType{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsAvailableInspectionText"/> entities from table dbo.INS_AVAILABLE_INSPECTION_TEXT
        /// </summary>
        public IQueryable<InsAvailableInspectionText> InsAvailableInspectionText{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgAccountingArea"/> entities from table dbo.ORG_ACCOUNTING_AREA
        /// </summary>
        public IQueryable<OrgAccountingArea> OrgAccountingArea{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsAvailableInspectionTextValue"/> entities from table dbo.INS_AVAILABLE_INSPECTION_TEXT_VALUE
        /// </summary>
        public IQueryable<InsAvailableInspectionTextValue> InsAvailableInspectionTextValue{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgBankInformation"/> entities from table dbo.ORG_BANK_INFORMATION
        /// </summary>
        public IQueryable<OrgBankInformation> OrgBankInformation{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgCostCenter"/> entities from table dbo.ORG_COST_CENTER
        /// </summary>
        public IQueryable<OrgCostCenter> OrgCostCenter{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdFederalGroup"/> entities from table dbo.ORD_FEDERAL_GROUP
        /// </summary>
        public IQueryable<OrdFederalGroup> OrdFederalGroup{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgCostCenterResponsibleEmployeeRsp"/> entities from table dbo.ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP
        /// </summary>
        public IQueryable<OrgCostCenterResponsibleEmployeeRsp> OrgCostCenterResponsibleEmployeeRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdFederalState"/> entities from table dbo.ORD_FEDERAL_STATE
        /// </summary>
        public IQueryable<OrdFederalState> OrdFederalState{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgCostCenterPrice"/> entities from table dbo.ORG_COST_CENTER_PRICE
        /// </summary>
        public IQueryable<OrgCostCenterPrice> OrgCostCenterPrice{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysCountry"/> entities from table dbo.SYS_COUNTRY
        /// </summary>
        public IQueryable<SysCountry> SysCountry{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysPostCode"/> entities from table dbo.SYS_POST_CODE
        /// </summary>
        public IQueryable<SysPostCode> SysPostCode{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdOrderCancelationReason"/> entities from table dbo.ORD_ORDER_CANCELATION_REASON
        /// </summary>
        public IQueryable<OrdOrderCancelationReason> OrdOrderCancelationReason{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgRelationshipType"/> entities from table dbo.ORG_RELATIONSHIP_TYPE
        /// </summary>
        public IQueryable<OrgRelationshipType> OrgRelationshipType{ get; set; }
        /// <summary>
        ///     Set of <see cref="KssExpenseGround"/> entities from table dbo.KSS_EXPENSE_GROUND
        /// </summary>
        public IQueryable<KssExpenseGround> KssExpenseGround{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgInformation"/> entities from table dbo.ORG_INFORMATION
        /// </summary>
        public IQueryable<OrgInformation> OrgInformation{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExpPassengersType"/> entities from table dbo.EXP_PASSENGERS_TYPE
        /// </summary>
        public IQueryable<ExpPassengersType> ExpPassengersType{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgType"/> entities from table dbo.ORG_TYPE
        /// </summary>
        public IQueryable<OrgType> OrgType{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsVatType"/> entities from table dbo.INS_VAT_TYPE
        /// </summary>
        public IQueryable<InsVatType> InsVatType{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgInspectionDevice"/> entities from table dbo.ORG_INSPECTION_DEVICE
        /// </summary>
        public IQueryable<OrgInspectionDevice> OrgInspectionDevice{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpEmployeeOrgCostCenterRsp"/> entities from table dbo.EMP_EMPLOYEE_ORG_COST_CENTER_RSP
        /// </summary>
        public IQueryable<EmpEmployeeOrgCostCenterRsp> EmpEmployeeOrgCostCenterRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdBillingParameter"/> entities from table dbo.ORD_BILLING_PARAMETER
        /// </summary>
        public IQueryable<OrdBillingParameter> OrdBillingParameter{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpEmployeeOrgOrganizationalUnitRsp"/> entities from table dbo.EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP
        /// </summary>
        public IQueryable<EmpEmployeeOrgOrganizationalUnitRsp> EmpEmployeeOrgOrganizationalUnitRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdContactPersonFunction"/> entities from table dbo.ORD_CONTACT_PERSON_FUNCTION
        /// </summary>
        public IQueryable<OrdContactPersonFunction> OrdContactPersonFunction{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpEmployeeTopEmployeeRsp"/> entities from table dbo.EMP_EMPLOYEE_TOP_EMPLOYEE_RSP
        /// </summary>
        public IQueryable<EmpEmployeeTopEmployeeRsp> EmpEmployeeTopEmployeeRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdCustomerInfo"/> entities from table dbo.ORD_CUSTOMER_INFO
        /// </summary>
        public IQueryable<OrdCustomerInfo> OrdCustomerInfo{ get; set; }
        /// <summary>
        ///     Set of <see cref="EmpEmployeeSysRoleRsp"/> entities from table dbo.EMP_EMPLOYEE_SYS_ROLE_RSP
        /// </summary>
        public IQueryable<EmpEmployeeSysRoleRsp> EmpEmployeeSysRoleRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdPartnerRole"/> entities from table dbo.ORD_PARTNER_ROLE
        /// </summary>
        public IQueryable<OrdPartnerRole> OrdPartnerRole{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsTaxClass"/> entities from table dbo.INS_TAX_CLASS
        /// </summary>
        public IQueryable<InsTaxClass> InsTaxClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsCoreDataProductGroup"/> entities from table dbo.INS_CORE_DATA_PRODUCT_GROUP
        /// </summary>
        public IQueryable<InsCoreDataProductGroup> InsCoreDataProductGroup{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsProductCombinationType"/> entities from table dbo.INS_PRODUCT_COMBINATION_TYPE
        /// </summary>
        public IQueryable<InsProductCombinationType> InsProductCombinationType{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsProductMaterialGroup"/> entities from table dbo.INS_PRODUCT_MATERIAL_GROUP
        /// </summary>
        public IQueryable<InsProductMaterialGroup> InsProductMaterialGroup{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsProductObjectClass"/> entities from table dbo.INS_PRODUCT_OBJECT_CLASS
        /// </summary>
        public IQueryable<InsProductObjectClass> InsProductObjectClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsProductObjectType"/> entities from table dbo.INS_PRODUCT_OBJECT_TYPE
        /// </summary>
        public IQueryable<InsProductObjectType> InsProductObjectType{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrgOrganizationalUnit"/> entities from table dbo.ORG_ORGANIZATIONAL_UNIT
        /// </summary>
        public IQueryable<OrgOrganizationalUnit> OrgOrganizationalUnit{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsProductType"/> entities from table dbo.INS_PRODUCT_TYPE
        /// </summary>
        public IQueryable<InsProductType> InsProductType{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsStatisticGroup"/> entities from table dbo.INS_STATISTIC_GROUP
        /// </summary>
        public IQueryable<InsStatisticGroup> InsStatisticGroup{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdAreaOfWork"/> entities from table dbo.ORD_AREA_OF_WORK
        /// </summary>
        public IQueryable<OrdAreaOfWork> OrdAreaOfWork{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdRecognitionType"/> entities from table dbo.ORD_RECOGNITION_TYPE
        /// </summary>
        public IQueryable<OrdRecognitionType> OrdRecognitionType{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdRecognition"/> entities from table dbo.ORD_RECOGNITION
        /// </summary>
        public IQueryable<OrdRecognition> OrdRecognition{ get; set; }
        /// <summary>
        ///     Set of <see cref="OrdRecognitionAreaOfWorkRsp"/> entities from table dbo.ORD_RECOGNITION_AREA_OF_WORK_RSP
        /// </summary>
        public IQueryable<OrdRecognitionAreaOfWorkRsp> OrdRecognitionAreaOfWorkRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsTaxCode"/> entities from table dbo.INS_TAX_CODE
        /// </summary>
        public IQueryable<InsTaxCode> InsTaxCode{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsInspectionStep"/> entities from table dbo.INS_INSPECTION_STEP
        /// </summary>
        public IQueryable<InsInspectionStep> InsInspectionStep{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsAvailableInspectionStep"/> entities from table dbo.INS_AVAILABLE_INSPECTION_STEP
        /// </summary>
        public IQueryable<InsAvailableInspectionStep> InsAvailableInspectionStep{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsSummaryField"/> entities from table dbo.INS_SUMMARY_FIELD
        /// </summary>
        public IQueryable<InsSummaryField> InsSummaryField{ get; set; }
        /// <summary>
        ///     Set of <see cref="InsNextInspection"/> entities from table dbo.INS_NEXT_INSPECTION
        /// </summary>
        public IQueryable<InsNextInspection> InsNextInspection{ get; set; }
    }
}
