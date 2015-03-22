






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeMasterDataConfiguration(IUnityContainer container)
        {
            container.RegisterType<IPermissionManager, PermissionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IRoleManager, RoleManager>(new PerRequestLifetimeManager());
            container.RegisterType<IUserManager, UserManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysColumnManager, SysColumnManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysTableManager, SysTableManager>(new PerRequestLifetimeManager());
        }

    }
}
