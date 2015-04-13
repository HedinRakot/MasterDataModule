IF OBJECT_ID(N'[Schema].[Table]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'Schema', @level1type = N'TABLE', @level1name = N'Table';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: De  EN: En', @level0type = N'SCHEMA', @level0name = N'Schema', @level1type = N'TABLE', @level1name = N'Table';
END
IF OBJECT_ID(N'[DATA].[DRL_ARGE_VERSION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: ARGE-Version  EN: ARGE-Version', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_ARGE_VERSION';
END
IF OBJECT_ID(N'[DATA].[DRL_AUTHORITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Behörde  EN: Authority', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_AUTHORITY';
END
IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschulgemeinschaft  EN: Community', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY';
END
IF OBJECT_ID(N'[DATA].[DRL_COMMUNITY_PARTICIPANT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitglied der Fahrschulgemeinschaft  EN: Community participant', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_COMMUNITY_PARTICIPANT';
END
IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Produkt  EN: FE-Product', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT';
END
IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rechtsgrund/Klasse  EN: Legal basis/class', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Lokalisierung  EN: Localization', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_CORE_DATA_PRODUCT_LOCALIZATION';
END
IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschule  EN: Driverschool', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL';
END
IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anerkennung der Fahrschule  EN: Driverschool recognition', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_DRIVER_SCHOOL_INFO_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschule Information  EN: Driverschool info', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_DRIVER_SCHOOL_INFO_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Klasse  EN: Class', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_ARGE_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: ARGE-Klassenbezeichnung   EN: Arge class map', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_ARGE_MAP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Inklusivklasse   EN: Inclusiv class', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_MAP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Alt-Klasse zu einer FE-Klasse  EN: Old class to actual map', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_MAP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_REQUIRED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Voraussetzungsklasse   EN: Required class', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_REQUIRED_CLASS_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Ausschlussklasse   EN: Restricted class', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Auflagen/Beschränkungen  EN: Exam constraints', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung FE-Klasse zu einer FE-Auflage  EN: Exam class to constraint', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_POSSIBLE_RESULT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfleistungsergebnis  EN: Exam result', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_POSSIBLE_RESULT';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Anerkennung  EN: FE recognition', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung FE-Klasse zu einer Anerkennung  EN: Exam class to recognition', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_ROOM]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Prüfraum  EN: Exam room', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_ROOM';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Prüfort  EN: FE exam station', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION';
END
IF OBJECT_ID(N'[DATA].[DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung FE-Anerkennung zu einem FE-Prüfort  EN: Exam recognition to exam station', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Feiertag  EN: Holiday', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY';
END
IF OBJECT_ID(N'[DATA].[DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Bundesland zu einem Feiertag  EN: Holiday to federal state', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: FE-Sprache  EN: FE language', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LANGUAGE';
END
IF OBJECT_ID(N'[DATA].[DRL_LEGAL_BASIS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rechtsgrund  EN: Legal basis', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_LEGAL_BASIS';
END
IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Treffpunkt  EN: Meeting point', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT';
END
IF OBJECT_ID(N'[DATA].[DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung FE-Treffpunkt zu einer Organisationseinheit  EN: Meeting point to org unit', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP';
END
IF OBJECT_ID(N'[DATA].[DRL_MESSAGE_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fehlermeldung  EN: Error message', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_MESSAGE_LOCALIZATION';
END
IF OBJECT_ID(N'[DATA].[DRL_RETURN_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rückgabegrund  EN: Return reason', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_RETURN_REASON';
END
IF OBJECT_ID(N'[DATA].[DRL_SCHOOL_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Fahrschulinformationstyp  EN: Driverschool info', @level0type = N'SCHEMA', @level0name = N'DATA', @level1type = N'TABLE', @level1name = N'DRL_SCHOOL_INFO';
END
