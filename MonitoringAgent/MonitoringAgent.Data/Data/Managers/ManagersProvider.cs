


// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "MonitoringAgent.Console\App.config"
//     Connection String Name: "MasterDataMonitoringModelContainer"
//     Connection String:      "data source=.;initial catalog=SettingsData;integrated security=True;MultipleActiveResultSets=True;"

using Microsoft.Practices.Unity;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
	internal sealed partial class ManagersProvider
	{
		private void RegisterManagers(IUnityContainer container)
		{
					container.RegisterType<IApplicationLogsManager, ApplicationLogsManager>();
			container.RegisterType<IGetApplicationLogsManager, GetApplicationLogsManager>();
			container.RegisterType<IGetJobsStatusManager, GetJobsStatusManager>();
			container.RegisterType<IGetSitesStatusManager, GetSitesStatusManager>();
			container.RegisterType<IGetWcfServicesStatusManager, GetWcfServicesStatusManager>();
			container.RegisterType<IGetWinServicesStatusManager, GetWinServicesStatusManager>();
			container.RegisterType<IJobsInfosWithLastResultManager, JobsInfosWithLastResultManager>();
			container.RegisterType<ILogTypeInfoManager, LogTypeInfoManager>();
			container.RegisterType<IMasterDataJobCheckResultsManager, MasterDataJobCheckResultsManager>();
			container.RegisterType<IMasterDataJobInfoManager, MasterDataJobInfoManager>();
			container.RegisterType<IMasterDataMonitorableInfoMasterDataNotificationsRspManager, MasterDataMonitorableInfoMasterDataNotificationsRspManager>();
			container.RegisterType<IMasterDataMonitorStateManager, MasterDataMonitorStateManager>();
			container.RegisterType<IMasterDataNotificationsManager, MasterDataNotificationsManager>();
			container.RegisterType<IMasterDataNotificationsMasterDataSubscribersRspManager, MasterDataNotificationsMasterDataSubscribersRspManager>();
			container.RegisterType<IMasterDataSiteCheckResultsManager, MasterDataSiteCheckResultsManager>();
			container.RegisterType<IMasterDataSiteInfoManager, MasterDataSiteInfoManager>();
			container.RegisterType<IMasterDataSubscribersManager, MasterDataSubscribersManager>();
			container.RegisterType<IMasterDataWcfCheckResultsManager, MasterDataWcfCheckResultsManager>();
			container.RegisterType<IMasterDataWcfInfoManager, MasterDataWcfInfoManager>();
			container.RegisterType<IMasterDataWindowsServiceCheckResultsManager, MasterDataWindowsServiceCheckResultsManager>();
			container.RegisterType<IMasterDataWindowsServiceInfoManager, MasterDataWindowsServiceInfoManager>();
			container.RegisterType<ISiteInfosWithLastResultManager, SiteInfosWithLastResultManager>();
			container.RegisterType<IWcfInfosWithLastResultManager, WcfInfosWithLastResultManager>();
			container.RegisterType<IWinserviceInfosWithLastResultManager, WinserviceInfosWithLastResultManager>();
	
		}
	}
}

