USE [SettingsData];
GO
ALTER TABLE [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]
DROP CONSTRAINT [FK_MASTER_DATA_ROLE_PERMISSION_RSP_MASTER_DATA_PERMISSION_ID]
GO
ALTER TABLE [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]
DROP CONSTRAINT [FK_MASTER_DATA_ROLE_PERMISSION_RSP_MASTER_DATA_ROLE_ID]
GO
ALTER TABLE [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] 
ADD  CONSTRAINT [FK_MASTER_DATA_ROLE_PERMISSION_RSP_MASTER_DATA_PERMISSION_ID]
FOREIGN KEY ([MASTER_DATA_PERMISSION_ID])
REFERENCES [dbo].[MASTER_DATA_PERMISSION] ( [ID] )
ON DELETE CASCADE
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] 
ADD  CONSTRAINT [FK_MASTER_DATA_ROLE_PERMISSION_RSP_MASTER_DATA_ROLE_ID]
FOREIGN KEY ([MASTER_DATA_ROLE_ID])
REFERENCES [dbo].[MASTER_DATA_ROLE] ( [ID] )
ON DELETE CASCADE
ON UPDATE CASCADE
GO
DELETE FROM dbo.MASTER_DATA_PERMISSION;S
