






using MasterDataModule.Lib.DuplicateCheckers.Drl;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeDrlDuplicateCheckers(IUnityContainer container)
        {
            container.RegisterType<IDrlDuplicateChecker, MessageLocalizationDuplicateChecker>("messageLocalization", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, CoreDataProductDuplicateChecker>("coreDataProduct", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ReturnReasonDuplicateChecker>("returnReason", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ExamPossibleResultDuplicateChecker>("examPossibleResult", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, SchoolInfoDuplicateChecker>("schoolInfo", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, AuthorityDuplicateChecker>("authority", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ExamRecognitionTypeDuplicateChecker>("examRecognitionType", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ExamRoomDuplicateChecker>("examRoom", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ExamStationDuplicateChecker>("examStation", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ExamClassDuplicateChecker>("examClass", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, LanguageDuplicateChecker>("language", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, LegalBasisDuplicateChecker>("legalBasis", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, ExamConstraintDuplicateChecker>("examConstraint", new PerRequestLifetimeManager());
            container.RegisterType<IDrlDuplicateChecker, MeetingPointDuplicateChecker>("meetingPoint", new PerRequestLifetimeManager());
        }

    }
}
