






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeMasterDataСonfiguration(IUnityContainer container)
        {
            container.RegisterType<IPermissionManager, PermissionManager>();
            container.RegisterType<IRoleManager, RoleManager>();
            container.RegisterType<IUserManager, UserManager>();
            container.RegisterType<ISysColumnManager, SysColumnManager>();
            container.RegisterType<ISysTableManager, SysTableManager>();
        }

    }
}
