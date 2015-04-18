






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using MasterDataModule.Lib.Managers;
using MasterDataModule.Lib.Managers.Configuration;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeMasterDataConfiguration(IUnityContainer container)
        {
            container.RegisterType<ILogTypeInfoManager, LogTypeInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataWcfInfoManager, MasterDataWcfInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataWcfCheckResultsManager, MasterDataWcfCheckResultsManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataSiteInfoManager, MasterDataSiteInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataSiteCheckResultsManager, MasterDataSiteCheckResultsManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysColumnManager, SysColumnManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataMonitorStateManager, MasterDataMonitorStateManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataJobInfoManager, MasterDataJobInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IGetApplicationLogsManager, GetApplicationLogsManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysTableManager, SysTableManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISiteInfosWithLastResultManager, SiteInfosWithLastResultManager>(new PerRequestLifetimeManager());
            container.RegisterType<IWcfInfosWithLastResultManager, WcfInfosWithLastResultManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataJobCheckResultsManager, MasterDataJobCheckResultsManager>(new PerRequestLifetimeManager());
            container.RegisterType<IWinserviceInfosWithLastResultManager, WinserviceInfosWithLastResultManager>(new PerRequestLifetimeManager());
            container.RegisterType<IJobsInfosWithLastResultManager, JobsInfosWithLastResultManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataWindowsServiceInfoManager, MasterDataWindowsServiceInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataWindowsServiceCheckResultsManager, MasterDataWindowsServiceCheckResultsManager>(new PerRequestLifetimeManager());
            container.RegisterType<IRoleManager, RoleManager>(new PerRequestLifetimeManager());
            container.RegisterType<IPermissionManager, PermissionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataRolePermissionRspManager, MasterDataRolePermissionRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IUserManager, UserManager>(new PerRequestLifetimeManager());
            container.RegisterType<IApplicationLogsManager, ApplicationLogsManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataSubscribersManager, MasterDataSubscribersManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataNotificationsManager, MasterDataNotificationsManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataMonitorableInfoMasterDataNotificationsRspManager, MasterDataMonitorableInfoMasterDataNotificationsRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataNotificationsMasterDataSubscribersRspManager, MasterDataNotificationsMasterDataSubscribersRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IGetWinServicesStatusManager, GetWinServicesStatusManager>(new PerRequestLifetimeManager());
            container.RegisterType<IGetSitesStatusManager, GetSitesStatusManager>(new PerRequestLifetimeManager());
            container.RegisterType<IGetJobsStatusManager, GetJobsStatusManager>(new PerRequestLifetimeManager());
            container.RegisterType<IGetWcfServicesStatusManager, GetWcfServicesStatusManager>(new PerRequestLifetimeManager());
        }

    }
}
