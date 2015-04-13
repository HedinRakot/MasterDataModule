IF OBJECT_ID(N'[dbo].[APPLICATION_LOGS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Applikation-Logs  EN: Applications logs', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: DE: Wcf service status  EN: Wcf service status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Hintergrundprozess Monitor  EN: Job check result
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'ConfiguraSchema';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Table	Column	De  EN: En
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'ConfiguraSchema';
END

IF OBJECT_ID(N'[dbo].[APPLICATION_LOGS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'LOG_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Log-Typ  EN: Logs type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'LOG_TYPE';
END

IF OBJECT_ID(N'[dbo].[APPLICATION_LOGS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'LOG_LEVEL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Log-Stufe  EN: logs level
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'LOG_LEVEL';
END

IF OBJECT_ID(N'[dbo].[APPLICATION_LOGS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Datum  EN: Date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'DATE';
END

IF OBJECT_ID(N'[dbo].[APPLICATION_LOGS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Text  EN: Text
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'APPLICATION_LOGS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[DATA].[DRL_ARGE_VERSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'PROGRAMM_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Programm-Name  EN: Exam-Programm
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'PROGRAMM_NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_ARGE_VERSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'VERSION_SYSTEM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Version  EN: Version of Exam-Programm
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'VERSION_SYSTEM';
END

IF OBJECT_ID(N'[DATA].[DRL_ARGE_VERSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'EXPIRATION_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Version gültig bis  EN: Expiration Date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'EXPIRATION_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_ARGE_VERSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_ARGE_VERSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'AUTHORITY_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Behördenschlüssel  EN: Authority Number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'AUTHORITY_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name der Behörde  EN: Authority Name
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Behörde  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'IS_CERTIFICATE_REQUIRED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Ausbildungsbescheinigung von der Behörde gefordert wird   EN: indication whether Education Certificates should to be sent back prematurely
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'IS_CERTIFICATE_REQUIRED';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'RETURN_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rückmeldeweg von Prüfaufträgen an die Behörde („1“ = „Online“, „2“ = „Papier“)  EN: way to return information back to Authority(1 - Online, 2 - Paper)
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'RETURN_TYPE';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'NAME_2';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name 2  EN: Name 2
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'NAME_2';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'STREET_HOUSE_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Strasse und Hausnummer  EN: Street and house number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'STREET_HOUSE_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'ZIP_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: PLZ  EN: Zip code
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'ZIP_CODE';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'CITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ort  EN: City
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'CITY';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Land  EN: Country
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'PHONE_1';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Telefonnummer 1  EN: Phone number 1
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'PHONE_1';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'PHONE_2';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Telefonnummer 2  EN: Phone number 2
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'PHONE_2';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'FAX';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fax  EN: Fax
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'FAX';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Führende Fahrschule der Fahrschulgemeinschaft   EN: Leading school
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY_PARTICIPANT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID_PARTICIPANT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitglied Fahrschule  EN: Participant
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID_PARTICIPANT';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY_PARTICIPANT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID_LEAD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: führende Fahrschule  EN: Driverschool lead
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID_LEAD';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY_PARTICIPANT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY_PARTICIPANT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt  EN: Product
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'POINT_AMOUNT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anzahl der Punkte des Produkts  EN: Point amount
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'POINT_AMOUNT';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'MIN_AGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mindestalter des Bewerbers  EN: Min age
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'MIN_AGE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'MAX_AGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Höchstalter des Bewerbers  EN: Max age
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'MAX_AGE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'EXAM_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfungsart  EN: Exam type
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'EXAM_TYPE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'PRIOR_TIME_IN_MONTHS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Vorzeitige Prüfung in Monaten  EN: Prior time in month
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'PRIOR_TIME_IN_MONTHS';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'EXPIRATION_IN_MONTH';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Verfallsfrist der Leistung in Monaten  EN: Expiration in month
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'EXPIRATION_IN_MONTH';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'REPEAT_TIME_IN_DAYS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Wiederholungsfrist in Tagen  EN: Repeat time in days
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'REPEAT_TIME_IN_DAYS';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'TRAINING_CERT_FLAG';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ausbildungsbescheinigung notwendig  EN: Training certificate required
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'TRAINING_CERT_FLAG';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'RESULT_FLAG';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ergebnis notwendig  EN: Result required
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'RESULT_FLAG';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'MULTIPLY_FLAG';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Leistung mehrfach möglich  EN: Can be multiple
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'MULTIPLY_FLAG';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_MOFA_PRINT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mofaprüfbescheinigung  EN: Is Mofa print product
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_MOFA_PRINT';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_ADDITIONAL_PRODUCT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zusatzleistung  EN: Is additional product
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_ADDITIONAL_PRODUCT';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_PREPAYMENT_REQUIRED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Vorzahlung erforderlich  EN: Prepayment required
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_PREPAYMENT_REQUIRED';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_MANDATORY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Pflicht Produkt  EN: Is mandatory
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_MANDATORY';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'FE_PRODUCT_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Produktnummer  EN: FE product number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'FE_PRODUCT_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'REPEAT_TIME_IN_DAYS_REDUCED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: abgekürzte Wiederholungsfrist in Tagen  EN: Reduced repeat time in days
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'REPEAT_TIME_IN_DAYS_REDUCED';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Klasse   EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_CORE_DATA_PRODUCT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt  EN: Product
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_CORE_DATA_PRODUCT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_LEGAL_BASIS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rechtsgrund  EN: Legalbasis
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_LEGAL_BASIS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'SORT_ORDER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sortierreihenfolge  EN: Sort order
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'SORT_ORDER';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'DRL_CORE_DATA_PRODUCT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt  EN: Product
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'DRL_CORE_DATA_PRODUCT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachschlüssel   EN: Language
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'PRODUCT_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'PRODUCT_NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bescreibung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'DRIVER_SCHOOL_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschulnummer  EN: Driverschool number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'DRIVER_SCHOOL_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'ORD_CUSTOMER_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kunde  EN: Customer
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'ORD_CUSTOMER_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschule  EN: Driverschool
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_RECOGNITION_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anerkennung  EN: Recognition
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_RECOGNITION_TYPE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_INFO_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschule  EN: Driverschool
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'DRL_DRIVER_SCHOOL_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_INFO_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'DRL_SCHOOL_INFO_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Informationswert  EN: Info
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'DRL_SCHOOL_INFO_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_INFO_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_INFO_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurz-Bezeichnung der FE-Klasse  EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'IS_MOFA';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob FE-Klasse eine Mofa-Prüfbescheinigung ist   EN: Indication that it is MOFA
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'IS_MOFA';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'IS_FS_CLASS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob für die FE-Klasse ein Führerschein ausgestellt werden kann  EN: Indication whether class should be showed as driver licence class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'IS_FS_CLASS';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'SORT_ORDER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sortierreihenfolge  EN: Sort order
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'SORT_ORDER';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_ARGE_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: übergeordnete Klasse   EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_ARGE_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'EXAM_NAME_ARGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: ARGE-Klassenbezeichnung  EN: ARGE exam class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'EXAM_NAME_ARGE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_ARGE_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_ARGE_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: übergeordnete Klasse   EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_INCLUSIVE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Inklusiv-Klasse   EN: inclusiv class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_INCLUSIVE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'IS_CONDITIONAL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zeigt an, ob zusaetzliche Vorauszetzungen vorhanden sind  EN: Indication whether additional condition exists
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'IS_CONDITIONAL';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_ACTUAL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Klasse, der eine Alt-Klasse zugeordnet wird  EN: Class old
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_ACTUAL';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_OLD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Verweis auf die Alt-Klasse   EN: Actual class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_OLD';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_REQUIRED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: übergeordnete Klasse   EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_REQUIRED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_REQUIRED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Voraussetzungsklasse  EN: Required Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_REQUIRED';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_REQUIRED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_REQUIRED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: übergeordnete Klasse   EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_RESTRICTED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Klasse mit Beschraenkung  EN: Exam class with restrictions
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID_RESTRICTED';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbeschreibung der FE-Auflage  EN: Constraint Name
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der FE-Auflage  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'CONSTRAINT_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Auflagentyp  EN: Type of the Contraint
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'CONSTRAINT_TYPE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CONSTRAINT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Auflage, der eine FE-Klasse zugeordnet wird   EN: Constraint
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CONSTRAINT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: zugeordnete FE-Klasse   EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbeschreibung des Prüfleistungsergebnisses  EN: Exam Result
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Prüfleistungsergebnisses  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'IS_FEE_PAYABLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob die Gebühr bei diesem Ergebnis fällig wird   EN: Indication whether fee is due
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'IS_FEE_PAYABLE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'EXAM_COUNTER_FLAG';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob der Prüfleistungszähler bei diesem Ergebnis hochgesetzt werden muss   EN: Indication whether exam counter increases
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'EXAM_COUNTER_FLAG';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'NEXT_EXAM_PRODUCT_FLAG';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob bei diesem Ergebnis eine Folgeleistung angelegt werden muss   EN: Indication whether next exam product is required
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'NEXT_EXAM_PRODUCT_FLAG';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'DRIVER_LICENCE_FLAG';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob bei diesem Ergebnis der Führerschein ausgehändig werden kann   EN: Indication whether Driver Licence can be handed over
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'DRIVER_LICENCE_FLAG';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'IS_MEDICAL_ATTEST_REQUIRED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob bei diesem Ergebnis ein ärztliches Attest notwendig ist  EN: Is medical attest required
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'IS_MEDICAL_ATTEST_REQUIRED';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Anerkennung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Anerkennung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_RECOGNITION_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anerkennung, der eine FE-Klasse zugeordnet wird  EN: Recognition Type
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_RECOGNITION_TYPE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: zugeordnete FE-Klasse  EN: Class
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_CLASS_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ROOM_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfraum-Nummer  EN: Exam Room Number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ROOM_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'PLACE_AMOUNT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anzahl der Plätze  EN: Amount of places
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'PLACE_AMOUNT';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ORG_ORGANIZATIONAL_UNIT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Organisationseinheit   EN: Organizational Unit
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ORG_ORGANIZATIONAL_UNIT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'NAME_1';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name 1  EN: Name 1
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'NAME_1';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'NAME_2';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name 2  EN: Name 2
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'NAME_2';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'NAME_3';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name 3  EN: Name 3
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'NAME_3';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'STREET_HOUSE_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Strasse und Hausnummer  EN: Street and house number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'STREET_HOUSE_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ZIP_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: PLZ  EN: Zip code
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ZIP_CODE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ZIP_BOX';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: PLZ  EN: Zip code of postal box
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'ZIP_BOX';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'BOX';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Postfach  EN: Postal box
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'BOX';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'CITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ort  EN: City
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'CITY';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'PHONE_1';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Telefonnummer 1  EN: Phone number 1
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'PHONE_1';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'FAX';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fax  EN: Fax
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'FAX';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'EMAIL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: E-Mail  EN: Email
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'EMAIL';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Land  EN: Country
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'PLACE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüforts-Bezeichnung   EN: Location (Place)
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'PLACE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des FE-Prüforts  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundesland   EN: Federal State
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'SORT_ORDER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sortier-Reihenfolge  EN: Sort order
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'SORT_ORDER';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_STATION_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Prüfort  EN: Exam Station
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_STATION_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_RECOGNITION_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: zugeordnete FE-Anerkennung   EN: Recognition Type
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_EXAM_RECOGNITION_TYPE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Datum des Feiertags  EN: Validation error number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Feiertags  EN: Message language
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_HOLIDAY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Feiertag   EN: Holiday
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'DRL_HOLIDAY_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: zugeordnete Bundesland   EN: Federal State
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachschlüssel   EN: Language
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'OLD_ABBR';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Alter Sprachschlüssel aus VF97  EN: Abbreviation in old System
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'OLD_ABBR';
END

IF OBJECT_ID(N'[DATA].[DRL_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurz-Bezeichnung des FE-Rechtsgrunds  EN: Legal Basis
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der FE-Rechtsgrunds  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'EDUCATION_CERTIFICATE_REQUIRED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob eine Ausbildungsbescheinigung notwendig ist   EN: Indication whether Education Certificate is required
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'EDUCATION_CERTIFICATE_REQUIRED';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'FIRST_ASSIGNATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob es sich um eine Ersterteilung handelt  EN: Indication whether it is first assignation of the driver licence
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'FIRST_ASSIGNATION';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'MESSAGE_REASON';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitteilungsgrund  EN: Statement regarding Message Reason
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'MESSAGE_REASON';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'MESSAGE_REASON_STYLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Art der Mitteilung  EN: Statement regarding ADMI2 (Type of Message)
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'MESSAGE_REASON_STYLE';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'REPLACEMENT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Erzarz-Rechtsgrund die wird beim Wechsel von Ersterteilung nach Erweiterung benutzt (falls eine Theorie bestanden)  EN: Legal basis for replacement First assignation on Extending
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'REPLACEMENT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'PRINT_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name auf dem Druckformular  EN: Print name
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'PRINT_NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung des FE-Treffpunkts   EN: Meeting Point
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des FE-Treffpunkts  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'DRL_MEETING_POINT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Treffpunkt   EN: Meeting Point
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'DRL_MEETING_POINT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'ORG_ORGANIZATIONAL_UNIT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: zugeordnete Organisationseinheit   EN: Organizational Unit
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'ORG_ORGANIZATIONAL_UNIT_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_MESSAGE_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'VALIDATION_ERROR_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fehlernummer  EN: Validation error number
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'VALIDATION_ERROR_NUMBER';
END

IF OBJECT_ID(N'[DATA].[DRL_MESSAGE_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachschlüssel   EN: Message language
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
END

IF OBJECT_ID(N'[DATA].[DRL_MESSAGE_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Meldungstext  EN: Message text
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[DATA].[DRL_MESSAGE_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_MESSAGE_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung  EN: Reason for returning the Driver Licence to Authority
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Rückgabegrunds  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'TEXT_1';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zusatztext 1  EN: Text 1
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'TEXT_1';
END

IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'TEXT_2';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zusatztext 2  EN: Text 2
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'TEXT_2';
END

IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_SCHOOL_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:  	Kurzbeschreibung des Fahrschulinformationstyps  EN: Description
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[DATA].[DRL_SCHOOL_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'TEXT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Fahrschulinformationstyps  EN: Text
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'TEXT';
END

IF OBJECT_ID(N'[DATA].[DRL_SCHOOL_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[DATA].[DRL_SCHOOL_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_CASH_PERMISSION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung des Auszahlungsgrunds  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_CASH_PERMISSION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Auszahlungsgrund  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[EMP_CASH_PERMISSION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_CASH_PERMISSION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'PERSONAL_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Personalnummer  EN: Personal number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'PERSONAL_NUMBER';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'DOMAIN';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Domäne des Users (z.B. „DE001“)  EN: Domain
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'DOMAIN';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'USER_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anmeldenamen für ASPRO-Anmeldung  EN: User name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'USER_NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'WINDOWS_USER_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anmeldenamen für Single-Sign-On-Anmeldung  EN: Windows user name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'WINDOWS_USER_NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'IS_SSO_ALLOWED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Single-Sign-On-Anmeldung möglich   EN: Is SSO allowed
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'IS_SSO_ALLOWED';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'IS_PASSWORD_LOGIN_ALLOWED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:  	User/Passwort-Anmeldung möglich   EN: Is password login allowed
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'IS_PASSWORD_LOGIN_ALLOWED';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'IS_EMERGENCY_LOGIN_ALLOWED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Notfallanmeldung möglich   EN: Is emergency login allowed
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'IS_EMERGENCY_LOGIN_ALLOWED';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Vorname  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'MIDDLE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zweiter Vorname  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'MIDDLE_NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'LAST_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nachname  EN: Lastname
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'LAST_NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'COMMENT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bemerkung  EN: Comment
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'COMMENT';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'SEX_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Geschlecht   EN: Sex
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'SEX_TYPE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'TITLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Titel  EN: Title
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'TITLE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'BIRTHDATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Geburtsdatum  EN: Birthdate
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'BIRTHDATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_COST_CENTER_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitarbeiter  EN: Employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_COST_CENTER_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'ORG_COST_CENTER_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstelle  EN: Cost center
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'ORG_COST_CENTER_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_COST_CENTER_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_COST_CENTER_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitarbeiter  EN: Employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'ORG_ORGANIZATIONAL_UNIT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE/TSC  EN: Org unit
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'ORG_ORGANIZATIONAL_UNIT_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_SYS_ROLE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitarbeiter  EN: Employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_SYS_ROLE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'SYS_ROLE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rolle  EN: Role
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'SYS_ROLE_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_SYS_ROLE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_SYS_ROLE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_TOP_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitarbeiter  EN: Employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_TOP_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'TOP_EMPLOYEE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Vorgesetzter  EN: Top employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'TOP_EMPLOYEE_ID';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_TOP_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_TOP_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_LOGIN_DATA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitarbeiter  EN: Employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'ID';
END

IF OBJECT_ID(N'[dbo].[EMP_LOGIN_DATA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'IS_BLOCKED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sperre des Users   EN: Is blocked
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'IS_BLOCKED';
END

IF OBJECT_ID(N'[dbo].[EMP_LOGIN_DATA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'PASSWORD_ENTRY_ATTEMPT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anzahl der Anmeldeversuche  EN: Password entry attempt
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'PASSWORD_ENTRY_ATTEMPT';
END

IF OBJECT_ID(N'[dbo].[EMP_LOGIN_DATA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_LOGIN_DATA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_ORG_ASSOCIATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung der Zuordnungsart  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[EMP_ORG_ASSOCIATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Zuordnungsart  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[EMP_ORG_ASSOCIATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EMP_ORG_ASSOCIATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[EXP_PASSENGERS_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitfahrerart  EN: Code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'CODE';
END

IF OBJECT_ID(N'[dbo].[EXP_PASSENGERS_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'TEXT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Mitfahrerart  EN: Text
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'TEXT';
END

IF OBJECT_ID(N'[dbo].[EXP_PASSENGERS_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[EXP_PASSENGERS_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'INS_AVAILABLE_INSPECTION_TEXT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Textschlüssel   EN: Text
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'INS_AVAILABLE_INSPECTION_TEXT_ID';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachschlüssel   EN: Language
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'INS_INSPECTION_STEP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Prüfschritts   EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'INS_INSPECTION_STEP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'IS_MANDATORY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Prüfschritt ein Pflichtprüfschritt ist  EN: Is mandatory
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'IS_MANDATORY';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'IS_ALL_TESTS_AVAILABLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Prüfschritt für alle Prüfungen verfügbar ist  EN: Is all test available
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'IS_ALL_TESTS_AVAILABLE';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'PRINTER_POSITION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Position im Ausdruck (wird aktuell nicht verwendet)  EN: Printer position
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'PRINTER_POSITION';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'PROCESSING_POSITION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Position in der Abarbeitung (wird aktuell nicht verwendet)  EN: Processing position
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'PROCESSING_POSITION';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'PRODUCT_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktnummer  EN: Product number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'PRODUCT_NUMBER';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_NEXT_INSPECTION_PRODUCT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Produkt eine Nachprüfung ist  EN: Is next inspection product
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_NEXT_INSPECTION_PRODUCT';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_PROVISION_COST_MAY_BE_CALCULATED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob für Produkt Gestellungskosten verrechnet werden können  EN: Is provision cost may be calculated
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_PROVISION_COST_MAY_BE_CALCULATED';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'PRICE_REPORT_REQUIRED';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zahlungsbericht erforderlich  EN: Price report required
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'PRICE_REPORT_REQUIRED';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkttyp   EN: Product type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Gewichtsklasse  EN: Object class
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_CLASS_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Objekttyp    EN: Object type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_MATERIAL_GROUP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Materialgruppe  EN: Material group
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_MATERIAL_GROUP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse  EN: Product class
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_CLASS_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_GROUP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Arbeitswert/Zeitdauer  EN: Product group
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_GROUP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_INGENER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Produkt eine Ingenieursleistung ist  EN: Is ingeneur
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_INGENER';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_PRODUCTIVE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Produkt eine Produktivleistung ist („0“ = Aufwandserfassung unproduktiv, „1“ = Produktiv (TP), „2“ = Aufwandserfassung produktiv)  EN: Is productive
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_PRODUCTIVE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_KM_GELD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Produkt eine Kilometergeld-Leistung für den Verkauf an Kunden ist  EN: Is KM Geld
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_KM_GELD';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_OTHER_MATERIAL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Produkt eine besondere Leistung ist  EN: Is other material
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_OTHER_MATERIAL';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_TRIP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt ist Reisezeitprodukt für Aufwandsrückmeldung  EN: Is trip
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'IS_TRIP';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'REUSAGE_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Produkt mehrfach in einem Auftrag erbracht werden kann („0“ = Anzahl immer 1, „1“ = Mehrfach ganzzahlig, „2“ = Mehrfach (>0) mit 2 Nachkommastellen  EN: Reusage type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'REUSAGE_TYPE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_TAX_CODE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Steuerkennzeichen  EN: Tax code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'INS_TAX_CODE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'OLD_PRODUCT_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Alte VF97-Produktnummer  EN: Old product number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'OLD_PRODUCT_NUMBER';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bezeichnung des Arbeitswerts  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'DEFAULT_DURATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zeitliche Dauer des Arbeitswerts in Minuten  EN: Default duration
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'DEFAULT_DURATION';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt  EN: Product
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachschlüssel   EN: Language
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'SYS_LANGUAGE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'PRODUCT_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'PRODUCT_NAME';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bescreibung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Prüfschritts  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'IS_ALL_TESTS_AVAILABLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Prüfschritt für alle Prüfungen verfügbar ist  EN: Is all test available
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'IS_ALL_TESTS_AVAILABLE';
END

IF OBJECT_ID(N'[dbo].[INS_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_INSPECTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Nachprüfung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_INSPECTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_INSPECTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Objekttyp   EN: Object type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Gewichtsklasse   EN: Object class
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'INS_PRODUCT_OBJECT_CLASS_ID';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'AGE_MONTH_FROM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Minimales Alter des Fahrzeugs in Monaten  EN: Age month from
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'AGE_MONTH_FROM';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'AGE_MONTH_TO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Maximales Alter des Fahrzeugs in Monaten  EN: Age month to
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'AGE_MONTH_TO';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'SP_INTERVAL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Intervall in Monaten  EN: SP interval
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'SP_INTERVAL';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_OBD_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Schlüsselwert des OBD-Status  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[INS_OBD_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des OBD-Status  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_OBD_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'AU_VIEW';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Gültig für Benzin (b) oder Diesel (d), Auswahl über Kombobox  EN: AU View
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'AU_VIEW';
END

IF OBJECT_ID(N'[dbo].[INS_OBD_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_OBD_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Schlüsselwert des optischen Mangels  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des optischen Mangels  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'IS_SELECTABLE_TWICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob der optische Mangel mehrfach zugeordnet werden kann  EN: Is selectable twice
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'IS_SELECTABLE_TWICE';
END

IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'IS_CUSTOM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Anwender zum optischen Mangel eine Bemerkung angeben kann   EN: Is custom
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'IS_CUSTOM';
END

IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name der PFP- Baugruppe  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der PFP-Baugruppe  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'INS_PFP_INSPECTION_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: PFP-Baugruppe   EN: Inspection type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'INS_PFP_INSPECTION_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'INS_PFP_POSITION_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: PFP-Prüfposition   EN: Position
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'INS_PFP_POSITION_ID';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_POSITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'TEXT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Text der PFP-Prüfposition  EN: Text
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'TEXT';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_POSITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'TOP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Top id  EN: Top id
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'TOP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_POSITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_POSITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_VEHICLE_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name des PFP-Fahrzeugtyps (Silhouette)  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_VEHICLE_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'IMAGE_FILE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Dateibezeichnung, in der die Fahrzeug-Silhouette gespeichert ist  EN: Image file name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'IMAGE_FILE_NAME';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_VEHICLE_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'IS_POLYGON_DATA_VALID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob für die Fahrzeug-Silhouette gültige Polygon-Daten existieren  EN: Is polygon data valid
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'IS_POLYGON_DATA_VALID';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_VEHICLE_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PFP_VEHICLE_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_CLASS_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Schlüsselwert der Produktklassengruppe  EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_CLASS_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Produktklassengruppe  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_CLASS_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_CLASS_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_COMBINATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Kombinationstyps  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_COMBINATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_COMBINATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_MATERIAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP-Materialgruppe  EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_MATERIAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_MATERIAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_MATERIAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurz-Beschreibung der Gewichtsklasse  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'WEIGHT_FROM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Minimalgewicht  EN: Weight from
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'WEIGHT_FROM';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'WEIGHT_TO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:  	Maximalgewicht  EN: Weight to
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'WEIGHT_TO';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbeschreibung des Objekttyps  EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Objekttyps  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'IS_AU_NECESSARY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: AU erforderlich  EN: IS AU necessery
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'IS_AU_NECESSARY';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Produkttyps  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_PRODUCT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Schlüsselwert der Mangelbewertung   EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Mangelbewertung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'SP_SEVERITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: deleted?  EN: 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'SP_SEVERITY';
END

IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'SP_TEST_MARK_PRESET';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: deleted?  EN: 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'SP_TEST_MARK_PRESET';
END

IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_STATISTIC_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Statistikgruppe  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_STATISTIC_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_STATISTIC_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_SUMMARY_FIELD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Ergebnisfelds  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_SUMMARY_FIELD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_SUMMARY_FIELD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS', @level2type=N'COLUMN', @level2name=N'TAX_CLASS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP-Steuer-Code  EN: Tax class
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS', @level2type=N'COLUMN', @level2name=N'TAX_CLASS';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE', @level2type=N'COLUMN', @level2name=N'TAX_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP-Steuer-Code  EN: Tax code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE', @level2type=N'COLUMN', @level2name=N'TAX_CODE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'INS_TAX_CODE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Steuerklasssifizierung des Materials   EN: Tax code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'INS_TAX_CODE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'INS_TAX_CLASS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Steuerklasssifizierung des Kunden   EN: Tax class
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'INS_TAX_CLASS_ID';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Buchungskreis   EN: Accounting area
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Land   EN: Country
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'DEBITOR_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Debitornummer  EN: Debitor number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'DEBITOR_NUMBER';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'PERCENT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mehrwertsteuer in Prozent  EN: Percent
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'PERCENT';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Buchungskreis   EN: Accounting area
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
END

IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundesland  EN: Federal state
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
END

IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'ORD_AREA_OF_WORK_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Arbeitsgebiet   EN: Area of work
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'ORD_AREA_OF_WORK_ID';
END

IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'UNIT_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Code für die berichtende Stellen (mit führenden Nullen)  EN: Unit code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'UNIT_CODE';
END

IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_VALID_PERIOD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'VALIDITY_PERIOD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Länge des Gültigkeitszeitraums (in Monaten)  EN: Validity period
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'VALIDITY_PERIOD';
END

IF OBJECT_ID(N'[dbo].[INS_VALID_PERIOD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Gültigkeitszeitraums  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_VALID_PERIOD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'IS_NEXT_TERMIN_POSSIBLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob für den Zeitraum ein nächster Termin möglich ist (z.B. beim Zeitraum 0 Monate = „ohne nächsten Termin“ ist kein nächster Termin möglich)  EN: Is next term possible
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'IS_NEXT_TERMIN_POSSIBLE';
END

IF OBJECT_ID(N'[dbo].[INS_VALID_PERIOD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_VALID_PERIOD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_VAT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'TAX_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP-Steuercode   EN: Tax code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'TAX_CODE';
END

IF OBJECT_ID(N'[dbo].[INS_VAT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Mehrwertsteuersatzes  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[INS_VAT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'PERCENT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prozentsatz des Mehrwertsteuersatzes  EN: Percent
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'PERCENT';
END

IF OBJECT_ID(N'[dbo].[INS_VAT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[INS_VAT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Auszahlungsgrund  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'ACCOUNT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstelle  EN: Account
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'ACCOUNT';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'INS_VAT_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mehrwertsteuerkennzeichen   EN: Vat type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'INS_VAT_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'MAX_AMOUNT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Maximaler Auszahlungsbetrag  EN: Max amount
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'MAX_AMOUNT';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'PAYER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: ???  EN: 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'PAYER';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_PERMISSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'SYSTEM_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Systemname  EN: System name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'SYSTEM_NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_PERMISSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_PERMISSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_PERMISSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_ROLE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rolle  EN: Master data role
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_ROLE_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_PERMISSION_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Berechtigung  EN: Master data permission
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_PERMISSION_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Site-Name  EN: Site name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'SITE_PATH';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Url  EN: Url
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'SITE_PATH';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Timeout  EN: Timeout
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'LOGIN';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Login  EN: Login
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'LOGIN';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'PASSWORD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Passwort  EN: Password
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'PASSWORD';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_ROLE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rolle  EN: Role
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_ROLE_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_BILLING_PARAMETER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP Kennung  EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_BILLING_PARAMETER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibungsfeld  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORD_BILLING_PARAMETER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_BILLING_PARAMETER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_CONTACT_PERSON_FUNCTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP Kennung  EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_CONTACT_PERSON_FUNCTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibungsfeld  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORD_CONTACT_PERSON_FUNCTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_CONTACT_PERSON_FUNCTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_CUSTOMER_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'TEXT_VALUE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Textuelle Beschreibung  EN: Text value
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'TEXT_VALUE';
END

IF OBJECT_ID(N'[dbo].[ORD_CUSTOMER_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'NUMBER_VALUE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Numerischer Wert  EN: Number value
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'NUMBER_VALUE';
END

IF OBJECT_ID(N'[dbo].[ORD_CUSTOMER_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'INFO_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Infotyp  EN: Info type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'INFO_TYPE';
END

IF OBJECT_ID(N'[dbo].[ORD_CUSTOMER_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_CUSTOMER_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kürzel der Bundeslandgruppe  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Bundeslandgruppe  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'FEDERAL_STATE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kürzel des Bundesland (offizieller ISO-Schlüssel)  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'FEDERAL_STATE_NAME';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des Bundeslands  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'STATISTIC_KEY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Statistikschlüssel für KBA-Statistiken  EN: Statistic key
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'STATISTIC_KEY';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Länderschlüssel   EN: Country
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundesland   EN: Federal state
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_GROUP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundeslandgruppe   EN: Federal state group
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_GROUP_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_ORDER_CANCELATION_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON', @level2type=N'COLUMN', @level2name=N'CANCELATION_REASON_TEXT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stornotext, Platzhalter werden mit „#“ angegeben  EN: Cancelation reason text
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON', @level2type=N'COLUMN', @level2name=N'CANCELATION_REASON_TEXT';
END

IF OBJECT_ID(N'[dbo].[ORD_ORDER_CANCELATION_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_ORDER_CANCELATION_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_PARTNER_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE', @level2type=N'COLUMN', @level2name=N'SAP_QUALIFIER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: SAP Kennung  EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE', @level2type=N'COLUMN', @level2name=N'SAP_QUALIFIER';
END

IF OBJECT_ID(N'[dbo].[ORD_PARTNER_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_PARTNER_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Anerkennung  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'ORD_RECOGNITION_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anerkennungstyp   EN: Recognition type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'ORD_RECOGNITION_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Buchungskreis  EN: Accounting area
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_AREA_OF_WORK_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'ORD_RECOGNITION_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anerkennung   EN: Recognition
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'ORD_RECOGNITION_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_AREA_OF_WORK_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'ORD_AREA_OF_WORK_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Arbeitsgebiet   EN: Area of work
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'ORD_AREA_OF_WORK_ID';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_AREA_OF_WORK_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'PRIORITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anzeigereihenfolge der Arbeitsgebiete bei der Leistungsauswahl  EN: Priority
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'PRIORITY';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_AREA_OF_WORK_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_AREA_OF_WORK_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bezeichnung des Anerkennungstyps  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung der Abrechnungsvariante  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Abrechnungsvariante   EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNTING_AREA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'ACCOUNTING_AREA';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nummer des Buchungskreises  EN: Number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'ACCOUNTING_AREA';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNTING_AREA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'MAX_ORDER_SUM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Maximale Auftragssumme im Buchungskreis  EN: Max order sum
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'MAX_ORDER_SUM';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNTING_AREA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_ACCOUNTING_AREA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'BANK_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bankname  EN: Bank name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'BANK_NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'BANK_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bankleitzahl bzw. BIC  EN: Bank code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'BANK_CODE';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'BANK_ACCOUNT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kontonummer bzw. IBAN  EN: Account number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'BANK_ACCOUNT';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'TRANSFER_VALUE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:   EN: 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'TRANSFER_VALUE';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'TRANSFER_X_VALUE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:   EN: 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'TRANSFER_X_VALUE';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstelle  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bezeichnung der Kostenstelle  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt   EN: Product
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'INS_CORE_DATA_PRODUCT_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'SALES_OFFICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Verkaufsbüro (ersten 4 Stellen der Kostenstelle)  EN: Sales office
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'SALES_OFFICE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'SALES_GROUP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE:  	Verkäufergruppe (letzten 3 Stellen der Kostenstelle), dieser Wert kann auch leer sein, dann gilt der Preis für das ganze Verkaufsbüro (Niederlassung)  EN: Sales group
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'SALES_GROUP';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'MIN_PRICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Minimaler Preis  EN: Min price
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'MIN_PRICE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'MAX_PRICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Maximaler Preis  EN: Max price
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'MAX_PRICE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'STANDART_PRICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Standartpreis  EN: Standart prict
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'STANDART_PRICE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'QUANTITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: verkaufte Menge   EN: Quantity
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'QUANTITY';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'UNIT_OF_MEASURE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mengeneinheit (Kombobox) mit folgenden Werten „ST“ = Stück, „H“ = Stunde  EN: Unit of measure
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'UNIT_OF_MEASURE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'SYS_CURRENCY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Währungskennzeichen  EN: Currency
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'SYS_CURRENCY_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'CHANGE_ABILITY_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Preisänderung (Kombobox mit folgenden Werten 0= “nicht änderbar“, 1= “änderbar mit Begründung“, 2= “änderbar ohne Begründung“)  EN: Change ability type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'CHANGE_ABILITY_TYPE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'ORG_COST_CENTER_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstelle  EN: Cost center
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'ORG_COST_CENTER_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Verantwortlicher Mitarbeiter   EN: Responsible employee
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'EMP_EMPLOYEE_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Informationsname (Kombobox) mit folgenden möglichen Werten (Verlagerung in eigenen Wertebereich wird empfohlen!): „TAX_NUMBER“, „BANK_NAME“, „BANK_ACCOUNT“, „BANK_CODE“, „AP_DEBITOR_NUMBER“, „AP_CASH_DEBITOR_NUMBER“  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'VALUE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Informationswert  EN: Value
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'VALUE';
END

IF OBJECT_ID(N'[dbo].[ORG_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'DEBITOR_CUSTOMER_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Debitornummer des Kunden  EN: Debitor number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'DEBITOR_CUSTOMER_NUMBER';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'IDENTIFICATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Identifizierung des Prüfmittels  EN: Identification
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'IDENTIFICATION';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'NEW_IDENTIFICATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Neue Identifizierung des Prüfmittels  EN: New identification
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'NEW_IDENTIFICATION';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'OLD_IDENTIFICATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Alte Identifizierung des Prüfmittels  EN: Old identification
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'OLD_IDENTIFICATION';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfmitteltyp  EN: Type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'TYPE';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'SERIAL_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Seriennummer  EN: Serial number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'SERIAL_NUMBER';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name der Prüfmittel-Prüfung  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Prüfmittel-Prüfung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'LAST_INSPECTION_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Letztes Prüfungsdatum  EN: Last inspection date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'LAST_INSPECTION_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'LAST_INSPECTION_RESULT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ergebnis der letzten Prüfung  EN: Last inspection result
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'LAST_INSPECTION_RESULT';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'INSPECTION_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfungsdatum  EN: Inspection date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'INSPECTION_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'INSPECTION_INTERVAL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfungsintervall  EN: Inspection interval
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'INSPECTION_INTERVAL';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ORG_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Nummer  EN: Org Number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ORG_NUMBER';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Bezeichnung  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ABBR';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Kürzel  EN: Abbreviation
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ABBR';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'LOCATION_ABBR';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Standortcode-Kürzel  EN: Location abbreviation
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'LOCATION_ABBR';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'SYS_LOCATION_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Standortcode   EN: Location
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'SYS_LOCATION_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ORG_TYPE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Typ   EN: Org type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ORG_TYPE_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'EMAIL_FROM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Email von  EN: Email from
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'EMAIL_FROM';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'EMAIL_TO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Email bis  EN: Email to
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'EMAIL_TO';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'IS_EGDOK_PRINT_ALWAYS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob EGDok-Dokumente für diese OE auch bei negativem Ergebnis gedruckt werden können  EN: EGDok print always
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'IS_EGDOK_PRINT_ALWAYS';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Buchungskreis  EN: Accounting area
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'ORG_ACCOUNTING_AREA_ID';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_RELATIONSHIP_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung des OE-Hierarchietyps  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_RELATIONSHIP_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des OE-Hierarchietyps  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORG_RELATIONSHIP_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_RELATIONSHIP_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung des OE-Typs  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[ORG_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung des OE-Typs  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[ORG_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[ORG_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_COLUMNS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[SYS_COLUMNS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'SYS_TABLE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Tabelle  EN: Table
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'SYS_TABLE_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_COLUMNS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[SYS_COLUMNS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'READ_ONLY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nicht editierbar  EN: Readonly
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'READ_ONLY';
END

IF OBJECT_ID(N'[dbo].[SYS_COUNTRY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Länderschlüssel   EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_COUNTRY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Landesbezeichnung  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[SYS_COUNTRY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'IS_EU';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob das Land in der EU liegt   EN: Is EU
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'IS_EU';
END

IF OBJECT_ID(N'[dbo].[SYS_COUNTRY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_COUNTRY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'SAP_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachschlüssel   EN: SAP ID
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'SAP_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'SAP_ID_ISO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: ISO-Sprachbezeichnung  EN: SAP ID ISO
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'SAP_ID_ISO';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'RESOURCE_FILE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Dateiname mit Oberflächentextenfür die Sprache  EN: Resource file name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'RESOURCE_FILE_NAME';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'IS_AVAILABLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Angabe, ob Datei für Oberflächentexte vorhanden ist  EN: Is available
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'IS_AVAILABLE';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'DESCIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprachbezeichnung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'DESCIPTION';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'LOCATION_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Standortcode  EN: Location code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'LOCATION_CODE';
END

IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'LOCATION_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ort des Standortcodes  EN: Location name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'LOCATION_NAME';
END

IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Land des Standortcodes   EN: Country
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'SYS_COUNTRY_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundesland des Standortcodes   EN: Federal state
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'ORD_FEDERAL_STATE_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_POST_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'POST_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Postleitzahl  EN: Post code
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'POST_CODE';
END

IF OBJECT_ID(N'[dbo].[SYS_POST_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'CITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ort  EN: City
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'CITY';
END

IF OBJECT_ID(N'[dbo].[SYS_POST_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'STREET';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Straße  EN: Street
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'STREET';
END

IF OBJECT_ID(N'[dbo].[SYS_POST_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_POST_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'ROLE_NUMBER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rollenschlüssel  EN: Role number
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'ROLE_NUMBER';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kurzbezeichnung der Rolle  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung der Rolle  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE_SYS_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'SYS_ROLE_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rolle   EN: Role
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'SYS_ROLE_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE_SYS_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'SYS_PERMISSION_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Recht   EN: Permission
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'SYS_PERMISSION_ID';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE_SYS_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_ROLE_SYS_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'EDIT_MODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Editiebarkeit  EN: Edit mode
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'EDIT_MODE';
END

IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Beschreibung  EN: Description
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'DESCRIPTION';
END

IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Von Datum  EN: From date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'FROM_DATE';
END

IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'TO_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bis Datum  EN: To date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'TO_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Status  EN: Status
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Datum  EN: Check date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nachricht  EN: Message
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zähler  EN: Attempt
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_WCF_INFO_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web Service  EN: Wcf info
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_WCF_INFO_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'WSDL_PATH';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Pfad to Wsdl  EN: Path to wsdl 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'WSDL_PATH';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Timeout  EN: Timeout checking
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Status  EN: Status
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Datum  EN: Check date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nachricht  EN: Message
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zähler  EN: Attempt
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_SITE_INFO_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Site  EN: Site info
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_SITE_INFO_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITOR_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'RECONFIGURE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Neue Konfiguration  EN: Reconfigure
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'RECONFIGURE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITOR_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'RECONFIGURE_CHECKING_TIMEOUT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Neue Konfiguration Timeout  EN: Reconfigure flag checking timeout
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'RECONFIGURE_CHECKING_TIMEOUT';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'CONNECTION_STRING';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Connection string  EN: Connection string
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'CONNECTION_STRING';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'TABLE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Tabelle  EN: Table name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'TABLE_NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Timeout checking  EN: Timeout checking
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'JOB_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Hintergrundprozess Name  EN:  Job name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_INFO', @level2type=N'COLUMN', @level2name=N'JOB_NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'LAST_RUN_TIME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Letztes Prüfungsdatum  EN: Last run time
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'LAST_RUN_TIME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfungsdatum  EN: Check date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Status  EN: Status
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_JOB_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_JOB_INFO_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Hintergrundprozess  EN: Job info
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_JOB_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_JOB_INFO_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'MACHINE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Machine Name  EN: Machine name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'MACHINE_NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'SERVICE_NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Windows-Service Name  EN: Service name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'SERVICE_NAME';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Timeout  EN: Timeout checking
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'TIMEOUT_CHECKING';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Status  EN: Status
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfungsdatum  EN: Check date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nachricht  EN: Message
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zähler  EN: Attempt
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_WINDOWS_SERVICE_INFO_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Windows-Service  EN: Windows service info
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_WINDOWS_SERVICE_INFO_ID';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Status  EN: Status
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'CHECK_STATUS';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfungsdatum  EN: Check date
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'CHECK_DATE';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nachricht  EN: Message
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zähler  EN: Attempt
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'ATTEMPT';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'NAME';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Name  EN: Name
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'NAME';
END

IF OBJECT_ID(N'[dbo].[GET_WCF_SERVICES_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'WSDL_PATH';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Pfad to Wsdl  EN: Path to wsdl 
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'GET_WCF_SERVICES_STATUS', @level2type=N'COLUMN', @level2name=N'WSDL_PATH';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SUBSCRIBERS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS', @level2type=N'COLUMN', @level2name=N'EMAIL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: E-mail  EN: E-mail
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS', @level2type=N'COLUMN', @level2name=N'EMAIL';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'NOTIFICATION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachricht Typ  EN: Notification type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'NOTIFICATION_TYPE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'IS_ALERT_ON';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Aktiv  EN: Is alert on
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'IS_ALERT_ON';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'ALERT_CHECK_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Status  EN: Check status for alert
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'ALERT_CHECK_STATUS';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'ALERT_ATTEMPT_COUNT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Versuchanzahl  EN: Attempt count for alert
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'ALERT_ATTEMPT_COUNT';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Nachricht  EN: Message
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'MESSAGE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'SUBJECT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Thema  EN: Subject
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'SUBJECT';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'MONITORABLE_INFO_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsobjekt Typ  EN: Monitorable object type
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'MONITORABLE_INFO_TYPE';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'MONITORABLE_INFO_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsobjekt  EN: Monitorable object id
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'MONITORABLE_INFO_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_NOTIFICATIONS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachricht  EN: Notification
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_NOTIFICATIONS_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_NOTIFICATIONS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachricht  EN: Notification
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_NOTIFICATIONS_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_SUBSCRIBERS_ID';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Empfänger  EN: Subscriber
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'MASTER_DATA_SUBSCRIBERS_ID';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITOR_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Monitor Einstellungen  EN: Monitor settings
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITOR_STATE', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachrichten Einstellungen  EN: Monitorable object to notification
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachrichten  EN: Notifications
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Überwachungsnachrichten Empfänger  EN: Notification to subscriber
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_PERMISSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Berechtigung  EN: Master data permission
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_PERMISSION', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Rolle  EN: Master data role
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_ROLE_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Berechtigung  EN: Master data permissiom
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_ROLE_PERMISSION_RSP', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Site Monitor  EN: Site check result
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SITE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Site Einstellungen  EN: Master data sites
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SITE_INFO', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_SUBSCRIBERS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Monitor Empfänger  EN: Subscribers
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_SUBSCRIBERS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_USER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Benutzer  EN: Master data user
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_USER', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Services Monitor  EN: Wcf check result
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WCF_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Web-Services Einstellungen  EN: Wcf info
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WCF_INFO', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Windows Services Monitor  EN: Windows service check results
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[MASTER_DATA_WINDOWS_SERVICE_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Windows Services Einstellungen  EN: Windows service info
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MASTER_DATA_WINDOWS_SERVICE_INFO', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[SYS_COLUMNS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Spalte  EN: Master data column
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COLUMNS', @level2type=N'COLUMN', @level2name=N'Configuration';
END

IF OBJECT_ID(N'[dbo].[SYS_TABLES]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'Configuration';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stammdaten Tabelle  EN: Master data table
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_TABLES', @level2type=N'COLUMN', @level2name=N'Configuration';
END

