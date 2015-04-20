﻿






	SET IDENTITY_INSERT [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ON;
	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 124 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(124, 'MASTERDATACONFIGURATION' ,'SiteInfosWithLastResult', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,124 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 124;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 125 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(125, 'MASTERDATACONFIGURATION' ,'WcfInfosWithLastResult', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,125 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 125;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 126 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(126, 'MASTERDATACONFIGURATION' ,'WinserviceInfosWithLastResult', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,126 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 126;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 127 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(127, 'MASTERDATACONFIGURATION' ,'JobsInfosWithLastResult', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,127 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 127;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 89 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(89, 'MASTERDATACONFIGURATION' ,'MasterDataWcfInfo', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,89 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 89;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 129 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(129, 'MASTERDATACONFIGURATION' ,'GetApplicationLogs', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,129 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 129;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 88 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(88, 'MASTERDATACONFIGURATION' ,'MasterDataWcfCheckResults', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,88 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 88;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 85 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(85, 'MASTERDATACONFIGURATION' ,'MasterDataSiteInfo', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,85 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 85;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 84 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(84, 'MASTERDATACONFIGURATION' ,'MasterDataSiteCheckResults', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,84 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 84;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 77 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(77, 'MASTERDATACONFIGURATION' ,'MasterDataMonitorState', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,77 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 77;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 1 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(1, 'MASTERDATACONFIGURATION' ,'ApplicationLogs', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,1 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 1;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 76 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(76, 'MASTERDATACONFIGURATION' ,'MasterDataJobInfo', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,76 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 76;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 75 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(75, 'MASTERDATACONFIGURATION' ,'MasterDataJobCheckResults', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,75 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 75;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 91 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(91, 'MASTERDATACONFIGURATION' ,'MasterDataWindowsServiceInfo', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,91 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 91;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 115 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(115, 'MASTERDATACONFIGURATION' ,'SysColumn', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,115 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 115;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 90 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(90, 'MASTERDATACONFIGURATION' ,'MasterDataWindowsServiceCheckResults', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,90 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 90;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 122 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(122, 'MASTERDATACONFIGURATION' ,'SysTable', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,122 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 122;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 82 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(82, 'MASTERDATACONFIGURATION' ,'Role', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,82 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 82;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 81 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(81, 'MASTERDATACONFIGURATION' ,'Permission', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,81 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 81;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 83 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(83, 'MASTERDATACONFIGURATION' ,'MasterDataRolePermissionRsp', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,83 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 83;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 87 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(87, 'MASTERDATACONFIGURATION' ,'User', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,87 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 87;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 132 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(132, 'MASTERDATACONFIGURATION' ,'GetWinServicesStatus', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,132 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 132;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 131 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(131, 'MASTERDATACONFIGURATION' ,'GetSitesStatus', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,131 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 131;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 130 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(130, 'MASTERDATACONFIGURATION' ,'GetJobsStatus', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,130 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 130;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 128 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(128, 'MASTERDATACONFIGURATION' ,'GetWcfServicesStatus', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,128 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 128;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 86 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(86, 'MASTERDATACONFIGURATION' ,'MasterDataSubscribers', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,86 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 86;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 78 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(78, 'MASTERDATACONFIGURATION' ,'MasterDataMonitorableInfoMasterDataNotificationsRsp', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,78 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 78;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 80 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(80, 'MASTERDATACONFIGURATION' ,'MasterDataNotificationsMasterDataSubscribersRsp', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,80 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 80;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 79 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(79, 'MASTERDATACONFIGURATION' ,'MasterDataNotifications', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,79 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 79;
	END;

	
	IF NOT EXISTS (SELECT ID FROM [SettingsData].[dbo].[MASTER_DATA_PERMISSION] WHERE ID = 123 )
	BEGIN
	INSERT INTO [SettingsData].[dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [DESCRIPTION], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES(123, 'MASTERDATACONFIGURATION' ,'LogTypeInfo', '' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));
	INSERT INTO [SettingsData].dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID ,MASTER_DATA_PERMISSION_ID ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
	VALUES (1 ,123 ,getdate() ,getdate() ,getdate() ,DATEADD(year, 1, GETDATE()));
	END;
	ELSE
	BEGIN
	UPDATE [SettingsData].[dbo].[MASTER_DATA_PERMISSION] SET DESCRIPTION = '' WHERE ID = 123;
	END;

	SET IDENTITY_INSERT [SettingsData].[dbo].[MASTER_DATA_PERMISSION] OFF;