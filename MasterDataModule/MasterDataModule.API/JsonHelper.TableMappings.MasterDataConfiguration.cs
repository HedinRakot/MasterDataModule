






using System.Collections.Generic;

namespace MasterDataModule.API
{
    public static partial class JsonHelper
    {
        private static void MasterDataConfigurationTableMappings(IDictionary<string, TableMapping> tables)
        {
            tables.Add("MASTER_DATA_JOB_INFO", new TableMapping("MASTER_DATA_JOB_INFO", "MasterDataJobInfo", 8)
            {
                {"CONNECTION_STRING", "connectionString"},
                {"TABLE_NAME", "tableName"},
                {"TIMEOUT_CHECKING", "timeoutChecking"},
                {"NAME", "name"},
                {"JOB_NAME", "jobName"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"LOG_TYPE_INFO_ID", "logTypeInfoId"},
            });

            tables.Add("MASTER_DATA_JOB_CHECK_RESULTS", new TableMapping("MASTER_DATA_JOB_CHECK_RESULTS", "MasterDataJobCheckResults", 6)
            {
                {"LAST_RUN_TIME", "lastRunTime"},
                {"CHECK_DATE", "checkDate"},
                {"CHECK_STATUS", "checkStatus"},
                {"MASTER_DATA_JOB_INFO_ID", "masterDataJobInfoId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_WINDOWS_SERVICE_INFO", new TableMapping("MASTER_DATA_WINDOWS_SERVICE_INFO", "MasterDataWindowsServiceInfo", 7)
            {
                {"NAME", "name"},
                {"MACHINE_NAME", "machineName"},
                {"SERVICE_NAME", "serviceName"},
                {"TIMEOUT_CHECKING", "timeoutChecking"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"LOG_TYPE_INFO_ID", "logTypeInfoId"},
            });

            tables.Add("MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS", new TableMapping("MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS", "MasterDataWindowsServiceCheckResults", 7)
            {
                {"CHECK_STATUS", "checkStatus"},
                {"CHECK_DATE", "checkDate"},
                {"MESSAGE", "message"},
                {"ATTEMPT", "attempt"},
                {"MASTER_DATA_WINDOWS_SERVICE_INFO_ID", "masterDataWindowsServiceInfoId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_ROLE", new TableMapping("MASTER_DATA_ROLE", "Role", 3)
            {
                {"NAME", "name"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_PERMISSION", new TableMapping("MASTER_DATA_PERMISSION", "Permission", 4)
            {
                {"SYSTEM_NAME", "systemName"},
                {"NAME", "name"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_ROLE_PERMISSION_RSP", new TableMapping("MASTER_DATA_ROLE_PERMISSION_RSP", "MasterDataRolePermissionRsp", 4)
            {
                {"MASTER_DATA_ROLE_ID", "masterDataRoleId"},
                {"MASTER_DATA_PERMISSION_ID", "masterDataPermissionId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_USER", new TableMapping("MASTER_DATA_USER", "User", 6)
            {
                {"MASTER_DATA_ROLE_ID", "masterDataRoleId"},
                {"LOGIN", "login"},
                {"NAME", "name"},
                {"PASSWORD", "password"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_SUBSCRIBERS", new TableMapping("MASTER_DATA_SUBSCRIBERS", "MasterDataSubscribers", 3)
            {
                {"EMAIL", "email"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_NOTIFICATIONS", new TableMapping("MASTER_DATA_NOTIFICATIONS", "MasterDataNotifications", 8)
            {
                {"NOTIFICATION_TYPE", "notificationType"},
                {"IS_ALERT_ON", "isAlertOn"},
                {"ALERT_CHECK_STATUS", "alertCheckStatus"},
                {"ALERT_ATTEMPT_COUNT", "alertAttemptCount"},
                {"MESSAGE", "message"},
                {"SUBJECT", "subject"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_COLUMNS", new TableMapping("SYS_COLUMNS", "SysColumn", 4)
            {
                {"SYS_TABLE_ID", "sysTableId"},
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"READ_ONLY", "readOnly"},
            });

            tables.Add("MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP", new TableMapping("MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP", "MasterDataMonitorableInfoMasterDataNotificationsRsp", 5)
            {
                {"MONITORABLE_INFO_TYPE", "monitorableInfoType"},
                {"MONITORABLE_INFO_ID", "monitorableInfoId"},
                {"MASTER_DATA_NOTIFICATIONS_ID", "masterDataNotificationsId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("SYS_TABLES", new TableMapping("SYS_TABLES", "SysTable", 5)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"EDIT_MODE", "editMode"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP", new TableMapping("MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP", "MasterDataNotificationsMasterDataSubscribersRsp", 4)
            {
                {"MASTER_DATA_NOTIFICATIONS_ID", "masterDataNotificationsId"},
                {"MASTER_DATA_SUBSCRIBERS_ID", "masterDataSubscribersId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("APPLICATION_LOGS", new TableMapping("APPLICATION_LOGS", "ApplicationLogs", 6)
            {
                {"LOG_LEVEL", "logLevel"},
                {"DATE", "date"},
                {"MESSAGE", "message"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"LOG_TYPE_INFO_ID", "logTypeInfoId"},
            });

            tables.Add("MASTER_DATA_WCF_INFO", new TableMapping("MASTER_DATA_WCF_INFO", "MasterDataWcfInfo", 6)
            {
                {"NAME", "name"},
                {"WSDL_PATH", "wsdlPath"},
                {"TIMEOUT_CHECKING", "timeoutChecking"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"LOG_TYPE_INFO_ID", "logTypeInfoId"},
            });

            tables.Add("MASTER_DATA_WCF_CHECK_RESULTS", new TableMapping("MASTER_DATA_WCF_CHECK_RESULTS", "MasterDataWcfCheckResults", 7)
            {
                {"CHECK_STATUS", "checkStatus"},
                {"CHECK_DATE", "checkDate"},
                {"MESSAGE", "message"},
                {"ATTEMPT", "attempt"},
                {"MASTER_DATA_WCF_INFO_ID", "masterDataWcfInfoId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("MASTER_DATA_SITE_INFO", new TableMapping("MASTER_DATA_SITE_INFO", "MasterDataSiteInfo", 6)
            {
                {"NAME", "name"},
                {"TIMEOUT_CHECKING", "timeoutChecking"},
                {"SITE_PATH", "sitePath"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"LOG_TYPE_INFO_ID", "logTypeInfoId"},
            });

            tables.Add("MASTER_DATA_SITE_CHECK_RESULTS", new TableMapping("MASTER_DATA_SITE_CHECK_RESULTS", "MasterDataSiteCheckResults", 7)
            {
                {"CHECK_STATUS", "checkStatus"},
                {"CHECK_DATE", "checkDate"},
                {"MESSAGE", "message"},
                {"ATTEMPT", "attempt"},
                {"MASTER_DATA_SITE_INFO_ID", "masterDataSiteInfoId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("LOG_TYPE_INFO", new TableMapping("LOG_TYPE_INFO", "LogTypeInfo", 3)
            {
                {"FILE_NAME", "fileName"},
                {"FILE_PATTERN", "filePattern"},
                {"FILE_PATH", "filePath"},
            });

            tables.Add("MASTER_DATA_MONITOR_STATE", new TableMapping("MASTER_DATA_MONITOR_STATE", "MasterDataMonitorState", 2)
            {
                {"RECONFIGURE", "reconfigure"},
                {"RECONFIGURE_CHECKING_TIMEOUT", "reconfigureCheckingTimeout"},
            });

        }
    }
}
