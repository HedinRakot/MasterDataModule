using System.Configuration;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Contracts.SaveActors.Aspro;
using MasterDataModule.Contracts.SaveActors.Drl;
using MasterDataModule.Contracts.SaveActors.MasterDataConfiguration;
using MasterDataModule.Lib.Data;
using MasterDataModule.Lib.Data.SaveActors.AsPro;
using MasterDataModule.Lib.Data.SaveActors.Drl;
using MasterDataModule.Lib.Data.SaveActors.MasterDataConfiguration;
using MasterDataModule.Lib.DuplicateCheckers.Aspro;
using MasterDataModule.Lib.DuplicateCheckers.Drl;
using MasterDataModule.Lib.DuplicateCheckers.MasterDataConfiguration;
using MasterDataModule.Lib.Managers.Monitor;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IAsProEntities, AsProEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(new ResolvedParameter<IAsProSaveActorManager>(), ConfigurationManager.ConnectionStrings["AsProEntities"].ConnectionString));

            container.RegisterType<IDrlEntities, DrlEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(new ResolvedParameter<IDrlSaveActorManager>(), ConfigurationManager.ConnectionStrings["FeEntities"].ConnectionString));

            container.RegisterType<IMasterDataConfigurationEntities, MasterDataConfigurationEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(new ResolvedParameter<IMasterDataConfigurationSaveActorManager>(), ConfigurationManager.ConnectionStrings["MasterDataConfigurationEntities"].ConnectionString));

            container.RegisterType<IDrlSaveActorManager, DrlSaveActorManager>(new PerRequestLifetimeManager());
            container.RegisterType<IAsProSaveActorManager, AsProSaveActorManager>(new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataConfigurationSaveActorManager, MasterDataConfigurationSaveActorManager>(new PerRequestLifetimeManager());

            RegisterDuplicateCheckers(container);
            RegisterManagers(container);
        }

        private static void RegisterDuplicateCheckers(IUnityContainer container)
        {
            container.RegisterType<IDrlSaveActor, DrlDuplicateCheckerSaveActor>("drlDuplicateCheckerSaveActor", new PerRequestLifetimeManager());
            container.RegisterType<IAsProSaveActor, AsproDuplicateCheckerSaveActor>("asproDuplicateCheckerSaveActor", new PerRequestLifetimeManager());
            container.RegisterType<IMasterDataConfigurationSaveActor, MasterDataConfigurationDuplicateCheckerSaveActor>("masterDataDuplicateCheckerSaveActor", new PerRequestLifetimeManager());

            InitializeMasterDataConfigurationDuplicateCheckers(container);
            InitializeDrlDuplicateCheckers(container);
            InitializeAsProDuplicateCheckers(container);
        }

        private static void RegisterManagers(IUnityContainer container)
        {
            InitializeDrl(container);
            InitializeAsProCommon(container);
            InitializeAsProTP(container);
            InitializeMasterDataConfiguration(container);

            container.RegisterType<IWcfStatusInfoManager, WcfStatusInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IJobStatusInfoManager, JobStatusInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IWinServiceStatusInfoManager, WinServiceStatusInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IWebSiteStatusInfoManager, WebSiteStatusInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IApplicationLogToShowManager, ApplicationLogToShowManager>(new PerRequestLifetimeManager());
        }
    }
}