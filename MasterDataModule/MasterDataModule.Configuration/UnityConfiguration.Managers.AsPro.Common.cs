






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeAsProCommon(IUnityContainer container)
        {
            container.RegisterType<ISysLanguageManager, SysLanguageManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsCoreDataProductManager, InsCoreDataProductManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsCoreDataProductLocalizationManager, InsCoreDataProductLocalizationManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpEmployeeManager, EmpEmployeeManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysLocationManager, SysLocationManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysRoleManager, SysRoleManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpCashPermissionTypeManager, EmpCashPermissionTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysRoleSysPermissionRspManager, SysRoleSysPermissionRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpOrgAssociationTypeManager, EmpOrgAssociationTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgAccountTypeManager, OrgAccountTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgAccountingAreaManager, OrgAccountingAreaManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgBankInformationManager, OrgBankInformationManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgCostCenterManager, OrgCostCenterManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdFederalGroupManager, OrdFederalGroupManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgCostCenterResponsibleEmployeeRspManager, OrgCostCenterResponsibleEmployeeRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdFederalStateManager, OrdFederalStateManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgCostCenterPriceManager, OrgCostCenterPriceManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysCountryManager, SysCountryManager>(new PerRequestLifetimeManager());
            container.RegisterType<ISysPostCodeManager, SysPostCodeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdOrderCancelationReasonManager, OrdOrderCancelationReasonManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgRelationshipTypeManager, OrgRelationshipTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IKssExpenseGroundManager, KssExpenseGroundManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgInformationManager, OrgInformationManager>(new PerRequestLifetimeManager());
            container.RegisterType<IExpPassengersTypeManager, ExpPassengersTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgTypeManager, OrgTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsVatTypeManager, InsVatTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgInspectionDeviceManager, OrgInspectionDeviceManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpEmployeeOrgCostCenterRspManager, EmpEmployeeOrgCostCenterRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdBillingParameterManager, OrdBillingParameterManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpEmployeeOrgOrganizationalUnitRspManager, EmpEmployeeOrgOrganizationalUnitRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdContactPersonFunctionManager, OrdContactPersonFunctionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpEmployeeTopEmployeeRspManager, EmpEmployeeTopEmployeeRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdCustomerInfoManager, OrdCustomerInfoManager>(new PerRequestLifetimeManager());
            container.RegisterType<IEmpEmployeeSysRoleRspManager, EmpEmployeeSysRoleRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdPartnerRoleManager, OrdPartnerRoleManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsTaxClassManager, InsTaxClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsCoreDataProductGroupManager, InsCoreDataProductGroupManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsProductCombinationTypeManager, InsProductCombinationTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsProductMaterialGroupManager, InsProductMaterialGroupManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsProductObjectClassManager, InsProductObjectClassManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsProductObjectTypeManager, InsProductObjectTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrgOrganizationalUnitManager, OrgOrganizationalUnitManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsProductTypeManager, InsProductTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsStatisticGroupManager, InsStatisticGroupManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdAreaOfWorkManager, OrdAreaOfWorkManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdRecognitionTypeManager, OrdRecognitionTypeManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdRecognitionManager, OrdRecognitionManager>(new PerRequestLifetimeManager());
            container.RegisterType<IOrdRecognitionAreaOfWorkRspManager, OrdRecognitionAreaOfWorkRspManager>(new PerRequestLifetimeManager());
            container.RegisterType<IInsTaxCodeManager, InsTaxCodeManager>(new PerRequestLifetimeManager());
        }

    }
}
