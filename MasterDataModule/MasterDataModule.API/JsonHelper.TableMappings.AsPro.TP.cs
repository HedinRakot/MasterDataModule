﻿






using System.Collections.Generic;

namespace MasterDataModule.API
{
    public static partial class JsonHelper
    {
        private static void AsProTPTableMappings(IDictionary<string, TableMapping> tables)
        {
            tables.Add("INS_NEXT_SP_INTERVAL", new TableMapping("INS_NEXT_SP_INTERVAL", "InsNextSpInterval", 5)
            {
                {"INS_PRODUCT_OBJECT_TYPE_ID", "insProductObjectTypeId"},
                {"INS_PRODUCT_OBJECT_CLASS_ID", "insProductObjectClassId"},
                {"AGE_MONTH_FROM", "ageMonthFrom"},
                {"AGE_MONTH_TO", "ageMonthTo"},
                {"SP_INTERVAL", "spInterval"},
            });

            tables.Add("INS_OBD_STATUS", new TableMapping("INS_OBD_STATUS", "InsObdStatus", 3)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"AU_VIEW", "auView"},
            });

            tables.Add("INS_OPTICAL_DEFECT", new TableMapping("INS_OPTICAL_DEFECT", "InsOpticalDefect", 3)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_CUSTOM", "isCustom"},
            });

            tables.Add("INS_PRODUCT_CLASS_GROUP", new TableMapping("INS_PRODUCT_CLASS_GROUP", "InsProductClassGroup", 2)
            {
                {"DESCRIPTION", "description"},
                {"SAP_ID", "sapId"},
            });

            tables.Add("INS_SEVERITY_TYPE", new TableMapping("INS_SEVERITY_TYPE", "InsSeverityType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("INS_VALID_PERIOD", new TableMapping("INS_VALID_PERIOD", "InsValidPeriod", 3)
            {
                {"DESCRIPTION", "description"},
                {"VALIDITY_PERIOD", "validityPeriod"},
                {"IS_NEXT_TERMIN_POSSIBLE", "isNextTerminPossible"},
            });

            tables.Add("INS_PFP_POSITION", new TableMapping("INS_PFP_POSITION", "InsPfpPosition", 1)
            {
                {"TEXT", "text"},
            });

            tables.Add("INS_PFP_VEHICLE_TYPE", new TableMapping("INS_PFP_VEHICLE_TYPE", "InsPfpVehicleType", 3)
            {
                {"DESCRIPTION", "description"},
                {"IMAGE_FILE_NAME", "imageFileName"},
                {"IS_POLYGON_DATA_VALID", "isPolygonDataValid"},
            });

            tables.Add("INS_UNIT_CODE", new TableMapping("INS_UNIT_CODE", "InsUnitCode", 4)
            {
                {"ORG_ACCOUNTING_AREA_ID", "orgAccountingAreaId"},
                {"ORD_FEDERAL_STATE_ID", "ordFederalStateId"},
                {"ORD_AREA_OF_WORK_ID", "ordAreaOfWorkId"},
                {"UNIT_CODE", "unitCode"},
            });

            tables.Add("INS_INSPECTION_STEP", new TableMapping("INS_INSPECTION_STEP", "InsInspectionStep", 1)
            {
                {"DESCRIPTION", "description"},
            });

            tables.Add("INS_AVAILABLE_INSPECTION_STEP", new TableMapping("INS_AVAILABLE_INSPECTION_STEP", "InsAvailableInspectionStep", 2)
            {
                {"INS_INSPECTION_STEP_ID", "insInspectionStepId"},
                {"IS_MANDATORY", "isMandatory"},
            });

            tables.Add("INS_SUMMARY_FIELD", new TableMapping("INS_SUMMARY_FIELD", "InsSummaryField", 1)
            {
                {"DESCRIPTION", "description"},
            });

            tables.Add("INS_NEXT_INSPECTION", new TableMapping("INS_NEXT_INSPECTION", "InsNextInspection", 1)
            {
                {"DESCRIPTION", "description"},
            });

        }
    }
}