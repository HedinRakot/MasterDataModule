USE [SettingsData]
GO

ALTER VIEW [dbo].[GET_JOBS_STATUS] 
AS
SELECT 
	 res.ID
	,res.CHECK_STATUS
	,res.CHECK_DATE
	,res.LAST_RUN_TIME
	,inf.[NAME]
	,inf.JOB_NAME
	,res.DELETE_DATE
	,res.CREATE_DATE
	,res.CHANGE_DATE
	,inf.LOG_TYPE_INFO_ID
FROM 
	[dbo].[MASTER_DATA_JOB_CHECK_RESULTS] res INNER JOIN
	[dbo].[MASTER_DATA_JOB_INFO] inf ON res.[MASTER_DATA_JOB_INFO_ID] = inf.ID
WHERE res.DELETE_DATE IS NULL
AND inf.DELETE_DATE IS NULL
GO

ALTER VIEW [dbo].[GET_SITES_STATUS] 
AS
SELECT 
	res.ID
	,res.CHECK_STATUS
	,res.CHECK_DATE
	,res.[MESSAGE]
	,res.ATTEMPT
	,inf.[NAME]
	,inf.SITE_PATH
	,res.DELETE_DATE
	,res.CREATE_DATE
	,res.CHANGE_DATE
	,inf.LOG_TYPE_INFO_ID
FROM 
	[dbo].[MASTER_DATA_SITE_CHECK_RESULTS] res INNER JOIN
	[dbo].[MASTER_DATA_SITE_INFO] inf ON res.[MASTER_DATA_SITE_INFO_ID] = inf.ID
GO

ALTER VIEW [dbo].[GET_WCF_SERVICES_STATUS] 
AS
SELECT 
	res.ID
	,res.CHECK_STATUS
	,res.CHECK_DATE
	,res.[MESSAGE]
	,res.ATTEMPT
	,inf.[NAME]
	,inf.WSDL_PATH
	,res.DELETE_DATE
	,res.CREATE_DATE
	,res.CHANGE_DATE
	,inf.LOG_TYPE_INFO_ID
FROM 
	[dbo].[MASTER_DATA_WCF_CHECK_RESULTS] res INNER JOIN
	[dbo].[MASTER_DATA_WCF_INFO] inf ON res.[MASTER_DATA_WCF_INFO_ID] = inf.ID
GO

ALTER VIEW [dbo].[GET_WIN_SERVICES_STATUS] 
AS
SELECT 
	 res.ID
	,res.CHECK_STATUS
	,res.CHECK_DATE
	,res.MESSAGE
	,res.ATTEMPT
	,inf.[NAME]
	,inf.MACHINE_NAME
	,res.DELETE_DATE
	,res.CREATE_DATE
	,res.CHANGE_DATE
	,inf.LOG_TYPE_INFO_ID
FROM 
	[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS] res INNER JOIN
	[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO] inf ON res.[MASTER_DATA_WINDOWS_SERVICE_INFO_ID] = inf.ID
WHERE res.DELETE_DATE IS NULL
AND inf.DELETE_DATE IS NULL
GO

