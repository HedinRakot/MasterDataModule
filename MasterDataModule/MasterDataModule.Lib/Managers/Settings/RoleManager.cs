using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	public class RoleManager : EntityManager<Role, int>, IRoleManager
	{
        private readonly IPermissionManager permissionManager;
        public RoleManager(IPermissionManager permissionManager, IFeEntities context) :
            base(context)
        {
            this.permissionManager = permissionManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <param name="permissions"></param>
		public void SetPermissions(Role role, IEnumerable<int> permissions)
		{
			role.Permissions.Clear();

			if (permissions == null)
				return;

			foreach (var id in permissions)
				role.Permissions.Add(permissionManager.GetByID(id));
		}
	}
}
