






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
            container.RegisterType<ISysColumnManager, SysColumnManager>();
            container.RegisterType<ISysTableManager, SysTableManager>();
            container.RegisterType<IRoleManager, RoleManager>();
            container.RegisterType<IReturnReasonManager, ReturnReasonManager>();
            container.RegisterType<IPermissionManager, PermissionManager>();
            container.RegisterType<IExamPossibleResultManager, ExamPossibleResultManager>();
            container.RegisterType<ISchoolInfoManager, SchoolInfoManager>();
            container.RegisterType<IArgeVersionManager, ArgeVersionManager>();
            container.RegisterType<IAuthorityManager, AuthorityManager>();
            container.RegisterType<IUserManager, UserManager>();
            container.RegisterType<ICommunityManager, CommunityManager>();
            container.RegisterType<IExamRecognitionTypeManager, ExamRecognitionTypeManager>();
            container.RegisterType<IExamRecognitionTypeExamClassManager, ExamRecognitionTypeExamClassManager>();
            container.RegisterType<IExamRoomManager, ExamRoomManager>();
            container.RegisterType<IExamStationManager, ExamStationManager>();
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
            container.RegisterType<IExamClassRestrictedClassManager, ExamClassRestrictedClassManager>();
            container.RegisterType<IExamConstraintManager, ExamConstraintManager>();
            container.RegisterType<IMeetingPointManager, MeetingPointManager>();
            container.RegisterType<IExamConstraintExamClassManager, ExamConstraintExamClassManager>();
            container.RegisterType<IMeetingPointOrganizationalUnitManager, MeetingPointOrganizationalUnitManager>();
        }

    }
}
