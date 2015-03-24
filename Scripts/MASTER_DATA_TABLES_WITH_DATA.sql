USE [SettingsData];

IF EXISTS (SELECT OBJECT_ID FROM sys.tables where [name] = N'MASTER_DATA_ROLE_PERMISSION_RSP')
  DROP TABLE [MASTER_DATA_ROLE_PERMISSION_RSP];
  
IF EXISTS (SELECT OBJECT_ID FROM sys.tables where [name] = N'MASTER_DATA_USER')
  DROP TABLE [MASTER_DATA_USER];  
  
IF EXISTS (SELECT OBJECT_ID FROM sys.tables where [name] = N'MASTER_DATA_ROLE')
  DROP TABLE [MASTER_DATA_ROLE];
  
IF EXISTS (SELECT OBJECT_ID FROM sys.tables where [name] = N'MASTER_DATA_PERMISSION')
  DROP TABLE [MASTER_DATA_PERMISSION];
  
CREATE TABLE [dbo].[MASTER_DATA_ROLE] (
[ID] int IDENTITY(1, 1) NOT NULL,
[NAME] nvarchar(256) NOT NULL,
[CREATE_DATE] datetime2(2) NOT NULL,
[CHANGE_DATE] datetime2(2) NOT NULL,
[DELETE_DATE] datetime2(2) NULL,
[OWNER_ORG_ID] int NULL,
[VISIBILITY_ORG_ID] int NULL,
[CREATE_EMPLOYEE_ID] int NULL,
[CHANGE_EMPLOYEE_ID] int NULL,
[SOURCE] varchar(10) NULL,
[FROM_DATE] date NOT NULL,
[TO_DATE] date NOT NULL,
CONSTRAINT [PK_MASTER_DATA_ROLE]
PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[MASTER_DATA_PERMISSION] (
[ID] int NOT NULL,
[SYSTEM_NAME] nvarchar(256) NOT NULL,
[NAME] nvarchar(256) NOT NULL,
[CREATE_DATE] datetime2(2) NOT NULL,
[CHANGE_DATE] datetime2(2) NOT NULL,
[DELETE_DATE] datetime2(2) NULL,
[OWNER_ORG_ID] int NULL,
[VISIBILITY_ORG_ID] int NULL,
[CREATE_EMPLOYEE_ID] int NULL,
[CHANGE_EMPLOYEE_ID] int NULL,
[SOURCE] varchar(10) NULL,
[FROM_DATE] date NOT NULL,
[TO_DATE] date NOT NULL,
CONSTRAINT [PK_MASTER_DATA_PERMISSION_ID] PRIMARY KEY CLUSTERED ([ID] ASC)
);
 
CREATE TABLE [dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]
(
  [ID] int IDENTITY(1, 1) NOT NULL,
  [MASTER_DATA_ROLE_ID] int NOT NULL,
  [MASTER_DATA_PERMISSION_ID] int NOT NULL,
  [CREATE_DATE] datetime2(2) NOT NULL,
  [CHANGE_DATE] datetime2(2) NOT NULL,
  [DELETE_DATE] datetime2(2) NULL,
  [OWNER_ORG_ID] int NULL,
  [VISIBILITY_ORG_ID] int NULL,
  [CREATE_EMPLOYEE_ID] int NULL,
  [CHANGE_EMPLOYEE_ID] int NULL,
  [SOURCE] varchar(10) NULL,
  [FROM_DATE] date NOT NULL,
  [TO_DATE] date NOT NULL,
  CONSTRAINT [RK_MASTER_DATA_ROLE_PERMISSION_RSP_ID] PRIMARY KEY CLUSTERED ([ID]),
  CONSTRAINT [FK_MASTER_DATA_ROLE_PERMISSION_RSP_MASTER_DATA_PERMISSION_ID]
  FOREIGN KEY ([MASTER_DATA_PERMISSION_ID])
  REFERENCES [MASTER_DATA_PERMISSION] ([ID]),
  CONSTRAINT [FK_MASTER_DATA_ROLE_PERMISSION_RSP_MASTER_DATA_ROLE_ID]
  FOREIGN KEY ([MASTER_DATA_ROLE_ID])
  REFERENCES [MASTER_DATA_ROLE] ([ID])
);

CREATE TABLE [dbo].[MASTER_DATA_USER] (
[ID] int IDENTITY(1, 1) NOT NULL,
[MASTER_DATA_ROLE_ID] int NULL,
[LOGIN] nvarchar(128) NOT NULL,
[NAME] nvarchar(256) NOT NULL,
[PASSWORD] nvarchar(128) NOT NULL,
[CREATE_DATE] datetime2(2) NOT NULL,
[CHANGE_DATE] datetime2(2) NOT NULL,
[DELETE_DATE] datetime2(2) NULL,
[OWNER_ORG_ID] int NULL,
[VISIBILITY_ORG_ID] int NULL,
[CREATE_EMPLOYEE_ID] int NULL,
[CHANGE_EMPLOYEE_ID] int NULL,
[SOURCE] varchar(10) NULL,
[FROM_DATE] date NOT NULL,
[TO_DATE] date NOT NULL,
CONSTRAINT [PK_MASTER_DATA_USER_ID] PRIMARY KEY CLUSTERED ([ID] ASC),
CONSTRAINT [FK_MASTER_DATA_USER_MASTER_DATA_ROLE_ID] FOREIGN KEY ([MASTER_DATA_ROLE_ID])
REFERENCES [dbo].[MASTER_DATA_ROLE] ( [ID] )
);

INSERT INTO [dbo].[MASTER_DATA_PERMISSION] ([ID], [SYSTEM_NAME], [NAME], [CREATE_DATE], [CHANGE_DATE], [DELETE_DATE], [OWNER_ORG_ID], [VISIBILITY_ORG_ID], [CREATE_EMPLOYEE_ID], [CHANGE_EMPLOYEE_ID], [SOURCE], [FROM_DATE], [TO_DATE])
VALUES
(1000, 'ASPRO' ,'InsNextSpInterval' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1001, 'ASPRO' ,'InsObdStatus' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1002, 'ASPRO' ,'InsOpticalDefect' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1003, 'ASPRO' ,'InsProductClassGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1004, 'ASPRO' ,'InsSeverityType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1005, 'ASPRO' ,'SysLanguage' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1006, 'ASPRO' ,'InsValidPeriod' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1007, 'ASPRO' ,'InsCoreDataProduct' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1008, 'ASPRO' ,'InsPfpPosition' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1009, 'ASPRO' ,'InsPfpInspectionTypePfpPositionRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1010, 'ASPRO' ,'InsCoreDataProductLocalization' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1011, 'ASPRO' ,'InsPfpVehicleType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1012, 'ASPRO' ,'EmpEmployee' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1013, 'ASPRO' ,'InsUnitCode' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1014, 'ASPRO' ,'SysLocation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1015, 'ASPRO' ,'SysRole' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1016, 'ASPRO' ,'EmpCashPermissionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1017, 'ASPRO' ,'SysRoleSysPermissionRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1018, 'ASPRO' ,'EmpOrgAssociationType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1019, 'ASPRO' ,'OrgAccountType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1020, 'ASPRO' ,'InsAvailableInspectionText' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1021, 'ASPRO' ,'OrgAccountingArea' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1022, 'ASPRO' ,'InsAvailableInspectionTextValue' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1023, 'ASPRO' ,'OrgBankInformation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1024, 'ASPRO' ,'OrgCostCenter' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1025, 'ASPRO' ,'OrdFederalGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1026, 'ASPRO' ,'OrgCostCenterResponsibleEmployeeRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1027, 'ASPRO' ,'OrdFederalState' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1028, 'ASPRO' ,'OrgCostCenterPrice' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1029, 'ASPRO' ,'SysCountry' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1030, 'ASPRO' ,'SysPostCode' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1031, 'ASPRO' ,'OrdOrderCancelationReason' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1032, 'ASPRO' ,'OrgRelationshipType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1033, 'ASPRO' ,'KssExpenseGround' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1034, 'ASPRO' ,'OrgInformation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1035, 'ASPRO' ,'ExpPassengersType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1036, 'ASPRO' ,'OrgType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1037, 'ASPRO' ,'InsVatType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1038, 'ASPRO' ,'OrgInspectionDevice' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1039, 'ASPRO' ,'EmpEmployeeOrgCostCenterRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1040, 'ASPRO' ,'OrdBillingParameter' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1041, 'ASPRO' ,'EmpEmployeeOrgOrganizationalUnitRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1042, 'ASPRO' ,'OrdContactPersonFunction' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1043, 'ASPRO' ,'EmpEmployeeTopEmployeeRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1044, 'ASPRO' ,'OrdCustomerInfo' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1045, 'ASPRO' ,'EmpEmployeeSysRoleRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1046, 'ASPRO' ,'OrdPartnerRole' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1047, 'ASPRO' ,'InsTaxClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1048, 'ASPRO' ,'InsCoreDataProductGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1049, 'ASPRO' ,'InsProductCombinationType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1050, 'ASPRO' ,'InsProductMaterialGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1051, 'ASPRO' ,'InsProductObjectClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1052, 'ASPRO' ,'InsProductObjectType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1053, 'ASPRO' ,'OrgOrganizationalUnit' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1054, 'ASPRO' ,'InsProductType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1055, 'ASPRO' ,'InsStatisticGroup' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1056, 'ASPRO' ,'OrdAreaOfWork' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1057, 'ASPRO' ,'OrdRecognitionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1058, 'ASPRO' ,'OrdRecognition' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1059, 'ASPRO' ,'OrdRecognitionAreaOfWorkRsp' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1060, 'ASPRO' ,'InsTaxCode' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1061, 'ASPRO' ,'InsInspectionStep' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1062, 'ASPRO' ,'InsAvailableInspectionStep' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1063, 'ASPRO' ,'InsSummaryField' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(1064, 'ASPRO' ,'InsNextInspection' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2000, 'DRL' ,'MessageLocalization' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2001, 'DRL' ,'CoreDataProduct' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2002, 'DRL' ,'ReturnReason' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2003, 'DRL' ,'ExamPossibleResult' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2004, 'DRL' ,'SchoolInfo' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2005, 'DRL' ,'ArgeVersion' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2006, 'DRL' ,'Authority' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2007, 'DRL' ,'Community' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2008, 'DRL' ,'ExamRecognitionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2009, 'DRL' ,'CoreDataProductClassBasis' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2010, 'DRL' ,'CommunityParticipant' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2011, 'DRL' ,'ExamRecognitionTypeExamClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2012, 'DRL' ,'DriverSchool' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2013, 'DRL' ,'ExamRoom' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2014, 'DRL' ,'ExamStation' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2015, 'DRL' ,'DriverSchoolExamRecognitionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2016, 'DRL' ,'DriverSchoolInfo' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2017, 'DRL' ,'ExamStationExamRecognitionType' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2018, 'DRL' ,'Holiday' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2019, 'DRL' ,'ExamClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2020, 'DRL' ,'HolidayOrdFederalState' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2021, 'DRL' ,'Language' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2022, 'DRL' ,'ExamClassArgeMap' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2023, 'DRL' ,'LegalBasis' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2024, 'DRL' ,'ExamClassInclusiveClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2025, 'DRL' ,'ExamClassMap' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2026, 'DRL' ,'ExamClassRequiredClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2027, 'DRL' ,'CoreDataProductLocalization' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2028, 'DRL' ,'ExamClassRestrictedClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2029, 'DRL' ,'ExamConstraint' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2030, 'DRL' ,'MeetingPoint' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2031, 'DRL' ,'ExamConstraintExamClass' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()))
,(2032, 'DRL' ,'MeetingPointOrganizationalUnit' ,GETDATE() ,GETDATE() ,NULL, NULL, NULL, NULL, NULL, NULL, GETDATE(), DATEADD(year, 1, GETDATE()));

INSERT INTO dbo.MASTER_DATA_ROLE([NAME] ,CREATE_DATE ,CHANGE_DATE ,FROM_DATE ,TO_DATE) 
VALUES (N'Administrator', getdate(), getdate(), getdate() ,dateadd(year, 1, getdate()));

INSERT INTO dbo.MASTER_DATA_ROLE_PERMISSION_RSP(MASTER_DATA_ROLE_ID,MASTER_DATA_PERMISSION_ID,CREATE_DATE,CHANGE_DATE,FROM_DATE,TO_DATE) 
VALUES (1,1000,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1001,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1002,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1003,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1004,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1005,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1006,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1007,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1008,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1009,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1010,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1011,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1012,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1013,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1014,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1015,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1016,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1017,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1018,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1019,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1020,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1021,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1022,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1023,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1024,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1025,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1026,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1027,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1028,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1029,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1030,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1031,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1032,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1033,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1034,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1035,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1036,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1037,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1038,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1039,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1040,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1041,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1042,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1043,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1044,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1045,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1046,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1047,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1048,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1049,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1050,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1051,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1052,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1053,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1054,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1055,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1056,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1057,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1058,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1059,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1060,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1061,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1062,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1063,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,1064,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2000,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2001,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2002,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2003,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2004,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2005,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2006,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2007,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2008,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2009,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2010,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2011,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2012,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2013,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2014,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2015,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2016,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2017,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2018,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2019,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2020,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2021,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2022,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2023,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2024,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2025,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2026,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2027,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2028,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2029,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2030,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2031,getdate(),getdate(),getdate(),dateadd(year, 1, getdate())),
(1,2032,getdate(),getdate(),getdate(),dateadd(year, 1, getdate()));

INSERT INTO [dbo].[MASTER_DATA_USER] ([CREATE_DATE], [CHANGE_DATE], [FROM_DATE], [TO_DATE], [LOGIN], [CHANGE_EMPLOYEE_ID], [OWNER_ORG_ID], [NAME], [VISIBILITY_ORG_ID], [MASTER_DATA_ROLE_ID], [SOURCE], [PASSWORD], [DELETE_DATE], [CREATE_EMPLOYEE_ID])
VALUES ('2015-02-06T00:00:00', '2015-02-06T00:00:00', '2015-02-06', '2075-02-06', N'admin', NULL, NULL, N'Administrator', NULL, 1, NULL, N'27493c09676e5512a6b61e1826ff728a', NULL, NULL);
