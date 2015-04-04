


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
	public partial class ManagersProvider
	{
		protected void RegisterManagers(IUnityContainer container)
		{
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
	
		}
	}
}

