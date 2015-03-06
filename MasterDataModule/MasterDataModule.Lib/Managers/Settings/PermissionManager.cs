using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Settings
{
    /// <summary>
    /// 
    /// </summary>
	public class PermissionManager : EntityManager<Permission, int>, IPermissionManager
	{
        public PermissionManager(IFeEntities context) :
            base(context)
        {
        }
	}
}
