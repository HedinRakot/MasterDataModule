






using MasterDataModule.Lib.DuplicateCheckers.Aspro;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeAsProDuplicateCheckers(IUnityContainer container)
        {
            container.RegisterType<IAsProDuplicateChecker, InsCoreDataProductLocalizationDuplicateChecker>("insCoreDataProductLocalization", new PerRequestLifetimeManager());
            container.RegisterType<IAsProDuplicateChecker, EmpEmployeeDuplicateChecker>("empEmployee", new PerRequestLifetimeManager());
        }

    }
}
