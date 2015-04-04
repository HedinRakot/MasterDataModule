






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeDrl(IUnityContainer container)
        {
            container.RegisterType<IMessageLocalizationManager, MessageLocalizationManager>(new PerRequestLifetimeManager());
            container.RegisterType<ICoreDataProductManager, CoreDataProductManager>(new PerRequestLifetimeManager());
            container.RegisterType<IReturnReasonManager, ReturnReasonManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamPossibleResultManager, ExamPossibleResultManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISchoolInfoManager, SchoolInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IArgeVersionManager, ArgeVersionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IAuthorityManager, AuthorityManager>(new PerRequestLifetimeManager());
            container.RegisterType<ICommunityManager, CommunityManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamRecognitionTypeManager, ExamRecognitionTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<ICoreDataProductClassBasisManager, CoreDataProductClassBasisManager>(new PerRequestLifetimeManager());
            container.RegisterType<ICommunityParticipantManager, CommunityParticipantManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamRecognitionTypeExamClassManager, ExamRecognitionTypeExamClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IDriverSchoolManager, DriverSchoolManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamRoomManager, ExamRoomManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamStationManager, ExamStationManager>(new PerRequestLifetimeManager());
            container.RegisterType<IDriverSchoolExamRecognitionTypeManager, DriverSchoolExamRecognitionTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IDriverSchoolInfoManager, DriverSchoolInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamStationExamRecognitionTypeManager, ExamStationExamRecognitionTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IHolidayManager, HolidayManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamClassManager, ExamClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IHolidayOrdFederalStateManager, HolidayOrdFederalStateManager>(new PerRequestLifetimeManager());
            container.RegisterType<ILanguageManager, LanguageManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamClassArgeMapManager, ExamClassArgeMapManager>(new PerRequestLifetimeManager());
            container.RegisterType<ILegalBasisManager, LegalBasisManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamClassInclusiveClassManager, ExamClassInclusiveClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamClassMapManager, ExamClassMapManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamClassRequiredClassManager, ExamClassRequiredClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<ICoreDataProductLocalizationManager, CoreDataProductLocalizationManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamClassRestrictedClassManager, ExamClassRestrictedClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamConstraintManager, ExamConstraintManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMeetingPointManager, MeetingPointManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExamConstraintExamClassManager, ExamConstraintExamClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMeetingPointOrganizationalUnitManager, MeetingPointOrganizationalUnitManager>(new PerRequestLifetimeManager());
        }

    }
}
