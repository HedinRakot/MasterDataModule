USE [master];
GO
IF EXISTS(SELECT * FROM SYS.ALL_OBJECTS WHERE [name] = 'SETTINGS_DATA_SYS_TABLES_EXT_PROPERTY_TRIGGER')
  DROP TRIGGER [SETTINGS_DATA_SYS_TABLES_EXT_PROPERTY_TRIGGER] ON ALL SERVER;
GO

CREATE TRIGGER [SETTINGS_DATA_SYS_TABLES_EXT_PROPERTY_TRIGGER]
ON ALL SERVER
FOR DDL_EXTENDED_PROPERTY_EVENTS
AS
BEGIN
  DECLARE @data XML;
  DECLARE @eventType nvarchar(max);
  DECLARE @objectName sysname;
  DECLARE @query nvarchar(max);
  DECLARE @objectType nvarchar(MAX);
  DECLARE @propertyValue nvarchar(MAX);
  DECLARE @propertyName nvarchar(MAX);

  SET @data = EVENTDATA();

  SELECT @eventType = @data.value('(/EVENT_INSTANCE/EventType)[1]', 'nvarchar(100)'),
       @objectName = @data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'sysname'),
       @objectType = @data.value('(/EVENT_INSTANCE/ObjectType)[1]', 'nvarchar(MAX)'),
       @propertyValue = @data.value('(/EVENT_INSTANCE/PropertyValue)[1]', 'nvarchar(MAX)'),
       @propertyName = @data.value('(/EVENT_INSTANCE/PropertyName)[1]', 'nvarchar(MAX)');

  IF (@propertyName = 'MS_Description')
  BEGIN
    IF (@objectType = 'COLUMN')         
    BEGIN
      DECLARE @tableName sysname;
      DECLARE @tableId int;
      SELECT @tableName = @data.value('(/EVENT_INSTANCE/TargetObjectName)[1]', 'sysname');
      SELECT TOP(1) @tableId = ID FROM SettingsData..SYS_TABLES WHERE [NAME] = @tableName;
      UPDATE SettingsData..SYS_COLUMNS SET [DESCRIPTION] = ISNULL(@propertyValue, '') WHERE SYS_TABLE_ID = @tableId AND NAME = @objectName;
    END;
    IF (@objectType = 'TABLE')
    BEGIN
      UPDATE SettingsData..SYS_TABLES SET [DESCRIPTION] = ISNULL(@propertyValue, '') WHERE [NAME] = @objectName;
    END;
  END;
END;
