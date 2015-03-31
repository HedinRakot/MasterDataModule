
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2015 13:10:34
-- Generated from EDMX file: D:\Projects\MasterDataModule\MonitoringAgent\MonitoringAgent.Data\Data\MasterDataMonitoringModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SettingsData];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[WcfServiceInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WcfServiceInfoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WcfServiceInfoSet'
CREATE TABLE [dbo].[WcfServiceInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [WsdlPath] nvarchar(max)  NOT NULL,
    [TimeoutChecking] int  NOT NULL
);
GO

-- Creating table 'WcfServiceInfoCheckResultSet'
CREATE TABLE [dbo].[WcfServiceInfoCheckResultSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CheckStatus] int  NULL,
    [CheckDate] datetime  NULL,
    [Message] nvarchar(max)  NULL,
    [Attempt] int  NULL,
    [WcfServiceInfoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'WcfServiceInfoSet'
ALTER TABLE [dbo].[WcfServiceInfoSet]
ADD CONSTRAINT [PK_WcfServiceInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WcfServiceInfoCheckResultSet'
ALTER TABLE [dbo].[WcfServiceInfoCheckResultSet]
ADD CONSTRAINT [PK_WcfServiceInfoCheckResultSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [WcfServiceInfoId] in table 'WcfServiceInfoCheckResultSet'
ALTER TABLE [dbo].[WcfServiceInfoCheckResultSet]
ADD CONSTRAINT [FK_WcfServiceInfoCheckResultWcfServiceInfo]
    FOREIGN KEY ([WcfServiceInfoId])
    REFERENCES [dbo].[WcfServiceInfoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WcfServiceInfoCheckResultWcfServiceInfo'
CREATE INDEX [IX_FK_WcfServiceInfoCheckResultWcfServiceInfo]
ON [dbo].[WcfServiceInfoCheckResultSet]
    ([WcfServiceInfoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------