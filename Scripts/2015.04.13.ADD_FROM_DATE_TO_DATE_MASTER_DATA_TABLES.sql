USE SettingsData;

ALTER TABLE dbo.APPLICATION_LOGS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_JOB_CHECK_RESULTS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_JOB_INFO ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_MONITOR_STATE ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_NOTIFICATIONS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_SITE_CHECK_RESULTS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_SITE_INFO ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_SUBSCRIBERS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_WCF_CHECK_RESULTS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_WCF_INFO ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.MASTER_DATA_WINDOWS_SERVICE_INFO ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.SYS_COLUMNS ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.SYS_TABLES ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));
ALTER TABLE dbo.SYS_DB_VERSION ADD FROM_DATE datetime2(2) NOT NULL DEFAULT(GETDATE()), TO_DATE datetime2(2) NOT NULL DEFAULT(DATEADD(year, 1, GETDATE()));

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'TO_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Von Datum  EN:  Date from', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_DB_VERSION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';

EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:Bis Datum  EN:  Date to', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_DB_VERSION', @level2type=N'COLUMN', @level2name=N'TO_DATE';




