using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;

namespace TuevSued.V1.IT.FE.MasterDataModule.API
{
    public static class JsonHelper
    {
        //TODO Need to be removed
        public static string GetCurrentUserJson(IDependencyResolver resolver)
        {
            var result = new LoggedUserModel();
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                result.IsAuthenticated = false;
            else
            {
                var service = resolver.GetService(typeof (IUserManager));
                var user = ((IUserManager)service).GetByLogin(HttpContext.Current.User.Identity.Name);

                result.IsAuthenticated = true;
                result.Name = user.Name;
                result.Permissions = user.Role.Permissions.ToDictionary(o => o.SystemName, o => true);
            }

            return JsonConvert.SerializeObject(result, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }

        //TODO Need to be removed
        public static void SetCurrentCulture()
        {
        }

        //TODO Need to be removed
        public static string GetSystemTablesJson(IDependencyResolver resolver)
        {
            //driver licence master data
            var tableMappingNames = new Dictionary<string, string>();
            FeMasterDataTablesMappins(tableMappingNames);
            CommonMasterDataTablesMapping(tableMappingNames);

            var columnsMappingNames = new Dictionary<string, Dictionary<string, string>>();
            FeMasterDataColumnsMapping(columnsMappingNames);
            CommonMasterDataColumnsMapping(columnsMappingNames);


            //TODO another fields

            var service = (ISysTableManager)resolver.GetService(typeof(ISysTableManager));
            var tables = service.GetEntities().ToList();

            var result = new GlobalSysTableModel();
            result.TableNames = new Dictionary<string, SysTableWithColumnsModel>();

            foreach (var item in tables)
            {
                if (tableMappingNames.ContainsKey(item.Name))
                {
                    var dbColumns = item.SysColumns.Where(o => !o.DeleteDate.HasValue && o.ReadOnly).
                        Select(o => o.Name).ToList();

                    if (columnsMappingNames.ContainsKey(item.Name))
                    {
                        var tableColumns = columnsMappingNames[item.Name].Where(o => dbColumns.Contains(o.Key));

                        var model = new SysTableWithColumnsModel()
                        {
                            EditMode = (int)item.EditMode,
                            ReadOnlyColumns = tableColumns.Select(o => o.Value).ToList()
                        };

                        result.TableNames.Add(tableMappingNames[item.Name], model);
                    }
                }
            }

            return JsonConvert.SerializeObject(result, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }

        #region Mappings

        private static void CommonMasterDataTablesMapping(Dictionary<string, string> tableMappingNames)
        {
            tableMappingNames.Add("INS_CORE_DATA_PRODUCT", "InsCoreDataProduct");
            tableMappingNames.Add("INS_CORE_DATA_PRODUCT_LOCALIZATION", "InsCoreDataProductLocalization");
        }

        private static void FeMasterDataTablesMappins(Dictionary<string, string> tableMappingNames)
        {
            tableMappingNames.Add("DRL_EXAM_CLASS", "ExamClass");
            tableMappingNames.Add("DRL_EXAM_CLASS_REQUIRED_CLASS_RSP", "RequiredExamClass");
            tableMappingNames.Add("DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP", "InclusiveExamClass");
            tableMappingNames.Add("DRL_LEGAL_BASIS", "LegalBasis");
            tableMappingNames.Add("DRL_EXAM_RECOGNITION_TYPE", "ExamRecognitionType");
            tableMappingNames.Add("DRL_CORE_DATA_PRODUCT", "CoreDataProduct");
            tableMappingNames.Add("DRL_CORE_DATA_PRODUCT_LOCALIZATION", "CoreDataProductLocalization");
            tableMappingNames.Add("DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP", "CoreDataProductClassBasis");
        }

        #region CommonMasterDataColumnsMapping

        private static void CommonMasterDataColumnsMapping(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            InsCoreDataProduct(columnsMappingNames);
            InsCoreDataProductLocalization(columnsMappingNames);
        }

        private static void InsCoreDataProductLocalization(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("INS_CORE_DATA_PRODUCT_LOCALIZATION", temp);
            temp["PRODUCT_NAME"] = "name";
            temp["DESCRIPTION"] = "description";
            temp["SYS_LANGUAGE_ID"] = "sysLanguageId";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
        }

        private static void InsCoreDataProduct(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("INS_CORE_DATA_PRODUCT", temp);
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
            temp["PRODUCT_NUMBER"] = "productNumber";
        }

        #endregion

        #region FeMasterDataColumnsMapping

        private static void FeMasterDataColumnsMapping(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            ExamClass(columnsMappingNames);
            ExamClassRequiredClass(columnsMappingNames);
            ExamClassInclusiveClass(columnsMappingNames);
            LegalBasis(columnsMappingNames);
            ExamRecognitionType(columnsMappingNames);
            CoreDataProduct(columnsMappingNames);
            CoreDataProductLocalization(columnsMappingNames);
            CoreDataProductClassBasis(columnsMappingNames);
        }

        private static void CoreDataProductClassBasis(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP", temp);
            temp["DRL_EXAM_CLASS_ID"] = "examClassId";
            temp["DRL_LEGAL_BASIS_ID"] = "legalBasisId";
            temp["SORT_ORDER"] = "sortOrder";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
        }

        private static void CoreDataProductLocalization(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_CORE_DATA_PRODUCT_LOCALIZATION", temp);
            temp["PRODUCT_NAME"] = "name";
            temp["DESCRIPTION"] = "description";
            temp["SYS_LANGUAGE_ID"] = "sysLanguageId";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
        }

        private static void CoreDataProduct(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {

            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_CORE_DATA_PRODUCT", temp);
            //TODO lint to localization table  temp["NAME"] = "name";
            //TODO lint to localization table temp["DESCRIPTION"] = "description";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
            temp["MIN_AGE"] = "minAge";
            temp["MAX_AGE"] = "maxAge";
            temp["EXAM_TYPE"] = "examType";
            temp["PRIOR_TIME_IN_MONTHS"] = "priorTimeInMonths";
            temp["REPEAT_TIME_IN_DAYS"] = "repeatTimeInDays";
            temp["TRAINING_CERT_FLAG"] = "trainingCertFlag";
            temp["RESULT_FLAG"] = "resultFlag";
            temp["MULTIPLY_FLAG"] = "multiplyFlag";
            temp["IS_MOFA_PRINT"] = "isMofaPrint";
            temp["IS_ADDITIONAL_PRODUCT"] = "isAdditionalProduct";
            temp["IS_PREPAYMENT_REQUIRED"] = "isPrepaymentRequired";
            temp["IS_MANDATORY"] = "isMandatory";
            temp["REPEAT_TIME_IN_DAYS_REDUCED"] = "repeatTimeInDaysReduced";
            temp["INS_CORE_DATA_PRODUCT_ID"] = "insCoreDataProductId";
        }

        private static void ExamRecognitionType(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_EXAM_RECOGNITION_TYPE", temp);
            temp["NAME"] = "name";
            temp["DESCRIPTION"] = "description";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
        }

        private static void LegalBasis(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_LEGAL_BASIS", temp);
            temp["NAME"] = "name";
            temp["DESCRIPTION"] = "description";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
            temp["EDUCATION_CERTIFICATE_REQUIRED"] = "isAttestationRequired";
            temp["FIRST_ASSIGNATION"] = "isFirstAssignation";
            temp["MESSAGE_REASON"] = "messageReason";
            temp["MESSAGE_REASON_STYLE"] = "messageReasonStyle";
            temp["PRINT_NAME"] = "printName";
            temp["REPLACEMENT_ID"] = "replacementId";
        }

        private static void ExamClassInclusiveClass(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP", temp);
            temp["DRL_EXAM_CLASS_ID_INCLUSIVE"] = "inclusiveExamClassId";
            temp["IS_CONDITIONAL"] = "isConditional";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
        }

        private static void ExamClassRequiredClass(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_EXAM_CLASS_REQUIRED_CLASS_RSP", temp);
            temp["DRL_EXAM_CLASS_ID_REQUIRED"] = "requiredExamClassId";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
        }

        private static void ExamClass(Dictionary<string, Dictionary<string, string>> columnsMappingNames)
        {
            var temp = new Dictionary<string, string>();
            columnsMappingNames.Add("DRL_EXAM_CLASS", temp);
            temp["NAME"] = "name";
            //temp["DESCRIPTION"] = "description";
            temp["IS_FS_CLASS"] = "isFsClass";
            temp["IS_MOFA"] = "isMofa";
            temp["FROM_DATE"] = "fromDate";
            temp["TO_DATE"] = "toDate";
            temp["SORT_ORDER"] = "sortOrder";
        }

        #endregion

        #endregion
    }
}
