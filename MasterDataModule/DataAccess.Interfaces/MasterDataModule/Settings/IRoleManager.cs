using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings
{
    /// <summary>
    /// 
    /// </summary>
	public interface IRoleManager : IEntityManager<Role, int>
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <param name="permissions"></param>
		void SetPermissions(Role role, IEnumerable<int> permissions);
	}
}
