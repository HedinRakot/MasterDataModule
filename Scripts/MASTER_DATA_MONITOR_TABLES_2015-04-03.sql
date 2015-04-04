USE [SettingsData];

ALTER TABLE [dbo].[MASTER_DATA_SITE_INFO]
ADD [CREATE_DATE] [datetime2](2) NOT NULL default(getdate()),
[DELETE_DATE] [datetime2](2) NULL,
[CHANGE_DATE] [datetime2](2) NOT NULL default(getdate())
GO