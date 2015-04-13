IF OBJECT_ID(N'[dbo].[EMP_CASH_PERMISSION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Auszahlungsrecht  EN: Cash permission', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_CASH_PERMISSION_TYPE';
END
IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitarbeiter  EN: Employee', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE';
END
IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_COST_CENTER_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstelle  EN: Cost center', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_COST_CENTER_RSP';
END
IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE/TSC  EN: Org. unit', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP';
END
IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_SYS_ROLE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Rolle  EN: Role', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_SYS_ROLE_RSP';
END
IF OBJECT_ID(N'[dbo].[EMP_EMPLOYEE_TOP_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Vorgesetzter  EN: Top employee', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_EMPLOYEE_TOP_EMPLOYEE_RSP';
END
IF OBJECT_ID(N'[dbo].[EMP_LOGIN_DATA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Login Information  EN: Login data', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_LOGIN_DATA';
END
IF OBJECT_ID(N'[dbo].[EMP_ORG_ASSOCIATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnungsarten zwischen Mitarbeiter und OE  EN: Association type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EMP_ORG_ASSOCIATION_TYPE';
END
IF OBJECT_ID(N'[dbo].[EXP_PASSENGERS_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mitfahrerart  EN: Passenger type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EXP_PASSENGERS_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Verfügbarer Prüfschritt zu Prüfschritt  EN: Available inspection step', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_STEP';
END
IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_TEXT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_TEXT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Systemtext  EN: Available inspection text', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_TEXT';
END
IF OBJECT_ID(N'[dbo].[INS_AVAILABLE_INSPECTION_TEXT_VALUE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_TEXT_VALUE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung sptrachabhängiger Systemtexte zu einem Systemtext  EN: Available inspection text to language', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_AVAILABLE_INSPECTION_TEXT_VALUE';
END
IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt  EN: Product', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT';
END
IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Arbeitswerte  EN: Product group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_GROUP';
END
IF OBJECT_ID(N'[dbo].[INS_CORE_DATA_PRODUCT_LOCALIZATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Lokalisierung  EN: Localization', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_CORE_DATA_PRODUCT_LOCALIZATION';
END
IF OBJECT_ID(N'[dbo].[INS_INSPECTION_STEP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-Prüfschritt  EN: Inspection step', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_INSPECTION_STEP';
END
IF OBJECT_ID(N'[dbo].[INS_NEXT_INSPECTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-Nächste Prüfung  EN: Next inspection', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_INSPECTION';
END
IF OBJECT_ID(N'[dbo].[INS_NEXT_SP_INTERVAL]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-SP-Intervall  EN: Next SP-Interval', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_NEXT_SP_INTERVAL';
END
IF OBJECT_ID(N'[dbo].[INS_OBD_STATUS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-AU-OBD-Status  EN: OBD status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OBD_STATUS';
END
IF OBJECT_ID(N'[dbo].[INS_OPTICAL_DEFECT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-optische Mängel  EN: Optical defect', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_OPTICAL_DEFECT';
END
IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-PFP-Baugruppen  EN: PFP inspection type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung PFP-Prüfpositionen zu PFP-Baugruppe  EN: PFP inspection type to position', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP';
END
IF OBJECT_ID(N'[dbo].[INS_PFP_POSITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-PFP-Prüfpositionen  EN: PFP position', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_POSITION';
END
IF OBJECT_ID(N'[dbo].[INS_PFP_VEHICLE_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-PFP-Fahrzeugtypen (Silhouetten)  EN: Vehicle type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PFP_VEHICLE_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_PRODUCT_CLASS_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-Produktklassengruppe  EN: Product class group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_CLASS_GROUP';
END
IF OBJECT_ID(N'[dbo].[INS_PRODUCT_COMBINATION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Kombinationstypen  EN: Product combination type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_COMBINATION_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_PRODUCT_MATERIAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Materialgruppen  EN: Product material group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_MATERIAL_GROUP';
END
IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Gewichtsklassen  EN: Product object class', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_CLASS';
END
IF OBJECT_ID(N'[dbo].[INS_PRODUCT_OBJECT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Objekttypen  EN: Product object type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_OBJECT_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_PRODUCT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Produkttypen  EN: Product type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_PRODUCT_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_SEVERITY_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-Mangelbewertungen  EN: Severity type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SEVERITY_TYPE';
END
IF OBJECT_ID(N'[dbo].[INS_STATISTIC_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Statistikgruppe  EN: Statistic group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_STATISTIC_GROUP';
END
IF OBJECT_ID(N'[dbo].[INS_SUMMARY_FIELD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-Ergebnisfeld  EN: Summary field', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_SUMMARY_FIELD';
END
IF OBJECT_ID(N'[dbo].[INS_TAX_CLASS]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kunde-Steuerklasse  EN: Tax class', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CLASS';
END
IF OBJECT_ID(N'[dbo].[INS_TAX_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Steuercode  EN: Tax code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_CODE';
END
IF OBJECT_ID(N'[dbo].[INS_TAX_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Steuerkombination  EN: Tax info combination', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_TAX_INFO';
END
IF OBJECT_ID(N'[dbo].[INS_UNIT_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: berichtende Stellen  EN: Unit code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_UNIT_CODE';
END
IF OBJECT_ID(N'[dbo].[INS_VALID_PERIOD]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produktklasse-Zeiträume  EN: Valid period', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VALID_PERIOD';
END
IF OBJECT_ID(N'[dbo].[INS_VAT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Mehrwertsteuersatz  EN: Tax code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INS_VAT_TYPE';
END
IF OBJECT_ID(N'[dbo].[KSS_EXPENSE_GROUND]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Auszahlungsgrund  EN: Expense ground', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KSS_EXPENSE_GROUND';
END
IF OBJECT_ID(N'[dbo].[ORD_AREA_OF_WORK]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_AREA_OF_WORK';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Arbeitsgebiet  EN: Area of work', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_AREA_OF_WORK';
END
IF OBJECT_ID(N'[dbo].[ORD_BILLING_PARAMETER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kunde-Rechnungsintervalle  EN: Billing parameter', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_BILLING_PARAMETER';
END
IF OBJECT_ID(N'[dbo].[ORD_CONTACT_PERSON_FUNCTION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kunde-Funktionen Ansprechpartner  EN: Customer contact person', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CONTACT_PERSON_FUNCTION';
END
IF OBJECT_ID(N'[dbo].[ORD_CUSTOMER_INFO]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kunde-Informationstyp  EN: Customer info', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_CUSTOMER_INFO';
END
IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_GROUP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundeslandgruppe  EN: Federal state group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_GROUP';
END
IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bundesland  EN: Federal state', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE';
END
IF OBJECT_ID(N'[dbo].[ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Bundeslandgruppe zu einem Bundesland  EN: Federal state to group', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_FEDERAL_STATE_FEDERAL_GROUP_RSP';
END
IF OBJECT_ID(N'[dbo].[ORD_ORDER_CANCELATION_REASON]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Stornogrund  EN: Cancel reason', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_ORDER_CANCELATION_REASON';
END
IF OBJECT_ID(N'[dbo].[ORD_PARTNER_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kunde-Partnerrollen  EN: Parnter role', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_PARTNER_ROLE';
END
IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Anerkennung  EN: Recognition', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION';
END
IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_AREA_OF_WORK_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Arbeitsgebiet zu Anerkennung  EN: Area of work to recognition', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_AREA_OF_WORK_RSP';
END
IF OBJECT_ID(N'[dbo].[ORD_RECOGNITION_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Produkt-Anerkennungstyp  EN: Product recognition type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORD_RECOGNITION_TYPE';
END
IF OBJECT_ID(N'[dbo].[ORG_ACCOUNT_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Abrechnungsvariante  EN: Account type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNT_TYPE';
END
IF OBJECT_ID(N'[dbo].[ORG_ACCOUNTING_AREA]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Buchungskreis  EN: Accounting area', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ACCOUNTING_AREA';
END
IF OBJECT_ID(N'[dbo].[ORG_BANK_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Bankverbindung  EN: Bank information', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_BANK_INFORMATION';
END
IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstelle  EN: Cost center', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER';
END
IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_PRICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Preise zu Kostenstelle  EN: Cost center price', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_PRICE';
END
IF OBJECT_ID(N'[dbo].[ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Kostenstellenverantwortlicher   EN: Cost center responsible employee', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP';
END
IF OBJECT_ID(N'[dbo].[ORG_INFORMATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Information  EN: Organization information', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INFORMATION';
END
IF OBJECT_ID(N'[dbo].[ORG_INSPECTION_DEVICE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Prüfmittel  EN: Organization inspection device', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_INSPECTION_DEVICE';
END
IF OBJECT_ID(N'[dbo].[ORG_ORGANIZATIONAL_UNIT]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Organisationseinheit  EN: Organizational unit', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_ORGANIZATIONAL_UNIT';
END
IF OBJECT_ID(N'[dbo].[ORG_RELATIONSHIP_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Hierarchietyp  EN: Organization hierarchy type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_RELATIONSHIP_TYPE';
END
IF OBJECT_ID(N'[dbo].[ORG_TYPE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: OE-Type  EN: Organization type', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ORG_TYPE';
END
IF OBJECT_ID(N'[dbo].[SYS_COUNTRY]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Land   EN: Country', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_COUNTRY';
END
IF OBJECT_ID(N'[dbo].[SYS_LANGUAGE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Sprache  EN: Language', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LANGUAGE';
END
IF OBJECT_ID(N'[dbo].[SYS_LOCATION]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Standortcode  EN: Location code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_LOCATION';
END
IF OBJECT_ID(N'[dbo].[SYS_POST_CODE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Postleitzahl  EN: ZIP', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_POST_CODE';
END
IF OBJECT_ID(N'[dbo].[SYS_ROLE]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Systemrolle  EN: Role', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE';
END
IF OBJECT_ID(N'[dbo].[SYS_ROLE_SYS_PERMISSION_RSP]', 'U') IS NOT NULL
BEGIN
EXEC [sys].[sp_dropextendedproperty] @name = N'MS_Description', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP';
EXEC [sys].[sp_addextendedproperty] @name = N'MS_Description', @value = N'DE: Zuordnung Rechte zu einer Rolle  EN: Role to permission', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYS_ROLE_SYS_PERMISSION_RSP';
END
