






using System.Collections.Generic;

namespace MasterDataModule.API
{
    public static partial class JsonHelper
    {
        private static void DrlTableMappings(IDictionary<string, TableMapping> tables)
        {
            tables.Add("DRL_MESSAGE_LOCALIZATION", new TableMapping("DRL_MESSAGE_LOCALIZATION", "MessageLocalization", 3)
            {
                {"VALIDATION_ERROR_NUMBER", "validationErrorNumber"},
                {"SYS_LANGUAGE_ID", "sysLanguageId"},
                {"MESSAGE", "message"},
            });

            tables.Add("SYS_COLUMNS", new TableMapping("SYS_COLUMNS", "SysColumn", 3)
            {
                {"SYS_TABLE_ID", "sysTableId"},
                {"DESCRIPTION", "description"},
                {"READ_ONLY", "readOnly"},
            });

            tables.Add("SYS_TABLES", new TableMapping("SYS_TABLES", "SysTable", 2)
            {
                {"DESCRIPTION", "description"},
                {"EDIT_MODE", "editMode"},
            });

            tables.Add("DRL_RETURN_REASON", new TableMapping("DRL_RETURN_REASON", "ReturnReason", 6)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"TEXT_1", "text1"},
                {"TEXT_2", "text2"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_POSSIBLE_RESULT", new TableMapping("DRL_EXAM_POSSIBLE_RESULT", "ExamPossibleResult", 9)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_FEE_PAYABLE", "isFeePayable"},
                {"EXAM_COUNTER_FLAG", "examCounterFlag"},
                {"NEXT_EXAM_PRODUCT_FLAG", "nextExamProductFlag"},
                {"DRIVER_LICENCE_FLAG", "driverLicenceFlag"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"IS_MEDICAL_ATTEST_REQUIRED", "isMedicalAttestRequired"},
            });

            tables.Add("DRL_SCHOOL_INFO", new TableMapping("DRL_SCHOOL_INFO", "SchoolInfo", 3)
            {
                {"TEXT", "text"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_ARGE_VERSION", new TableMapping("DRL_ARGE_VERSION", "ArgeVersion", 5)
            {
                {"PROGRAMM_NAME", "programmName"},
                {"VERSION_SYSTEM", "versionSystem"},
                {"EXPIRATION_DATE", "expirationDate"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_AUTHORITY", new TableMapping("DRL_AUTHORITY", "Authority", 15)
            {
                {"AUTHORITY_NUMBER", "authorityNumber"},
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_CERTIFICATE_REQUIRED", "isCertificateRequired"},
                {"RETURN_TYPE", "returnType"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"NAME_2", "name2"},
                {"STREET_HOUSE_NUMBER", "streetHouseNumber"},
                {"ZIP_CODE", "zipCode"},
                {"CITY", "city"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
                {"PHONE_1", "phone1"},
                {"PHONE_2", "phone2"},
                {"FAX", "fax"},
            });

            tables.Add("DRL_COMMUNITY", new TableMapping("DRL_COMMUNITY", "Community", 3)
            {
                {"DRL_DRIVER_SCHOOL_ID", "driverSchoolId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_RECOGNITION_TYPE", new TableMapping("DRL_EXAM_RECOGNITION_TYPE", "ExamRecognitionType", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP", new TableMapping("DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP", "ExamRecognitionTypeExamClass", 4)
            {
                {"DRL_EXAM_RECOGNITION_TYPE_ID", "examRecognitionTypeId"},
                {"DRL_EXAM_CLASS_ID", "examClassId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_ROOM", new TableMapping("DRL_EXAM_ROOM", "ExamRoom", 17)
            {
                {"ROOM_NUMBER", "roomNumber"},
                {"PLACE_AMOUNT", "placeAmount"},
                {"ORG_ORGANIZATIONAL_UNIT_ID", "orgOrganizationalUnitId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"NAME_1", "name1"},
                {"NAME_2", "name2"},
                {"NAME_3", "name3"},
                {"STREET_HOUSE_NUMBER", "streetHouseNumber"},
                {"ZIP_CODE", "zipCode"},
                {"ZIP_BOX", "zipBox"},
                {"BOX", "box"},
                {"CITY", "city"},
                {"PHONE_1", "phone1"},
                {"FAX", "fax"},
                {"EMAIL", "email"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
            });

            tables.Add("DRL_EXAM_STATION", new TableMapping("DRL_EXAM_STATION", "ExamStation", 6)
            {
                {"ORD_FEDERAL_STATE_ID", "ordFederalStateId"},
                {"PLACE", "place"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"SORT_ORDER", "sortOrder"},
            });

            tables.Add("DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP", new TableMapping("DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP", "ExamStationExamRecognitionType", 4)
            {
                {"DRL_EXAM_STATION_ID", "examStationId"},
                {"DRL_EXAM_RECOGNITION_TYPE_ID", "examRecognitionTypeId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_HOLIDAY", new TableMapping("DRL_HOLIDAY", "Holiday", 2)
            {
                {"NAME", "name"},
                {"DATE", "date"},
            });

            tables.Add("DRL_EXAM_CLASS", new TableMapping("DRL_EXAM_CLASS", "ExamClass", 7)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_MOFA", "isMofa"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"IS_FS_CLASS", "isFsClass"},
                {"SORT_ORDER", "sortOrder"},
            });

            tables.Add("DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP", new TableMapping("DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP", "HolidayOrdFederalState", 2)
            {
                {"DRL_HOLIDAY_ID", "holidayId"},
                {"ORD_FEDERAL_STATE_ID", "ordFederalStateId"},
            });

            tables.Add("DRL_LANGUAGE", new TableMapping("DRL_LANGUAGE", "Language", 4)
            {
                {"SYS_LANGUAGE_ID", "sysLanguageId"},
                {"OLD_ABBR", "oldAbbr"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_CLASS_ARGE_MAP", new TableMapping("DRL_EXAM_CLASS_ARGE_MAP", "ExamClassArgeMap", 2)
            {
                {"EXAM_NAME_ARGE", "examNameArge"},
                {"DRL_EXAM_CLASS_ID", "examClassId"},
            });

            tables.Add("DRL_LEGAL_BASIS", new TableMapping("DRL_LEGAL_BASIS", "LegalBasis", 10)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"EDUCATION_CERTIFICATE_REQUIRED", "educationCertificateRequired"},
                {"FIRST_ASSIGNATION", "firstAssignation"},
                {"MESSAGE_REASON", "messageReason"},
                {"MESSAGE_REASON_STYLE", "messageReasonStyle"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"REPLACEMENT_ID", "replacementId"},
                {"PRINT_NAME", "printName"},
            });

            tables.Add("DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP", new TableMapping("DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP", "ExamClassInclusiveClass", 5)
            {
                {"DRL_EXAM_CLASS_ID", "examClassId"},
                {"DRL_EXAM_CLASS_ID_INCLUSIVE", "examClassIdInclusive"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
                {"IS_CONDITIONAL", "isConditional"},
            });

            tables.Add("DRL_EXAM_CLASS_MAP", new TableMapping("DRL_EXAM_CLASS_MAP", "ExamClassMap", 2)
            {
                {"DRL_EXAM_CLASS_ID_OLD", "examClassIdOld"},
                {"DRL_EXAM_CLASS_ID_ACTUAL", "examClassIdActual"},
            });

            tables.Add("DRL_EXAM_CLASS_REQUIRED_CLASS_RSP", new TableMapping("DRL_EXAM_CLASS_REQUIRED_CLASS_RSP", "ExamClassRequiredClass", 4)
            {
                {"DRL_EXAM_CLASS_ID", "examClassId"},
                {"DRL_EXAM_CLASS_ID_REQUIRED", "examClassIdRequired"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP", new TableMapping("DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP", "ExamClassRestrictedClass", 4)
            {
                {"DRL_EXAM_CLASS_ID", "examClassId"},
                {"DRL_EXAM_CLASS_ID_RESTRICTED", "examClassIdRestricted"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_CONSTRAINT", new TableMapping("DRL_EXAM_CONSTRAINT", "ExamConstraint", 5)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"CONSTRAINT_TYPE", "constraintType"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_MEETING_POINT", new TableMapping("DRL_MEETING_POINT", "MeetingPoint", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP", new TableMapping("DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP", "ExamConstraintExamClass", 4)
            {
                {"DRL_EXAM_CONSTRAINT_ID", "examConstraintId"},
                {"DRL_EXAM_CLASS_ID", "examClassId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

            tables.Add("DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP", new TableMapping("DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP", "MeetingPointOrganizationalUnit", 4)
            {
                {"DRL_MEETING_POINT_ID", "meetingPointId"},
                {"ORG_ORGANIZATIONAL_UNIT_ID", "orgOrganizationalUnitId"},
                {"FROM_DATE", "fromDate"},
                {"TO_DATE", "toDate"},
            });

        }
    }
}
