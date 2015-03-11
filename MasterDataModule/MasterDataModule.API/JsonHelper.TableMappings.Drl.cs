






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

            tables.Add("DRL_RETURN_REASON", new TableMapping("DRL_RETURN_REASON", "ReturnReason", 4)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"TEXT_1", "text1"},
                {"TEXT_2", "text2"},
            });

            tables.Add("DRL_EXAM_POSSIBLE_RESULT", new TableMapping("DRL_EXAM_POSSIBLE_RESULT", "ExamPossibleResult", 7)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_FEE_PAYABLE", "isFeePayable"},
                {"EXAM_COUNTER_FLAG", "examCounterFlag"},
                {"NEXT_EXAM_PRODUCT_FLAG", "nextExamProductFlag"},
                {"DRIVER_LICENCE_FLAG", "driverLicenceFlag"},
                {"IS_MEDICAL_ATTEST_REQUIRED", "isMedicalAttestRequired"},
            });

            tables.Add("DRL_SCHOOL_INFO", new TableMapping("DRL_SCHOOL_INFO", "SchoolInfo", 1)
            {
                {"TEXT", "text"},
            });

            tables.Add("DRL_ARGE_VERSION", new TableMapping("DRL_ARGE_VERSION", "ArgeVersion", 3)
            {
                {"PROGRAMM_NAME", "programmName"},
                {"VERSION_SYSTEM", "versionSystem"},
                {"EXPIRATION_DATE", "expirationDate"},
            });

            tables.Add("DRL_AUTHORITY", new TableMapping("DRL_AUTHORITY", "Authority", 13)
            {
                {"AUTHORITY_NUMBER", "authorityNumber"},
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_CERTIFICATE_REQUIRED", "isCertificateRequired"},
                {"RETURN_TYPE", "returnType"},
                {"NAME_2", "name2"},
                {"STREET_HOUSE_NUMBER", "streetHouseNumber"},
                {"ZIP_CODE", "zipCode"},
                {"CITY", "city"},
                {"SYS_COUNTRY_ID", "sysCountryId"},
                {"PHONE_1", "phone1"},
                {"PHONE_2", "phone2"},
                {"FAX", "fax"},
            });

            tables.Add("DRL_COMMUNITY", new TableMapping("DRL_COMMUNITY", "Community", 1)
            {
                {"DRL_DRIVER_SCHOOL_ID", "driverSchoolId"},
            });

            tables.Add("DRL_EXAM_RECOGNITION_TYPE", new TableMapping("DRL_EXAM_RECOGNITION_TYPE", "ExamRecognitionType", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

            tables.Add("DRL_EXAM_ROOM", new TableMapping("DRL_EXAM_ROOM", "ExamRoom", 15)
            {
                {"ROOM_NUMBER", "roomNumber"},
                {"PLACE_AMOUNT", "placeAmount"},
                {"ORG_ORGANIZATIONAL_UNIT_ID", "orgOrganizationalUnitId"},
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

            tables.Add("DRL_EXAM_STATION", new TableMapping("DRL_EXAM_STATION", "ExamStation", 4)
            {
                {"ORD_FEDERAL_STATE_ID", "ordFederalStateId"},
                {"PLACE", "place"},
                {"DESCRIPTION", "description"},
                {"SORT_ORDER", "sortOrder"},
            });

            tables.Add("DRL_HOLIDAY", new TableMapping("DRL_HOLIDAY", "Holiday", 2)
            {
                {"NAME", "name"},
                {"DATE", "date"},
            });

            tables.Add("DRL_EXAM_CLASS", new TableMapping("DRL_EXAM_CLASS", "ExamClass", 5)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"IS_MOFA", "isMofa"},
                {"IS_FS_CLASS", "isFsClass"},
                {"SORT_ORDER", "sortOrder"},
            });

            tables.Add("DRL_LANGUAGE", new TableMapping("DRL_LANGUAGE", "Language", 2)
            {
                {"SYS_LANGUAGE_ID", "sysLanguageId"},
                {"OLD_ABBR", "oldAbbr"},
            });

            tables.Add("DRL_EXAM_CLASS_ARGE_MAP", new TableMapping("DRL_EXAM_CLASS_ARGE_MAP", "ExamClassArgeMap", 2)
            {
                {"EXAM_NAME_ARGE", "examNameArge"},
                {"DRL_EXAM_CLASS_ID", "examClassId"},
            });

            tables.Add("DRL_LEGAL_BASIS", new TableMapping("DRL_LEGAL_BASIS", "LegalBasis", 8)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"EDUCATION_CERTIFICATE_REQUIRED", "educationCertificateRequired"},
                {"FIRST_ASSIGNATION", "firstAssignation"},
                {"MESSAGE_REASON", "messageReason"},
                {"MESSAGE_REASON_STYLE", "messageReasonStyle"},
                {"REPLACEMENT_ID", "replacementId"},
                {"PRINT_NAME", "printName"},
            });

            tables.Add("DRL_EXAM_CLASS_MAP", new TableMapping("DRL_EXAM_CLASS_MAP", "ExamClassMap", 2)
            {
                {"DRL_EXAM_CLASS_ID_OLD", "examClassIdOld"},
                {"DRL_EXAM_CLASS_ID_ACTUAL", "examClassIdActual"},
            });

            tables.Add("DRL_EXAM_CONSTRAINT", new TableMapping("DRL_EXAM_CONSTRAINT", "ExamConstraint", 3)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
                {"CONSTRAINT_TYPE", "constraintType"},
            });

            tables.Add("DRL_MEETING_POINT", new TableMapping("DRL_MEETING_POINT", "MeetingPoint", 2)
            {
                {"NAME", "name"},
                {"DESCRIPTION", "description"},
            });

        }
    }
}
