






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeDrl(IUnityContainer container)
        {
            container.RegisterType<IMessageLocalizationManager, MessageLocalizationManager>();
            container.RegisterType<ICoreDataProductManager, CoreDataProductManager>();
            container.RegisterType<IReturnReasonManager, ReturnReasonManager>();
            container.RegisterType<IExamPossibleResultManager, ExamPossibleResultManager>();
            container.RegisterType<ISchoolInfoManager, SchoolInfoManager>();
            container.RegisterType<IArgeVersionManager, ArgeVersionManager>();
            container.RegisterType<IAuthorityManager, AuthorityManager>();
            container.RegisterType<ICommunityManager, CommunityManager>();
            container.RegisterType<IExamRecognitionTypeManager, ExamRecognitionTypeManager>();
            container.RegisterType<ICoreDataProductClassBasisManager, CoreDataProductClassBasisManager>();
            container.RegisterType<ICommunityParticipantManager, CommunityParticipantManager>();
            container.RegisterType<IExamRecognitionTypeExamClassManager, ExamRecognitionTypeExamClassManager>();
            container.RegisterType<IDriverSchoolManager, DriverSchoolManager>();
            container.RegisterType<IExamRoomManager, ExamRoomManager>();
            container.RegisterType<IExamStationManager, ExamStationManager>();
            container.RegisterType<IDriverSchoolExamRecognitionTypeManager, DriverSchoolExamRecognitionTypeManager>();
            container.RegisterType<IDriverSchoolInfoManager, DriverSchoolInfoManager>();
            container.RegisterType<IExamStationExamRecognitionTypeManager, ExamStationExamRecognitionTypeManager>();
            container.RegisterType<IHolidayManager, HolidayManager>();
            container.RegisterType<IExamClassManager, ExamClassManager>();
            container.RegisterType<IHolidayOrdFederalStateManager, HolidayOrdFederalStateManager>();
            container.RegisterType<ILanguageManager, LanguageManager>();
            container.RegisterType<IExamClassArgeMapManager, ExamClassArgeMapManager>();
            container.RegisterType<ILegalBasisManager, LegalBasisManager>();
            container.RegisterType<IExamClassInclusiveClassManager, ExamClassInclusiveClassManager>();
            container.RegisterType<IExamClassMapManager, ExamClassMapManager>();
            container.RegisterType<IExamClassRequiredClassManager, ExamClassRequiredClassManager>();
            container.RegisterType<ICoreDataProductLocalizationManager, CoreDataProductLocalizationManager>();
            container.RegisterType<IExamClassRestrictedClassManager, ExamClassRestrictedClassManager>();
            container.RegisterType<IExamConstraintManager, ExamConstraintManager>();
            container.RegisterType<IMeetingPointManager, MeetingPointManager>();
            container.RegisterType<IExamConstraintExamClassManager, ExamConstraintExamClassManager>();
            container.RegisterType<IMeetingPointOrganizationalUnitManager, MeetingPointOrganizationalUnitManager>();
        }

    }
}
