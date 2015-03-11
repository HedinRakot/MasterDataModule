using System.Collections.Generic;
using MasterDataModule.Contracts.Entities;

namespace MasterDataModule.Contracts.Managers
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
