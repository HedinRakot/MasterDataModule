






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeAsProTP(IUnityContainer container)
        {
            container.RegisterType<IInsNextSpIntervalManager, InsNextSpIntervalManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsObdStatusManager, InsObdStatusManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsOpticalDefectManager, InsOpticalDefectManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsProductClassGroupManager, InsProductClassGroupManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsSeverityTypeManager, InsSeverityTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsValidPeriodManager, InsValidPeriodManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsPfpPositionManager, InsPfpPositionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsPfpInspectionTypePfpPositionRspManager, InsPfpInspectionTypePfpPositionRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsPfpVehicleTypeManager, InsPfpVehicleTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsUnitCodeManager, InsUnitCodeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsAvailableInspectionTextManager, InsAvailableInspectionTextManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsAvailableInspectionTextValueManager, InsAvailableInspectionTextValueManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsInspectionStepManager, InsInspectionStepManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsAvailableInspectionStepManager, InsAvailableInspectionStepManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsSummaryFieldManager, InsSummaryFieldManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsNextInspectionManager, InsNextInspectionManager>(new PerRequestLifetimeManager());
        }

    }
}
