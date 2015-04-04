






using MasterDataModule.Contracts.Managers.Configuration;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Configuration;
using MasterDataModule.Lib.Managers.Monitor;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeMasterDataConfiguration(IUnityContainer container)
        {
            container.RegisterType<ISysColumnManager, SysColumnManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysTableManager, SysTableManager>(new PerRequestLifetimeManager());
            container.RegisterType<IRoleManager, RoleManager>(new PerRequestLifetimeManager());
            container.RegisterType<IPermissionManager, PermissionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataRolePermissionRspManager, MasterDataRolePermissionRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IUserManager, UserManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataSiteInfoManager, MasterDataSiteInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IWcfStatusInfoManager, WcfStatusInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataWcfInfoManager, MasterDataWcfInfoManager>(new PerRequestLifetimeManager());
        }

    }
}
