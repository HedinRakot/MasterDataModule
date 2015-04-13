IF OBJECT_ID(N'[Schema].[Table]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'Schema', @level1type = N'TABLE', @level1name = N'Table';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: De  EN: En', @level0type = N'SCHEMA', @level0name = N'Schema', @level1type = N'TABLE', @level1name = N'Table';
END
IF OBJECT_ID(N'[dbo].[APPLICATION_LOGS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Applikation-Logs  EN: Applications logs', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS';
END
IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: DE: Wcf service status  EN: Wcf service status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Hintergrundprozess Monitor  EN: Job check result', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Hintergrundprozess Einstellungen  EN: Job info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITOR_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Monitor Einstellungen  EN: Monitor settings', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachrichten Einstellungen  EN: Monitorable object to notification', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachrichten  EN: Notifications', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachrichten Empfänger  EN: Notification to subscriber', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_PERMISSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Berechtigung  EN: Master data permission', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Rolle  EN: Master data role', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Berechtigung  EN: Master data permissiom', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Site Monitor  EN: Site check result', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Site Einstellungen  EN: Master data sites', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_SUBSCRIBERS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Monitor Empfänger  EN: Subscribers', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Benutzer  EN: Master data user', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Services Monitor  EN: Wcf check result', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Services Einstellungen  EN: Wcf info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Windows Services Monitor  EN: Windows service check results', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS';
END
IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Windows Services Einstellungen  EN: Windows service info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO';
END
IF OBJECT_ID(N'[dbo].[SYS_COLUMNS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Spalte  EN: Master data column', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS';
END
IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Tabelle  EN: Master data table', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES';
END
