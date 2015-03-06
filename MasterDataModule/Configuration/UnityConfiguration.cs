using Microsoft.Practices.Unity;
using System.Configuration;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Common;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Settings;

namespace TuevSued.V1.IT.Configuration
{
    public class UnityConfiguration
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IASProEntities, ASProEntities>(new PerRequestLifetimeManager(), 
                new InjectionConstructor(ConfigurationManager.ConnectionStrings["ASProEntities"].ConnectionString));
            container.RegisterType<IFeEntities, FeEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(ConfigurationManager.ConnectionStrings["FeEntities"].ConnectionString));

            RegisterManagers(container);
        }

        private static void RegisterManagers(IUnityContainer container)
        {
            InitializeDriveLicenceMasterData(container);

            InitializeCommon(container);

            InitializeTechnicalInspection(container);
        }

        private static void InitializeTechnicalInspection(IUnityContainer container)
        {
        }

        private static void InitializeCommon(IUnityContainer container)
        {
            container.RegisterType<ISysLanguageManager, SysLanguageManager>();
            container.RegisterType<IInsCoreDataProductLocalizationManager, InsCoreDataProductLocalizationManager>();
            container.RegisterType<IInsCoreDataProductManager, InsCoreDataProductManager>();
            container.RegisterType<IOrgOrganizationalUnitManager, OrgOrganizationalUnitManager>();
            container.RegisterType<IEmpEmployeeManager, EmpEmployeeManager>();
            container.RegisterType<IEmpEmployeeSysRoleRspManager, EmpEmployeeSysRoleRspManager>();
        }

        private static void InitializeDriveLicenceMasterData(IUnityContainer container)
        {
            container.RegisterType<IUserManager, UserManager>();
            container.RegisterType<IRoleManager, RoleManager>();
            container.RegisterType<IPermissionManager, PermissionManager>();
            container.RegisterType<IExamClassManager, ExamClassManager>();
            container.RegisterType<IRequiredExamClassManager, RequiredExamClassManager>();
            container.RegisterType<IInclusiveExamClassManager, InclusiveExamClassManager>();
            container.RegisterType<ISysTableManager, SysTableManager>();
            container.RegisterType<ISysColumnManager, SysColumnManager>();
            container.RegisterType<ILegalBasisManager, LegalBasisManager>();
            container.RegisterType<IReturnReasonManager, ReturnReasonManager>();
            container.RegisterType<ICoreDataProductManager, CoreDataProductManager>();
            container.RegisterType<ICoreDataProductLocalizationManager, CoreDataProductLocalizationManager>();
            container.RegisterType<ICoreDataProductClassBasisManager, CoreDataProductClassBasisManager>();
            container.RegisterType<IExamRecognitionTypeManager, ExamRecognitionTypeManager>();
        }
    }
}
