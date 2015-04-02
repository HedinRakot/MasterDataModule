
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/02/2015 15:24:16
-- Generated from EDMX file: D:\Projects\MasterDataModule\MonitoringAgent\MonitoringAgent.Data\Data\MasterDataMonitoringModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SettingsData];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

---- --------------------------------------------------
---- Dropping existing tables
---- --------------------------------------------------

--IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_INFO]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_WCF_INFO];
--GO
--IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_WCF_CHECK_RESULTS];
--GO
--IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_INFO]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_SITE_INFO];
--GO
--IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_SITE_CHECK_RESULTS];
--GO
--IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITOR_STATE]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_MONITOR_STATE];
--GO
--IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_JOB_INFO];
--GO
--IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
--    DROP TABLE [dbo].[MASTER_DATA_JOB_CHECK_RESULTS];
--GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MASTER_DATA_WCF_INFO'
CREATE TABLE [dbo].[MASTER_DATA_WCF_INFO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [WSDL_PATH] nvarchar(max)  NOT NULL,
    [TIMEOUT_CHECKING] int  NOT NULL
);
GO

-- Creating table 'MASTER_DATA_WCF_CHECK_RESULTS'
CREATE TABLE [dbo].[MASTER_DATA_WCF_CHECK_RESULTS] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CHECK_STATUS] int  NULL,
    [CHECK_DATE] datetime  NULL,
    [MESSAGE] nvarchar(max)  NULL,
    [ATTEMPT] int  NULL,
    [MASTER_DATA_WCF_INFO_ID] int  NOT NULL
);
GO

-- Creating table 'MASTER_DATA_SITE_INFO'
CREATE TABLE [dbo].[MASTER_DATA_SITE_INFO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [TIMEOUT_CHECKING] int  NOT NULL,
    [SITE_PATH] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MASTER_DATA_SITE_CHECK_RESULTS'
CREATE TABLE [dbo].[MASTER_DATA_SITE_CHECK_RESULTS] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CHECK_STATUS] int  NULL,
    [CHECK_DATE] datetime  NULL,
    [MESSAGE] nvarchar(max)  NULL,
    [ATTEMPT] int  NULL,
    [MASTER_DATA_SITE_INFO_ID] int  NOT NULL
);
GO

-- Creating table 'MASTER_DATA_MONITOR_STATE'
CREATE TABLE [dbo].[MASTER_DATA_MONITOR_STATE] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RECONFIGURE] bit  NULL,
    [RECONFIGURE_CHECKING_TIMEOUT] int  NOT NULL
);
GO

-- Creating table 'MASTER_DATA_JOB_INFO'
CREATE TABLE [dbo].[MASTER_DATA_JOB_INFO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CONNECTION_STRING] nvarchar(max)  NOT NULL,
    [TABLE_NAME] nvarchar(max)  NOT NULL,
    [TIMEOUT_CHECKING] int  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [JOB_NAME] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MASTER_DATA_JOB_CHECK_RESULTS'
CREATE TABLE [dbo].[MASTER_DATA_JOB_CHECK_RESULTS] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LAST_RUN_TIME] datetime  NULL,
    [CHECK_DATE] datetime  NULL,
    [CHECK_STATUS] int  NULL,
    [MASTER_DATA_JOB_INFO_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'MASTER_DATA_WCF_INFO'
ALTER TABLE [dbo].[MASTER_DATA_WCF_INFO]
ADD CONSTRAINT [PK_MASTER_DATA_WCF_INFO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MASTER_DATA_WCF_CHECK_RESULTS'
ALTER TABLE [dbo].[MASTER_DATA_WCF_CHECK_RESULTS]
ADD CONSTRAINT [PK_MASTER_DATA_WCF_CHECK_RESULTS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MASTER_DATA_SITE_INFO'
ALTER TABLE [dbo].[MASTER_DATA_SITE_INFO]
ADD CONSTRAINT [PK_MASTER_DATA_SITE_INFO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MASTER_DATA_SITE_CHECK_RESULTS'
ALTER TABLE [dbo].[MASTER_DATA_SITE_CHECK_RESULTS]
ADD CONSTRAINT [PK_MASTER_DATA_SITE_CHECK_RESULTS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MASTER_DATA_MONITOR_STATE'
ALTER TABLE [dbo].[MASTER_DATA_MONITOR_STATE]
ADD CONSTRAINT [PK_MASTER_DATA_MONITOR_STATE]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MASTER_DATA_JOB_INFO'
ALTER TABLE [dbo].[MASTER_DATA_JOB_INFO]
ADD CONSTRAINT [PK_MASTER_DATA_JOB_INFO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MASTER_DATA_JOB_CHECK_RESULTS'
ALTER TABLE [dbo].[MASTER_DATA_JOB_CHECK_RESULTS]
ADD CONSTRAINT [PK_MASTER_DATA_JOB_CHECK_RESULTS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MASTER_DATA_WCF_INFO_ID] in table 'MASTER_DATA_WCF_CHECK_RESULTS'
ALTER TABLE [dbo].[MASTER_DATA_WCF_CHECK_RESULTS]
ADD CONSTRAINT [FK_MASTER_DATA_WCF_INFO_CHECK_RESULTS_MASTER_DATA_WCF_INFO_ID]
    FOREIGN KEY ([MASTER_DATA_WCF_INFO_ID])
    REFERENCES [dbo].[MASTER_DATA_WCF_INFO]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MASTER_DATA_WCF_INFO_CHECK_RESULTS_MASTER_DATA_WCF_INFO_ID'
CREATE INDEX [IX_FK_MASTER_DATA_WCF_INFO_CHECK_RESULTS_MASTER_DATA_WCF_INFO_ID]
ON [dbo].[MASTER_DATA_WCF_CHECK_RESULTS]
    ([MASTER_DATA_WCF_INFO_ID]);
GO

-- Creating foreign key on [MASTER_DATA_SITE_INFO_ID] in table 'MASTER_DATA_SITE_CHECK_RESULTS'
ALTER TABLE [dbo].[MASTER_DATA_SITE_CHECK_RESULTS]
ADD CONSTRAINT [FK_MASTER_DATA_SITE_INFO_CHECK_RESULTS_MASTER_DATA_SITE_INFO_ID]
    FOREIGN KEY ([MASTER_DATA_SITE_INFO_ID])
    REFERENCES [dbo].[MASTER_DATA_SITE_INFO]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MASTER_DATA_SITE_INFO_CHECK_RESULTS_MASTER_DATA_SITE_INFO_ID'
CREATE INDEX [IX_FK_MASTER_DATA_SITE_INFO_CHECK_RESULTS_MASTER_DATA_SITE_INFO_ID]
ON [dbo].[MASTER_DATA_SITE_CHECK_RESULTS]
    ([MASTER_DATA_SITE_INFO_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------