


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
					container.RegisterType<IMasterDataJobCheckResultsManager, MasterDataJobCheckResultsManager>(new PerResolveLifetimeManager());
			container.RegisterType<IMasterDataJobInfoManager, MasterDataJobInfoManager>(new PerResolveLifetimeManager());
			container.RegisterType<IMasterDataMonitorStateManager, MasterDataMonitorStateManager>(new PerResolveLifetimeManager());
			container.RegisterType<IMasterDataSiteCheckResultsManager, MasterDataSiteCheckResultsManager>(new PerResolveLifetimeManager());
			container.RegisterType<IMasterDataSiteInfoManager, MasterDataSiteInfoManager>(new PerResolveLifetimeManager());
			container.RegisterType<IMasterDataWcfCheckResultsManager, MasterDataWcfCheckResultsManager>(new PerResolveLifetimeManager());
			container.RegisterType<IMasterDataWcfInfoManager, MasterDataWcfInfoManager>(new PerResolveLifetimeManager());
	
		}
	}
}

