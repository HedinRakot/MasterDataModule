






using System.Collections.Generic;

namespace MasterDataModule.API
{
    public static partial class JsonHelper
    {
        private static void AsProCommonTableMappings(IDictionary<string, TableMapping> tables)
        {
            tables.Add("SYS_LANGUAGE", new TableMapping("SYS_LANGUAGE", "SysLanguage", 6)
            {
                {"SAP_ID", "sapId"},
                {"SAP_ID_ISO", "sapIdIso"},
                {"RESOURCE_FILE_NAME", "resourceFileName"},
                {"IS_AVAILABLE", "isAvailable"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_EMPLOYEE", new TableMapping("EMP_EMPLOYEE", "EmpEmployee", 15)
            {
                {"PERSONAL_NUMBER", "personalNumber"},
                {"DOMAIN", "domain"},
                {"USER_NAME", "userName"},
                {"WINDOWS_USER_NAME", "windowsUserName"},
                {"IS_SSO_ALLOWED", "isSsoAllowed"},
                {"IS_EMERGENCY_LOGIN_ALLOWED", "isEmergencyLoginAllowed"},
                {"NAME", "name"},
                {"MIDDLE_NAME", "middleName"},
                {"LAST_NAME", "lastName"},
                {"COMMENT", "comment"},
                {"SEX_TYPE", "sexType"},
                {"TITLE", "title"},
                {"BIRTHDATE", "birthdate"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_LOCATION", new TableMapping("SYS_LOCATION", "SysLocation", 6)
            {
                {"LOCATION_CODE", "locationCode"},
                {"LOCATION_NAME", "locationName"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
                {"ORD_FEDERAL_STATE_ID", "ordFederalStateId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_ROLE", new TableMapping("SYS_ROLE", "SysRole", 5)
            {
                {"ROLE_NUMBER", "roleNumber"},
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_CASH_PERMISSION_TYPE", new TableMapping("EMP_CASH_PERMISSION_TYPE", "EmpCashPermissionType", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_ROLE_SYS_PERMISSION_RSP", new TableMapping("SYS_ROLE_SYS_PERMISSION_RSP", "SysRoleSysPermissionRsp", 4)
            {
                {"SYS_ROLE_ID", "sysRoleId"},
                {"SYS_PERMISSION_ID", "sysPermissionId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_ORG_ASSOCIATION_TYPE", new TableMapping("EMP_ORG_ASSOCIATION_TYPE", "EmpOrgAssociationType", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_ACCOUNT_TYPE", new TableMapping("ORG_ACCOUNT_TYPE", "OrgAccountType", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_ACCOUNTING_AREA", new TableMapping("ORG_ACCOUNTING_AREA", "OrgAccountingArea", 4)
            {
                {"ACCOUNTING_AREA", "accountingArea"},
                {"MAX_ORDER_SUM", "maxOrderSum"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_BANK_INFORMATION", new TableMapping("ORG_BANK_INFORMATION", "OrgBankInformation", 5)
            {
                {"BANK_NAME", "bankName"},
                {"BANK_CODE", "bankCode"},
                {"BANK_ACCOUNT", "bankAccount"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_COST_CENTER", new TableMapping("ORG_COST_CENTER", "OrgCostCenter", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_FEDERAL_GROUP", new TableMapping("ORD_FEDERAL_GROUP", "OrdFederalGroup", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP", new TableMapping("ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP", "OrgCostCenterResponsibleEmployeeRsp", 4)
            {
                {"ORG_COST_CENTER_ID", "orgCostCenterId"},
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_FEDERAL_STATE", new TableMapping("ORD_FEDERAL_STATE", "OrdFederalState", 5)
            {
                {"FEDERAL_STATE_NAME", "federalStateName"},
                {"DESCRIPTION", "description"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_COST_CENTER_PRICE", new TableMapping("ORG_COST_CENTER_PRICE", "OrgCostCenterPrice", 11)
            {
                {"INS_CORE_DATA_PRODUCT_ID", "insCoreDataProductId"},
                {"SALES_OFFICE", "salesOffice"},
                {"MIN_PRICE", "minPrice"},
                {"MAX_PRICE", "maxPrice"},
                {"STANDART_PRICE", "standartPrice"},
                {"QUANTITY", "quantity"},
                {"UNIT_OF_MEASURE", "unitOfMeasure"},
                {"SYS_CURRENCY_ID", "sysCurrencyId"},
                {"CHANGE_ABILITY_TYPE", "changeAbilityType"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_COUNTRY", new TableMapping("SYS_COUNTRY", "SysCountry", 5)
            {
                {"SAP_ID", "sapId"},
                {"NAME", "name"},
                {"IS_EU", "isEu"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_POST_CODE", new TableMapping("SYS_POST_CODE", "SysPostCode", 5)
            {
                {"POST_CODE", "postCode"},
                {"CITY", "city"},
                {"STREET", "street"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_ORDER_CANCELATION_REASON", new TableMapping("ORD_ORDER_CANCELATION_REASON", "OrdOrderCancelationReason", 3)
            {
                {"CANCELATION_REASON_TEXT", "cancelationReasonText"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_RELATIONSHIP_TYPE", new TableMapping("ORG_RELATIONSHIP_TYPE", "OrgRelationshipType", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("KSS_EXPENSE_GROUND", new TableMapping("KSS_EXPENSE_GROUND", "KssExpenseGround", 6)
            {
                {"DESCRIPTION", "description"},
                {"ACCOUNT", "account"},
                {"INS_VAT_TYPE_ID", "insVatTypeId"},
                {"MAX_AMOUNT", "maxAmount"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_INFORMATION", new TableMapping("ORG_INFORMATION", "OrgInformation", 4)
            {
                {"NAME", "name"},
                {"VALUE", "value"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EXP_PASSENGERS_TYPE", new TableMapping("EXP_PASSENGERS_TYPE", "ExpPassengersType", 4)
            {
                {"TEXT", "text"},
                {"CODE", "code"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_TYPE", new TableMapping("ORG_TYPE", "OrgType", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_VAT_TYPE", new TableMapping("INS_VAT_TYPE", "InsVatType", 5)
            {
                {"DESCRIPTION", "description"},
                {"TAX_CODE", "taxCode"},
                {"PERCENT", "percent"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORG_INSPECTION_DEVICE", new TableMapping("ORG_INSPECTION_DEVICE", "OrgInspectionDevice", 14)
            {
                {"DEBITOR_CUSTOMER_NUMBER", "debitorCustomerNumber"},
                {"IDENTIFICATION", "identification"},
                {"NEW_IDENTIFICATION", "newIdentification"},
                {"OLD_IDENTIFICATION", "oldIdentification"},
                {"TYPE", "type"},
                {"SERIAL_NUMBER", "serialNumber"},
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"LAST_INSPECTION_DATE", "lastInspectionDate"},
                {"LAST_INSPECTION_RESULT", "lastInspectionResult"},
                {"INSPECTION_DATE", "inspectionDate"},
                {"INSPECTION_INTERVAL", "inspectionInterval"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_EMPLOYEE_ORG_COST_CENTER_RSP", new TableMapping("EMP_EMPLOYEE_ORG_COST_CENTER_RSP", "EmpEmployeeOrgCostCenterRsp", 4)
            {
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"ORG_COST_CENTER_ID", "orgCostCenterId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_BILLING_PARAMETER", new TableMapping("ORD_BILLING_PARAMETER", "OrdBillingParameter", 4)
            {
                {"SAP_ID", "sapId"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP", new TableMapping("EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP", "EmpEmployeeOrgOrganizationalUnitRsp", 4)
            {
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"ORG_ORGANIZATIONAL_UNIT_ID", "orgOrganizationalUnitId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_CONTACT_PERSON_FUNCTION", new TableMapping("ORD_CONTACT_PERSON_FUNCTION", "OrdContactPersonFunction", 4)
            {
                {"SAP_ID", "sapId"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_EMPLOYEE_TOP_EMPLOYEE_RSP", new TableMapping("EMP_EMPLOYEE_TOP_EMPLOYEE_RSP", "EmpEmployeeTopEmployeeRsp", 4)
            {
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"TOP_EMPLOYEE_ID", "topEmployeeId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_CUSTOMER_INFO", new TableMapping("ORD_CUSTOMER_INFO", "OrdCustomerInfo", 5)
            {
                {"TEXT_VALUE", "textValue"},
                {"NUMBER_VALUE", "numberValue"},
                {"INFO_TYPE", "infoType"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("EMP_EMPLOYEE_SYS_ROLE_RSP", new TableMapping("EMP_EMPLOYEE_SYS_ROLE_RSP", "EmpEmployeeSysRoleRsp", 4)
            {
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"SYS_ROLE_ID", "sysRoleId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_PARTNER_ROLE", new TableMapping("ORD_PARTNER_ROLE", "OrdPartnerRole", 3)
            {
                {"SAP_QUALIFIER", "sapQualifier"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_TAX_CLASS", new TableMapping("INS_TAX_CLASS", "InsTaxClass", 3)
            {
                {"TAX_CLASS", "taxClass"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_CORE_DATA_PRODUCT_GROUP", new TableMapping("INS_CORE_DATA_PRODUCT_GROUP", "InsCoreDataProductGroup", 4)
            {
                {"NAME", "name"},
                {"DEFAULT_DURATION", "defaultDuration"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_PRODUCT_COMBINATION_TYPE", new TableMapping("INS_PRODUCT_COMBINATION_TYPE", "InsProductCombinationType", 3)
            {
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_PRODUCT_MATERIAL_GROUP", new TableMapping("INS_PRODUCT_MATERIAL_GROUP", "InsProductMaterialGroup", 4)
            {
                {"DESCRIPTION", "description"},
                {"SAP_ID", "sapId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_PRODUCT_OBJECT_CLASS", new TableMapping("INS_PRODUCT_OBJECT_CLASS", "InsProductObjectClass", 4)
            {
                {"DESCRIPTION", "description"},
                {"WEIGHT_FROM", "weightFrom"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_PRODUCT_OBJECT_TYPE", new TableMapping("INS_PRODUCT_OBJECT_TYPE", "InsProductObjectType", 5)
            {
                {"DESCRIPTION", "description"},
                {"SAP_ID", "sapId"},
                {"IS_AU_NECESSARY", "isAuNecessary"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_PRODUCT_TYPE", new TableMapping("INS_PRODUCT_TYPE", "InsProductType", 3)
            {
                {"NAME", "name"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_STATISTIC_GROUP", new TableMapping("INS_STATISTIC_GROUP", "InsStatisticGroup", 3)
            {
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_RECOGNITION_TYPE", new TableMapping("ORD_RECOGNITION_TYPE", "OrdRecognitionType", 3)
            {
                {"NAME", "name"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("ORD_RECOGNITION", new TableMapping("ORD_RECOGNITION", "OrdRecognition", 4)
            {
                {"ORD_RECOGNITION_TYPE_ID", "ordRecognitionTypeId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"ORG_ACCOUNTING_AREA_ID", "orgAccountingAreaId"},
            });

            tables.Add("ORD_RECOGNITION_AREA_OF_WORK_RSP", new TableMapping("ORD_RECOGNITION_AREA_OF_WORK_RSP", "OrdRecognitionAreaOfWorkRsp", 5)
            {
                {"ORD_RECOGNITION_ID", "ordRecognitionId"},
                {"ORD_AREA_OF_WORK_ID", "ordAreaOfWorkId"},
                {"PRIORITY", "priority"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("INS_TAX_CODE", new TableMapping("INS_TAX_CODE", "InsTaxCode", 3)
            {
                {"TAX_CODE", "taxCode"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

        }
    }
}
