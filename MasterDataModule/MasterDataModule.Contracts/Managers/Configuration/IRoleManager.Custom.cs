using System.Collections.Generic;
using MasterDataModule.Contracts.Entities.Configuration;

namespace MasterDataModule.Contracts.Managers.Configuration
{
    /// <summary>
    /// 
    /// </summary>
	public partial interface IRoleManager
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <param name="permissions"></param>
		void SetPermissions(Role role, IEnumerable<int> permissions);
	}
}
