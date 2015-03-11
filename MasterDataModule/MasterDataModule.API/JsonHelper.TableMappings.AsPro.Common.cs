






using System.Collections.Generic;

namespace MasterDataModule.API
{
    public static partial class JsonHelper
    {
        private static void AsProCommonTableMappings(IDictionary<string, TableMapping> tables)
        {
            tables.Add("SYS_LANGUAGE", new TableMapping("SYS_LANGUAGE", "SysLanguage", 4)
            {
                {"SAP_ID", "sapId"},
                {"SAP_ID_ISO", "sapIdIso"},
                {"RESOURCE_FILE_NAME", "resourceFileName"},
                {"IS_AVAILABLE", "isAvailable"},
            });

            tables.Add("EMP_EMPLOYEE", new TableMapping("EMP_EMPLOYEE", "EmpEmployee", 13)
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
            });

            tables.Add("SYS_LOCATION", new TableMapping("SYS_LOCATION", "SysLocation", 4)
            {
                {"LOCATION_CODE", "locationCode"},
                {"LOCATION_NAME", "locationName"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
                {"ORD_FEDERAL_STATE_ID", "ordFederalStateId"},
            });

            tables.Add("SYS_ROLE", new TableMapping("SYS_ROLE", "SysRole", 3)
            {
                {"ROLE_NUMBER", "roleNumber"},
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("EMP_CASH_PERMISSION_TYPE", new TableMapping("EMP_CASH_PERMISSION_TYPE", "EmpCashPermissionType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("SYS_ROLE_SYS_PERMISSION_RSP", new TableMapping("SYS_ROLE_SYS_PERMISSION_RSP", "SysRoleSysPermissionRsp", 2)
            {
                {"SYS_ROLE_ID", "sysRoleId"},
                {"SYS_PERMISSION_ID", "sysPermissionId"},
            });

            tables.Add("EMP_ORG_ASSOCIATION_TYPE", new TableMapping("EMP_ORG_ASSOCIATION_TYPE", "EmpOrgAssociationType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("ORG_ACCOUNT_TYPE", new TableMapping("ORG_ACCOUNT_TYPE", "OrgAccountType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("ORG_ACCOUNTING_AREA", new TableMapping("ORG_ACCOUNTING_AREA", "OrgAccountingArea", 2)
            {
                {"ACCOUNTING_AREA", "accountingArea"},
                {"MAX_ORDER_SUM", "maxOrderSum"},
            });

            tables.Add("ORG_BANK_INFORMATION", new TableMapping("ORG_BANK_INFORMATION", "OrgBankInformation", 3)
            {
                {"BANK_NAME", "bankName"},
                {"BANK_CODE", "bankCode"},
                {"BANK_ACCOUNT", "bankAccount"},
            });

            tables.Add("ORG_COST_CENTER", new TableMapping("ORG_COST_CENTER", "OrgCostCenter", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("ORD_FEDERAL_GROUP", new TableMapping("ORD_FEDERAL_GROUP", "OrdFederalGroup", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("ORD_FEDERAL_STATE", new TableMapping("ORD_FEDERAL_STATE", "OrdFederalState", 3)
            {
                {"FEDERAL_STATE_NAME", "federalStateName"},
                {"DESCRIPTION", "description"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
            });

            tables.Add("ORG_COST_CENTER_PRICE", new TableMapping("ORG_COST_CENTER_PRICE", "OrgCostCenterPrice", 9)
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
            });

            tables.Add("SYS_COUNTRY", new TableMapping("SYS_COUNTRY", "SysCountry", 3)
            {
                {"SAP_ID", "sapId"},
                {"NAME", "name"},
                {"IS_EU", "isEu"},
            });

            tables.Add("SYS_POST_CODE", new TableMapping("SYS_POST_CODE", "SysPostCode", 3)
            {
                {"POST_CODE", "postCode"},
                {"CITY", "city"},
                {"STREET", "street"},
            });

            tables.Add("ORD_ORDER_CANCELATION_REASON", new TableMapping("ORD_ORDER_CANCELATION_REASON", "OrdOrderCancelationReason", 1)
            {
                {"CANCELATION_REASON_TEXT", "cancelationReasonText"},
            });

            tables.Add("ORG_RELATIONSHIP_TYPE", new TableMapping("ORG_RELATIONSHIP_TYPE", "OrgRelationshipType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("KSS_EXPENSE_GROUND", new TableMapping("KSS_EXPENSE_GROUND", "KssExpenseGround", 4)
            {
                {"DESCRIPTION", "description"},
                {"ACCOUNT", "account"},
                {"INS_VAT_TYPE_ID", "insVatTypeId"},
                {"MAX_AMOUNT", "maxAmount"},
            });

            tables.Add("ORG_INFORMATION", new TableMapping("ORG_INFORMATION", "OrgInformation", 2)
            {
                {"NAME", "name"},
                {"VALUE", "value"},
            });

            tables.Add("EXP_PASSENGERS_TYPE", new TableMapping("EXP_PASSENGERS_TYPE", "ExpPassengersType", 2)
            {
                {"TEXT", "text"},
                {"CODE", "code"},
            });

            tables.Add("ORG_TYPE", new TableMapping("ORG_TYPE", "OrgType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("INS_VAT_TYPE", new TableMapping("INS_VAT_TYPE", "InsVatType", 3)
            {
                {"DESCRIPTION", "description"},
                {"TAX_CODE", "taxCode"},
                {"PERCENT", "percent"},
            });

            tables.Add("ORG_INSPECTION_DEVICE", new TableMapping("ORG_INSPECTION_DEVICE", "OrgInspectionDevice", 12)
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
            });

            tables.Add("ORD_BILLING_PARAMETER", new TableMapping("ORD_BILLING_PARAMETER", "OrdBillingParameter", 2)
            {
                {"SAP_ID", "sapId"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("ORD_CONTACT_PERSON_FUNCTION", new TableMapping("ORD_CONTACT_PERSON_FUNCTION", "OrdContactPersonFunction", 2)
            {
                {"SAP_ID", "sapId"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("EMP_EMPLOYEE_TOP_EMPLOYEE_RSP", new TableMapping("EMP_EMPLOYEE_TOP_EMPLOYEE_RSP", "EmpEmployeeTopEmployeeRsp", 2)
            {
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"TOP_EMPLOYEE_ID", "topEmployeeId"},
            });

            tables.Add("ORD_CUSTOMER_INFO", new TableMapping("ORD_CUSTOMER_INFO", "OrdCustomerInfo", 3)
            {
                {"TEXT_VALUE", "textValue"},
                {"NUMBER_VALUE", "numberValue"},
                {"INFO_TYPE", "infoType"},
            });

            tables.Add("EMP_EMPLOYEE_SYS_ROLE_RSP", new TableMapping("EMP_EMPLOYEE_SYS_ROLE_RSP", "EmpEmployeeSysRoleRsp", 2)
            {
                {"EMP_EMPLOYEE_ID", "empEmployeeId"},
                {"SYS_ROLE_ID", "sysRoleId"},
            });

            tables.Add("ORD_PARTNER_ROLE", new TableMapping("ORD_PARTNER_ROLE", "OrdPartnerRole", 1)
            {
                {"SAP_QUALIFIER", "sapQualifier"},
            });

            tables.Add("INS_TAX_CLASS", new TableMapping("INS_TAX_CLASS", "InsTaxClass", 1)
            {
                {"TAX_CLASS", "taxClass"},
            });

            tables.Add("INS_CORE_DATA_PRODUCT_GROUP", new TableMapping("INS_CORE_DATA_PRODUCT_GROUP", "InsCoreDataProductGroup", 2)
            {
                {"NAME", "name"},
                {"DEFAULT_DURATION", "defaultDuration"},
            });

            tables.Add("INS_PRODUCT_COMBINATION_TYPE", new TableMapping("INS_PRODUCT_COMBINATION_TYPE", "InsProductCombinationType", 1)
            {
                {"DESCRIPTION", "description"},
            });

            tables.Add("INS_PRODUCT_MATERIAL_GROUP", new TableMapping("INS_PRODUCT_MATERIAL_GROUP", "InsProductMaterialGroup", 2)
            {
                {"DESCRIPTION", "description"},
                {"SAP_ID", "sapId"},
            });

            tables.Add("INS_PRODUCT_OBJECT_CLASS", new TableMapping("INS_PRODUCT_OBJECT_CLASS", "InsProductObjectClass", 2)
            {
                {"DESCRIPTION", "description"},
                {"WEIGHT_FROM", "weightFrom"},
            });

            tables.Add("INS_PRODUCT_OBJECT_TYPE", new TableMapping("INS_PRODUCT_OBJECT_TYPE", "InsProductObjectType", 3)
            {
                {"DESCRIPTION", "description"},
                {"SAP_ID", "sapId"},
                {"IS_AU_NECESSARY", "isAuNecessary"},
            });

            tables.Add("INS_PRODUCT_TYPE", new TableMapping("INS_PRODUCT_TYPE", "InsProductType", 1)
            {
                {"NAME", "name"},
            });

            tables.Add("INS_STATISTIC_GROUP", new TableMapping("INS_STATISTIC_GROUP", "InsStatisticGroup", 1)
            {
                {"DESCRIPTION", "description"},
            });

            tables.Add("ORD_RECOGNITION_TYPE", new TableMapping("ORD_RECOGNITION_TYPE", "OrdRecognitionType", 1)
            {
                {"NAME", "name"},
            });

            tables.Add("ORD_RECOGNITION", new TableMapping("ORD_RECOGNITION", "OrdRecognition", 2)
            {
                {"ORD_RECOGNITION_TYPE_ID", "ordRecognitionTypeId"},
                {"ORG_ACCOUNTING_AREA_ID", "orgAccountingAreaId"},
            });

            tables.Add("INS_TAX_CODE", new TableMapping("INS_TAX_CODE", "InsTaxCode", 1)
            {
                {"TAX_CODE", "taxCode"},
            });

        }
    }
}
