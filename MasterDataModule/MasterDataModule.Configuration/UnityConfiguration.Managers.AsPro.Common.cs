






using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeAsProCommon(IUnityContainer container)
        {
            container.RegisterType<ISysLanguageManager, SysLanguageManager>();
            container.RegisterType<IInsCoreDataProductManager, InsCoreDataProductManager>();
            container.RegisterType<IEmpEmployeeManager, EmpEmployeeManager>();
            container.RegisterType<ISysLocationManager, SysLocationManager>();
            container.RegisterType<ISysRoleManager, SysRoleManager>();
            container.RegisterType<IEmpCashPermissionTypeManager, EmpCashPermissionTypeManager>();
            container.RegisterType<ISysRoleSysPermissionRspManager, SysRoleSysPermissionRspManager>();
            container.RegisterType<IEmpOrgAssociationTypeManager, EmpOrgAssociationTypeManager>();
            container.RegisterType<IOrgAccountTypeManager, OrgAccountTypeManager>();
            container.RegisterType<IOrgAccountingAreaManager, OrgAccountingAreaManager>();
            container.RegisterType<IOrgBankInformationManager, OrgBankInformationManager>();
            container.RegisterType<IOrgCostCenterManager, OrgCostCenterManager>();
            container.RegisterType<IOrdFederalGroupManager, OrdFederalGroupManager>();
            container.RegisterType<IOrgCostCenterResponsibleEmployeeRspManager, OrgCostCenterResponsibleEmployeeRspManager>();
            container.RegisterType<IOrdFederalStateManager, OrdFederalStateManager>();
            container.RegisterType<IOrgCostCenterPriceManager, OrgCostCenterPriceManager>();
            container.RegisterType<ISysCountryManager, SysCountryManager>();
            container.RegisterType<ISysPostCodeManager, SysPostCodeManager>();
            container.RegisterType<IOrdOrderCancelationReasonManager, OrdOrderCancelationReasonManager>();
            container.RegisterType<IOrgRelationshipTypeManager, OrgRelationshipTypeManager>();
            container.RegisterType<IKssExpenseGroundManager, KssExpenseGroundManager>();
            container.RegisterType<IOrgInformationManager, OrgInformationManager>();
            container.RegisterType<IExpPassengersTypeManager, ExpPassengersTypeManager>();
            container.RegisterType<IOrgTypeManager, OrgTypeManager>();
            container.RegisterType<IInsVatTypeManager, InsVatTypeManager>();
            container.RegisterType<IOrgInspectionDeviceManager, OrgInspectionDeviceManager>();
            container.RegisterType<IEmpEmployeeOrgCostCenterRspManager, EmpEmployeeOrgCostCenterRspManager>();
            container.RegisterType<IOrdBillingParameterManager, OrdBillingParameterManager>();
            container.RegisterType<IEmpEmployeeOrgOrganizationalUnitRspManager, EmpEmployeeOrgOrganizationalUnitRspManager>();
            container.RegisterType<IOrdContactPersonFunctionManager, OrdContactPersonFunctionManager>();
            container.RegisterType<IEmpEmployeeTopEmployeeRspManager, EmpEmployeeTopEmployeeRspManager>();
            container.RegisterType<IOrdCustomerInfoManager, OrdCustomerInfoManager>();
            container.RegisterType<IEmpEmployeeSysRoleRspManager, EmpEmployeeSysRoleRspManager>();
            container.RegisterType<IOrdPartnerRoleManager, OrdPartnerRoleManager>();
            container.RegisterType<IInsTaxClassManager, InsTaxClassManager>();
            container.RegisterType<IInsCoreDataProductGroupManager, InsCoreDataProductGroupManager>();
            container.RegisterType<IInsProductCombinationTypeManager, InsProductCombinationTypeManager>();
            container.RegisterType<IInsProductMaterialGroupManager, InsProductMaterialGroupManager>();
            container.RegisterType<IInsProductObjectClassManager, InsProductObjectClassManager>();
            container.RegisterType<IInsProductObjectTypeManager, InsProductObjectTypeManager>();
            container.RegisterType<IOrgOrganizationalUnitManager, OrgOrganizationalUnitManager>();
            container.RegisterType<IInsProductTypeManager, InsProductTypeManager>();
            container.RegisterType<IInsStatisticGroupManager, InsStatisticGroupManager>();
            container.RegisterType<IOrdAreaOfWorkManager, OrdAreaOfWorkManager>();
            container.RegisterType<IOrdRecognitionTypeManager, OrdRecognitionTypeManager>();
            container.RegisterType<IOrdRecognitionManager, OrdRecognitionManager>();
            container.RegisterType<IOrdRecognitionAreaOfWorkRspManager, OrdRecognitionAreaOfWorkRspManager>();
            container.RegisterType<IInsTaxCodeManager, InsTaxCodeManager>();
        }

    }
}
