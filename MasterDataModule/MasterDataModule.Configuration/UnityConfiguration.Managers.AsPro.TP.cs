






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeAsProTP(IUnityContainer container)
        {
            container.RegisterType<IInsNextSpIntervalManager, InsNextSpIntervalManager>();
            container.RegisterType<IInsObdStatusManager, InsObdStatusManager>();
            container.RegisterType<IInsOpticalDefectManager, InsOpticalDefectManager>();
            container.RegisterType<IInsProductClassGroupManager, InsProductClassGroupManager>();
            container.RegisterType<IInsSeverityTypeManager, InsSeverityTypeManager>();
            container.RegisterType<IInsValidPeriodManager, InsValidPeriodManager>();
            container.RegisterType<IInsPfpPositionManager, InsPfpPositionManager>();
            container.RegisterType<IInsPfpInspectionTypePfpPositionRspManager, InsPfpInspectionTypePfpPositionRspManager>();
            container.RegisterType<IInsPfpVehicleTypeManager, InsPfpVehicleTypeManager>();
            container.RegisterType<IInsUnitCodeManager, InsUnitCodeManager>();
            container.RegisterType<IInsAvailableInspectionTextManager, InsAvailableInspectionTextManager>();
            container.RegisterType<IInsAvailableInspectionTextValueManager, InsAvailableInspectionTextValueManager>();
            container.RegisterType<IInsInspectionStepManager, InsInspectionStepManager>();
            container.RegisterType<IInsAvailableInspectionStepManager, InsAvailableInspectionStepManager>();
            container.RegisterType<IInsSummaryFieldManager, InsSummaryFieldManager>();
            container.RegisterType<IInsNextInspectionManager, InsNextInspectionManager>();
        }

    }
}
