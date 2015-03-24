﻿






	INSERT INTO [dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
	VALUES
(1000, 'ASPRO' ,'InsNextSpInterval' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1001, 'ASPRO' ,'InsObdStatus' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1002, 'ASPRO' ,'InsOpticalDefect' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1003, 'ASPRO' ,'InsProductClassGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1004, 'ASPRO' ,'InsSeverityType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1005, 'ASPRO' ,'SysLanguage' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1006, 'ASPRO' ,'InsValidPeriod' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1007, 'ASPRO' ,'InsCoreDataProduct' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1008, 'ASPRO' ,'InsPfpPosition' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1009, 'ASPRO' ,'InsPfpInspectionTypePfpPositionRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1010, 'ASPRO' ,'InsCoreDataProductLocalization' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1011, 'ASPRO' ,'InsPfpVehicleType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1012, 'ASPRO' ,'EmpEmployee' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1013, 'ASPRO' ,'InsUnitCode' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1014, 'ASPRO' ,'SysLocation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1015, 'ASPRO' ,'SysRole' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1016, 'ASPRO' ,'EmpCashPermissionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1017, 'ASPRO' ,'SysRoleSysPermissionRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1018, 'ASPRO' ,'EmpOrgAssociationType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1019, 'ASPRO' ,'OrgAccountType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1020, 'ASPRO' ,'InsAvailableInspectionText' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1021, 'ASPRO' ,'OrgAccountingArea' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1022, 'ASPRO' ,'InsAvailableInspectionTextValue' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1023, 'ASPRO' ,'OrgBankInformation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1024, 'ASPRO' ,'OrgCostCenter' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1025, 'ASPRO' ,'OrdFederalGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1026, 'ASPRO' ,'OrgCostCenterResponsibleEmployeeRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1027, 'ASPRO' ,'OrdFederalState' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1028, 'ASPRO' ,'OrgCostCenterPrice' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1029, 'ASPRO' ,'SysCountry' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1030, 'ASPRO' ,'SysPostCode' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1031, 'ASPRO' ,'OrdOrderCancelationReason' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1032, 'ASPRO' ,'OrgRelationshipType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1033, 'ASPRO' ,'KssExpenseGround' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1034, 'ASPRO' ,'OrgInformation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1035, 'ASPRO' ,'ExpPassengersType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1036, 'ASPRO' ,'OrgType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1037, 'ASPRO' ,'InsVatType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1038, 'ASPRO' ,'OrgInspectionDevice' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1039, 'ASPRO' ,'EmpEmployeeOrgCostCenterRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1040, 'ASPRO' ,'OrdBillingParameter' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1041, 'ASPRO' ,'EmpEmployeeOrgOrganizationalUnitRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1042, 'ASPRO' ,'OrdContactPersonFunction' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1043, 'ASPRO' ,'EmpEmployeeTopEmployeeRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1044, 'ASPRO' ,'OrdCustomerInfo' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1045, 'ASPRO' ,'EmpEmployeeSysRoleRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1046, 'ASPRO' ,'OrdPartnerRole' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1047, 'ASPRO' ,'InsTaxClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1048, 'ASPRO' ,'InsCoreDataProductGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1049, 'ASPRO' ,'InsProductCombinationType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1050, 'ASPRO' ,'InsProductMaterialGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1051, 'ASPRO' ,'InsProductObjectClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1052, 'ASPRO' ,'InsProductObjectType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1053, 'ASPRO' ,'OrgOrganizationalUnit' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1054, 'ASPRO' ,'InsProductType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1055, 'ASPRO' ,'InsStatisticGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1056, 'ASPRO' ,'OrdAreaOfWork' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1057, 'ASPRO' ,'OrdRecognitionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1058, 'ASPRO' ,'OrdRecognition' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1059, 'ASPRO' ,'OrdRecognitionAreaOfWorkRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1060, 'ASPRO' ,'InsTaxCode' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1061, 'ASPRO' ,'InsInspectionStep' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1062, 'ASPRO' ,'InsAvailableInspectionStep' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1063, 'ASPRO' ,'InsSummaryField' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))
,(1064, 'ASPRO' ,'InsNextInspection' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, -1, GETDATE()))