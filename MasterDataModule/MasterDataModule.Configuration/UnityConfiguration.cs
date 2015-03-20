using System.Configuration;
using MasterDataModule.Contracts;
using MasterDataModule.Lib.Data;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IAsProEntities, AsProEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(ConfigurationManager.ConnectionStrings["ASProEntities"].ConnectionString));
            container.RegisterType<IDrlEntities, DrlEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(ConfigurationManager.ConnectionStrings["FeEntities"].ConnectionString));
            container.RegisterType<IMasterDataConfigurationEntities, MasterDataConfigurationEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(ConfigurationManager.ConnectionStrings["MasterDataConfigurationEntities"].ConnectionString));

            RegisterManagers(container);
        }

        private static void RegisterManagers(IUnityContainer container)
        {
            InitializeDrl(container);
            InitializeAsProCommon(container);
            InitializeAsProTP(container);
            InitializeMasterDataСonfiguration(container);
        }
    }
}