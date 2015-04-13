DECLARE @databases nvarchar(MAX) = 'CommonMasterData;FeMasterData;SettingsData;'

DELETE FROM SettingsData.dbo.SYS_COLUMNS;
DELETE FROM SettingsData.dbo.SYS_TABLES;

DECLARE @database nvarchar(MAX);
DECLARE @query nvarchar(MAX);
DECLARE @commaIndex int;

WHILE (NULLIF(@databases, '') IS NOT NULL)
BEGIN
SET @commaIndex = CHARINDEX(';', @databases);
SET @database = SUBSTRING(@databases, 0,  @commaIndex);
SET @databases = SUBSTRING(@databases, @commaIndex + 1, 100000);

SET @query = CONCAT('INSERT INTO SettingsData.dbo.SYS_TABLES ([NAME], [DESCRIPTION])
   SELECT t.[name], CONVERT(NVARCHAR(256), ISNULL(ep.[value], '''')) FROM ', @database, '.sys.tables t
    LEFT JOIN ', @database, '.sys.extended_properties ep ON ep.major_id = t.[object_id] AND ep.minor_id = 0 AND ep.[name] = ''MS_Description''
    WHERE EXISTS (SELECT * FROM ', @database, '.sys.columns c WHERE c.[object_id] = t.[object_id] AND (c.name = ''FROM_DATE'' OR c.name = ''TO_DATE''))');

EXEC sys.sp_executesql @query;

DECLARE @tableName sysname;                     
DECLARE @tableId int;

DECLARE table_cursor CURSOR FOR 
SELECT NAME, ID FROM SettingsData.dbo.SYS_TABLES;

OPEN table_cursor;
FETCH NEXT FROM table_cursor 
INTO @tableName, @tableId;

WHILE(@@FETCH_STATUS = 0)
BEGIN

SET @query = CONCAT('INSERT INTO SettingsData.dbo.SYS_COLUMNS (SYS_TABLE_ID, [NAME], [DESCRIPTION])
     (SELECT ', @tableId, ', c.[name], CONVERT (NVARCHAR(256), ISNULL(ep.[value], '''')) FROM ', @database,'.sys.columns c 
	 INNER JOIN ', @database, '.sys.tables t ON c.[object_id] = t.[object_id] AND t.[name] = ''', @tableName, '''
     LEFT JOIN ', @database, '.sys.extended_properties ep ON ep.major_id = t.[object_id] AND ep.minor_id = c.column_id AND ep.[name] = ''MS_Description'')');

EXEC sys.sp_executesql @query;

FETCH NEXT FROM table_cursor
INTO @tableName, @tableId;
                                       
END;
CLOSE table_cursor;
DEALLOCATE table_cursor;
END;