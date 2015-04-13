/****** Object: Server Trigger [SETTINGS_DATA_SYS_TABLES_FILL_TRIGGER]   Script Date: 13.04.2015 12:46:45 ******/
USE [master];
GO
IF EXISTS(SELECT * FROM SYS.ALL_OBJECTS WHERE [name] = 'SETTINGS_DATA_SYS_TABLES_FILL_TRIGGER')
  DROP TRIGGER [SETTINGS_DATA_SYS_TABLES_FILL_TRIGGER] ON ALL SERVER;
GO
CREATE TRIGGER [SETTINGS_DATA_SYS_TABLES_FILL_TRIGGER]
ON ALL SERVER
WITH EXEC AS CALLER
FOR DDL_TABLE_EVENTS
AS
BEGIN
DECLARE @data XML;
DECLARE @eventType nvarchar(max);
DECLARE @tableName sysname;
DECLARE @database sysname;
DECLARE @query nvarchar(max);
DECLARE @tableId int;

SET @data = EVENTDATA();

SELECT @eventType = @data.value('(/EVENT_INSTANCE/EventType)[1]', 'nvarchar(100)'),
     @tableName = @data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'sysname'),
     @database = @data.value('(/EVENT_INSTANCE/DatabaseName)[1]', 'sysname');

IF (@eventType = 'ALTER_TABLE')
BEGIN
SELECT TOP(1) @tableId = ID FROM SettingsData.dbo.SYS_TABLES WHERE NAME = @tableName;
IF (@tableId IS NOT NULL)
BEGIN
INSERT INTO SettingsData..SYS_COLUMNS (
   SYS_TABLE_ID
  ,[NAME]
) SELECT 
@tableId, t.n.value('.', 'sysname')
FROM  @data.nodes('/EVENT_INSTANCE/AlterTableActionList/Create/Columns/Name') t(n);
DELETE FROM SettingsData..SYS_COLUMNS 
WHERE SYS_TABLE_ID = @tableId AND NAME IN 
(SELECT t.n.value('.', 'sysname') FROM  @data.nodes('/EVENT_INSTANCE/AlterTableActionList/Drop/Columns/Name') t(n));
END
END
IF (@eventType = 'DROP_TABLE')
BEGIN
 DELETE col
 FROM SettingsData..SYS_COLUMNS col
 INNER JOIN SettingsData..SYS_TABLES tab ON col.SYS_TABLE_ID = tab.ID
 WHERE tab.NAME = @tableName;
 DELETE FROM SettingsData..SYS_TABLES WHERE NAME = @tableName;
END
IF (@eventType = 'CREATE_TABLE')
BEGIN


SET @query = CONCAT('INSERT INTO SettingsData.dbo.SYS_TABLES ([NAME], [DESCRIPTION])
    SELECT t.[name], CONVERT(NVARCHAR(256), ISNULL(ep.[value], '''')) FROM ', @database, '.sys.tables t
    LEFT JOIN ', @database, '.sys.extended_properties ep ON ep.major_id = t.[object_id] AND ep.minor_id = 0 AND ep.[name] = ''MS_Description''
    WHERE EXISTS (SELECT * FROM ', @database, '.sys.columns c WHERE c.[object_id] = t.[object_id] AND (c.name = ''FROM_DATE'' OR c.name = ''TO_DATE'')) AND t.name = ''', @tableName, '''');   
EXEC sys.sp_executesql @query;

SELECT TOP(1) @tableId = ID FROM SettingsData.dbo.SYS_TABLES WHERE NAME = @tableName;

SET @query = CONCAT('INSERT INTO SettingsData.dbo.SYS_COLUMNS (SYS_TABLE_ID, [NAME], [DESCRIPTION])
     (SELECT ', @tableId, ', c.[name], CONVERT (NVARCHAR(256), ISNULL(ep.[value], '''')) FROM ', @database,'.sys.columns c 
	   INNER JOIN ', @database, '.sys.tables t ON c.[object_id] = t.[object_id] AND t.[name] = ''', @tableName, '''
     LEFT JOIN ', @database, '.sys.extended_properties ep ON ep.major_id = t.[object_id] AND ep.minor_id = c.column_id AND ep.[name] = ''MS_Description'') AND t.name = ''', @tableName, '''');
END
END;
GO
ENABLE TRIGGER [SETTINGS_DATA_SYS_TABLES_FILL_TRIGGER] ON ALL SERVER;
GO

