






using MasterDataModule.Contracts.Entities;
using System.Linq;

namespace MasterDataModule.Contracts
{
    /// <summary>
    ///     Interface for AsPro context
    /// </summary>
    public partial interface IAsProEntities
    {
        /// <summary>
        ///     Set of <see cref="InsNextSpInterval"/> entities from table dbo.INS_NEXT_SP_INTERVAL
        /// </summary>
        IQueryable<InsNextSpInterval> InsNextSpInterval{get;}
        /// <summary>
        ///     Set of <see cref="InsObdStatus"/> entities from table dbo.INS_OBD_STATUS
        /// </summary>
        IQueryable<InsObdStatus> InsObdStatus{get;}
        /// <summary>
        ///     Set of <see cref="InsOpticalDefect"/> entities from table dbo.INS_OPTICAL_DEFECT
        /// </summary>
        IQueryable<InsOpticalDefect> InsOpticalDefect{get;}
        /// <summary>
        ///     Set of <see cref="InsProductClassGroup"/> entities from table dbo.INS_PRODUCT_CLASS_GROUP
        /// </summary>
        IQueryable<InsProductClassGroup> InsProductClassGroup{get;}
        /// <summary>
        ///     Set of <see cref="InsSeverityType"/> entities from table dbo.INS_SEVERITY_TYPE
        /// </summary>
        IQueryable<InsSeverityType> InsSeverityType{get;}
        /// <summary>
        ///     Set of <see cref="SysLanguage"/> entities from table dbo.SYS_LANGUAGE
        /// </summary>
        IQueryable<SysLanguage> SysLanguage{get;}
        /// <summary>
        ///     Set of <see cref="InsValidPeriod"/> entities from table dbo.INS_VALID_PERIOD
        /// </summary>
        IQueryable<InsValidPeriod> InsValidPeriod{get;}
        /// <summary>
        ///     Set of <see cref="InsPfpPosition"/> entities from table dbo.INS_PFP_POSITION
        /// </summary>
        IQueryable<InsPfpPosition> InsPfpPosition{get;}
        /// <summary>
        ///     Set of <see cref="InsPfpInspectionTypePfpPositionRsp"/> entities from table dbo.INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP
        /// </summary>
        IQueryable<InsPfpInspectionTypePfpPositionRsp> InsPfpInspectionTypePfpPositionRsp{get;}
        /// <summary>
        ///     Set of <see cref="InsPfpVehicleType"/> entities from table dbo.INS_PFP_VEHICLE_TYPE
        /// </summary>
        IQueryable<InsPfpVehicleType> InsPfpVehicleType{get;}
        /// <summary>
        ///     Set of <see cref="EmpEmployee"/> entities from table dbo.EMP_EMPLOYEE
        /// </summary>
        IQueryable<EmpEmployee> EmpEmployee{get;}
        /// <summary>
        ///     Set of <see cref="InsUnitCode"/> entities from table dbo.INS_UNIT_CODE
        /// </summary>
        IQueryable<InsUnitCode> InsUnitCode{get;}
        /// <summary>
        ///     Set of <see cref="SysLocation"/> entities from table dbo.SYS_LOCATION
        /// </summary>
        IQueryable<SysLocation> SysLocation{get;}
        /// <summary>
        ///     Set of <see cref="SysRole"/> entities from table dbo.SYS_ROLE
        /// </summary>
        IQueryable<SysRole> SysRole{get;}
        /// <summary>
        ///     Set of <see cref="EmpCashPermissionType"/> entities from table dbo.EMP_CASH_PERMISSION_TYPE
        /// </summary>
        IQueryable<EmpCashPermissionType> EmpCashPermissionType{get;}
        /// <summary>
        ///     Set of <see cref="SysRoleSysPermissionRsp"/> entities from table dbo.SYS_ROLE_SYS_PERMISSION_RSP
        /// </summary>
        IQueryable<SysRoleSysPermissionRsp> SysRoleSysPermissionRsp{get;}
        /// <summary>
        ///     Set of <see cref="EmpOrgAssociationType"/> entities from table dbo.EMP_ORG_ASSOCIATION_TYPE
        /// </summary>
        IQueryable<EmpOrgAssociationType> EmpOrgAssociationType{get;}
        /// <summary>
        ///     Set of <see cref="OrgAccountType"/> entities from table dbo.ORG_ACCOUNT_TYPE
        /// </summary>
        IQueryable<OrgAccountType> OrgAccountType{get;}
        /// <summary>
        ///     Set of <see cref="InsAvailableInspectionText"/> entities from table dbo.INS_AVAILABLE_INSPECTION_TEXT
        /// </summary>
        IQueryable<InsAvailableInspectionText> InsAvailableInspectionText{get;}
        /// <summary>
        ///     Set of <see cref="OrgAccountingArea"/> entities from table dbo.ORG_ACCOUNTING_AREA
        /// </summary>
        IQueryable<OrgAccountingArea> OrgAccountingArea{get;}
        /// <summary>
        ///     Set of <see cref="InsAvailableInspectionTextValue"/> entities from table dbo.INS_AVAILABLE_INSPECTION_TEXT_VALUE
        /// </summary>
        IQueryable<InsAvailableInspectionTextValue> InsAvailableInspectionTextValue{get;}
        /// <summary>
        ///     Set of <see cref="OrgBankInformation"/> entities from table dbo.ORG_BANK_INFORMATION
        /// </summary>
        IQueryable<OrgBankInformation> OrgBankInformation{get;}
        /// <summary>
        ///     Set of <see cref="OrgCostCenter"/> entities from table dbo.ORG_COST_CENTER
        /// </summary>
        IQueryable<OrgCostCenter> OrgCostCenter{get;}
        /// <summary>
        ///     Set of <see cref="OrdFederalGroup"/> entities from table dbo.ORD_FEDERAL_GROUP
        /// </summary>
        IQueryable<OrdFederalGroup> OrdFederalGroup{get;}
        /// <summary>
        ///     Set of <see cref="OrgCostCenterResponsibleEmployeeRsp"/> entities from table dbo.ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP
        /// </summary>
        IQueryable<OrgCostCenterResponsibleEmployeeRsp> OrgCostCenterResponsibleEmployeeRsp{get;}
        /// <summary>
        ///     Set of <see cref="OrdFederalState"/> entities from table dbo.ORD_FEDERAL_STATE
        /// </summary>
        IQueryable<OrdFederalState> OrdFederalState{get;}
        /// <summary>
        ///     Set of <see cref="OrgCostCenterPrice"/> entities from table dbo.ORG_COST_CENTER_PRICE
        /// </summary>
        IQueryable<OrgCostCenterPrice> OrgCostCenterPrice{get;}
        /// <summary>
        ///     Set of <see cref="SysCountry"/> entities from table dbo.SYS_COUNTRY
        /// </summary>
        IQueryable<SysCountry> SysCountry{get;}
        /// <summary>
        ///     Set of <see cref="SysPostCode"/> entities from table dbo.SYS_POST_CODE
        /// </summary>
        IQueryable<SysPostCode> SysPostCode{get;}
        /// <summary>
        ///     Set of <see cref="OrdOrderCancelationReason"/> entities from table dbo.ORD_ORDER_CANCELATION_REASON
        /// </summary>
        IQueryable<OrdOrderCancelationReason> OrdOrderCancelationReason{get;}
        /// <summary>
        ///     Set of <see cref="OrgRelationshipType"/> entities from table dbo.ORG_RELATIONSHIP_TYPE
        /// </summary>
        IQueryable<OrgRelationshipType> OrgRelationshipType{get;}
        /// <summary>
        ///     Set of <see cref="KssExpenseGround"/> entities from table dbo.KSS_EXPENSE_GROUND
        /// </summary>
        IQueryable<KssExpenseGround> KssExpenseGround{get;}
        /// <summary>
        ///     Set of <see cref="OrgInformation"/> entities from table dbo.ORG_INFORMATION
        /// </summary>
        IQueryable<OrgInformation> OrgInformation{get;}
        /// <summary>
        ///     Set of <see cref="ExpPassengersType"/> entities from table dbo.EXP_PASSENGERS_TYPE
        /// </summary>
        IQueryable<ExpPassengersType> ExpPassengersType{get;}
        /// <summary>
        ///     Set of <see cref="OrgType"/> entities from table dbo.ORG_TYPE
        /// </summary>
        IQueryable<OrgType> OrgType{get;}
        /// <summary>
        ///     Set of <see cref="InsVatType"/> entities from table dbo.INS_VAT_TYPE
        /// </summary>
        IQueryable<InsVatType> InsVatType{get;}
        /// <summary>
        ///     Set of <see cref="OrgInspectionDevice"/> entities from table dbo.ORG_INSPECTION_DEVICE
        /// </summary>
        IQueryable<OrgInspectionDevice> OrgInspectionDevice{get;}
        /// <summary>
        ///     Set of <see cref="EmpEmployeeOrgCostCenterRsp"/> entities from table dbo.EMP_EMPLOYEE_ORG_COST_CENTER_RSP
        /// </summary>
        IQueryable<EmpEmployeeOrgCostCenterRsp> EmpEmployeeOrgCostCenterRsp{get;}
        /// <summary>
        ///     Set of <see cref="OrdBillingParameter"/> entities from table dbo.ORD_BILLING_PARAMETER
        /// </summary>
        IQueryable<OrdBillingParameter> OrdBillingParameter{get;}
        /// <summary>
        ///     Set of <see cref="EmpEmployeeOrgOrganizationalUnitRsp"/> entities from table dbo.EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP
        /// </summary>
        IQueryable<EmpEmployeeOrgOrganizationalUnitRsp> EmpEmployeeOrgOrganizationalUnitRsp{get;}
        /// <summary>
        ///     Set of <see cref="OrdContactPersonFunction"/> entities from table dbo.ORD_CONTACT_PERSON_FUNCTION
        /// </summary>
        IQueryable<OrdContactPersonFunction> OrdContactPersonFunction{get;}
        /// <summary>
        ///     Set of <see cref="EmpEmployeeTopEmployeeRsp"/> entities from table dbo.EMP_EMPLOYEE_TOP_EMPLOYEE_RSP
        /// </summary>
        IQueryable<EmpEmployeeTopEmployeeRsp> EmpEmployeeTopEmployeeRsp{get;}
        /// <summary>
        ///     Set of <see cref="OrdCustomerInfo"/> entities from table dbo.ORD_CUSTOMER_INFO
        /// </summary>
        IQueryable<OrdCustomerInfo> OrdCustomerInfo{get;}
        /// <summary>
        ///     Set of <see cref="EmpEmployeeSysRoleRsp"/> entities from table dbo.EMP_EMPLOYEE_SYS_ROLE_RSP
        /// </summary>
        IQueryable<EmpEmployeeSysRoleRsp> EmpEmployeeSysRoleRsp{get;}
        /// <summary>
        ///     Set of <see cref="OrdPartnerRole"/> entities from table dbo.ORD_PARTNER_ROLE
        /// </summary>
        IQueryable<OrdPartnerRole> OrdPartnerRole{get;}
        /// <summary>
        ///     Set of <see cref="InsTaxClass"/> entities from table dbo.INS_TAX_CLASS
        /// </summary>
        IQueryable<InsTaxClass> InsTaxClass{get;}
        /// <summary>
        ///     Set of <see cref="InsCoreDataProductGroup"/> entities from table dbo.INS_CORE_DATA_PRODUCT_GROUP
        /// </summary>
        IQueryable<InsCoreDataProductGroup> InsCoreDataProductGroup{get;}
        /// <summary>
        ///     Set of <see cref="InsProductCombinationType"/> entities from table dbo.INS_PRODUCT_COMBINATION_TYPE
        /// </summary>
        IQueryable<InsProductCombinationType> InsProductCombinationType{get;}
        /// <summary>
        ///     Set of <see cref="InsProductMaterialGroup"/> entities from table dbo.INS_PRODUCT_MATERIAL_GROUP
        /// </summary>
        IQueryable<InsProductMaterialGroup> InsProductMaterialGroup{get;}
        /// <summary>
        ///     Set of <see cref="InsProductObjectClass"/> entities from table dbo.INS_PRODUCT_OBJECT_CLASS
        /// </summary>
        IQueryable<InsProductObjectClass> InsProductObjectClass{get;}
        /// <summary>
        ///     Set of <see cref="InsProductObjectType"/> entities from table dbo.INS_PRODUCT_OBJECT_TYPE
        /// </summary>
        IQueryable<InsProductObjectType> InsProductObjectType{get;}
        /// <summary>
        ///     Set of <see cref="OrgOrganizationalUnit"/> entities from table dbo.ORG_ORGANIZATIONAL_UNIT
        /// </summary>
        IQueryable<OrgOrganizationalUnit> OrgOrganizationalUnit{get;}
        /// <summary>
        ///     Set of <see cref="InsProductType"/> entities from table dbo.INS_PRODUCT_TYPE
        /// </summary>
        IQueryable<InsProductType> InsProductType{get;}
        /// <summary>
        ///     Set of <see cref="InsStatisticGroup"/> entities from table dbo.INS_STATISTIC_GROUP
        /// </summary>
        IQueryable<InsStatisticGroup> InsStatisticGroup{get;}
        /// <summary>
        ///     Set of <see cref="OrdAreaOfWork"/> entities from table dbo.ORD_AREA_OF_WORK
        /// </summary>
        IQueryable<OrdAreaOfWork> OrdAreaOfWork{get;}
        /// <summary>
        ///     Set of <see cref="OrdRecognitionType"/> entities from table dbo.ORD_RECOGNITION_TYPE
        /// </summary>
        IQueryable<OrdRecognitionType> OrdRecognitionType{get;}
        /// <summary>
        ///     Set of <see cref="OrdRecognition"/> entities from table dbo.ORD_RECOGNITION
        /// </summary>
        IQueryable<OrdRecognition> OrdRecognition{get;}
        /// <summary>
        ///     Set of <see cref="OrdRecognitionAreaOfWorkRsp"/> entities from table dbo.ORD_RECOGNITION_AREA_OF_WORK_RSP
        /// </summary>
        IQueryable<OrdRecognitionAreaOfWorkRsp> OrdRecognitionAreaOfWorkRsp{get;}
        /// <summary>
        ///     Set of <see cref="InsTaxCode"/> entities from table dbo.INS_TAX_CODE
        /// </summary>
        IQueryable<InsTaxCode> InsTaxCode{get;}
        /// <summary>
        ///     Set of <see cref="InsInspectionStep"/> entities from table dbo.INS_INSPECTION_STEP
        /// </summary>
        IQueryable<InsInspectionStep> InsInspectionStep{get;}
        /// <summary>
        ///     Set of <see cref="InsAvailableInspectionStep"/> entities from table dbo.INS_AVAILABLE_INSPECTION_STEP
        /// </summary>
        IQueryable<InsAvailableInspectionStep> InsAvailableInspectionStep{get;}
        /// <summary>
        ///     Set of <see cref="InsSummaryField"/> entities from table dbo.INS_SUMMARY_FIELD
        /// </summary>
        IQueryable<InsSummaryField> InsSummaryField{get;}
        /// <summary>
        ///     Set of <see cref="InsNextInspection"/> entities from table dbo.INS_NEXT_INSPECTION
        /// </summary>
        IQueryable<InsNextInspection> InsNextInspection{get;}
    }
}
