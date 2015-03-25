INSERT INTO [dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
VALUES (1, 'MASTERDATACONFIGURATION' ,'SysColumn' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(2, 'MASTERDATACONFIGURATION' ,'Role' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(3, 'MASTERDATACONFIGURATION' ,'Permission' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(4, 'MASTERDATACONFIGURATION' ,'SysTable' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(5, 'MASTERDATACONFIGURATION' ,'MasterDataRolePermissionRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(6, 'MASTERDATACONFIGURATION' ,'User' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()));

INSERT INTO [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] ( [CREATE_DATE], [OWNER_ORG_ID], [CHANGE_EMPLOYEE_ID], [TO_DATE], [MASTER_DATA_ROLE_ID], [VISIBILITY_ORG_ID], [SOURCE], [CHANGE_DATE], [FROM_DATE], [DELETE_DATE], [MASTER_DATA_PERMISSION_ID], [CREATE_EMPLOYEE_ID])
VALUES ('2015-03-24T16:50:18.54', NULL, NULL, '2016-03-24', 1, NULL, NULL, '2015-03-24T16:50:18.54', '2015-03-24', NULL, 1, NULL)
INSERT INTO [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] ( [CREATE_DATE], [OWNER_ORG_ID], [CHANGE_EMPLOYEE_ID], [TO_DATE], [MASTER_DATA_ROLE_ID], [VISIBILITY_ORG_ID], [SOURCE], [CHANGE_DATE], [FROM_DATE], [DELETE_DATE], [MASTER_DATA_PERMISSION_ID], [CREATE_EMPLOYEE_ID])
VALUES ('2015-03-24T16:50:18.54', NULL, NULL, '2016-03-24', 1, NULL, NULL, '2015-03-24T16:50:18.54', '2015-03-24', NULL, 2, NULL)
INSERT INTO [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] ( [CREATE_DATE], [OWNER_ORG_ID], [CHANGE_EMPLOYEE_ID], [TO_DATE], [MASTER_DATA_ROLE_ID], [VISIBILITY_ORG_ID], [SOURCE], [CHANGE_DATE], [FROM_DATE], [DELETE_DATE], [MASTER_DATA_PERMISSION_ID], [CREATE_EMPLOYEE_ID])
VALUES ('2015-03-24T16:50:18.54', NULL, NULL, '2016-03-24', 1, NULL, NULL, '2015-03-24T16:50:18.54', '2015-03-24', NULL, 3, NULL)
INSERT INTO [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] ( [CREATE_DATE], [OWNER_ORG_ID], [CHANGE_EMPLOYEE_ID], [TO_DATE], [MASTER_DATA_ROLE_ID], [VISIBILITY_ORG_ID], [SOURCE], [CHANGE_DATE], [FROM_DATE], [DELETE_DATE], [MASTER_DATA_PERMISSION_ID], [CREATE_EMPLOYEE_ID])
VALUES ('2015-03-24T16:50:18.54', NULL, NULL, '2016-03-24', 1, NULL, NULL, '2015-03-24T16:50:18.54', '2015-03-24', NULL, 4, NULL)
INSERT INTO [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] ( [CREATE_DATE], [OWNER_ORG_ID], [CHANGE_EMPLOYEE_ID], [TO_DATE], [MASTER_DATA_ROLE_ID], [VISIBILITY_ORG_ID], [SOURCE], [CHANGE_DATE], [FROM_DATE], [DELETE_DATE], [MASTER_DATA_PERMISSION_ID], [CREATE_EMPLOYEE_ID])
VALUES ('2015-03-24T16:50:18.54', NULL, NULL, '2016-03-24', 1, NULL, NULL, '2015-03-24T16:50:18.54', '2015-03-24', NULL, 5, NULL)
INSERT INTO [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP] ( [CREATE_DATE], [OWNER_ORG_ID], [CHANGE_EMPLOYEE_ID], [TO_DATE], [MASTER_DATA_ROLE_ID], [VISIBILITY_ORG_ID], [SOURCE], [CHANGE_DATE], [FROM_DATE], [DELETE_DATE], [MASTER_DATA_PERMISSION_ID], [CREATE_EMPLOYEE_ID])
VALUES ('2015-03-24T16:50:18.54', NULL, NULL, '2016-03-24', 1, NULL, NULL, '2015-03-24T16:50:18.54', '2015-03-24', NULL, 6, NULL)