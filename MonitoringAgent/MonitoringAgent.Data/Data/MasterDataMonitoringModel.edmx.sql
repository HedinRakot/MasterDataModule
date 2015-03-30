
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/30/2015 14:01:26
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
    [LastCheckStatus] smallint  NULL,
    [LastCheckDate] datetime  NULL,
    [Message] nvarchar(max)  NULL
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------