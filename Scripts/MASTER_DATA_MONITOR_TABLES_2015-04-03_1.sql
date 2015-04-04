SET QUOTED_IDENTIFIER OFF;
GO
USE [SettingsData];
GO
-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'APPLICATION_LOGS'
CREATE TABLE [dbo].[APPLICATION_LOGS] (
    [ID] int IDENTITY(1,1) NOT NULL,
	LOG_TYPE int NOT NULL,
	LOG_LEVEL int NOT NULL,
	[DATE] datetime2(2) NULL,
    [MESSAGE] nvarchar(max)  NOT NULL,
    [DELETE_DATE] datetime2(2) NULL,
	CHANGE_DATE datetime2(2) NOT NULL default(GETDATE()),
	CREATE_DATE datetime2(2) NOT NULL default(GETDATE())
	
);
GO
