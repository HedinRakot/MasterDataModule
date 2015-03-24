using System.Collections.Generic;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers.Configuration;

namespace MasterDataModule.Lib.Managers.Configuration
{
    /// <summary>
    /// </summary>
    public partial class RoleManager
    {
        private readonly IPermissionManager _permissionManager;
        public RoleManager(IPermissionManager permissionManager, IMasterDataConfigurationEntities context)
            : base(context)
        {
            _permissionManager = permissionManager;
        }

        /// <summary>
        /// </summary>
        /// <param name="role"></param>
        /// <param name="permissions"></param>
        public void SetPermissions(Role role, IEnumerable<int> permissions)
        {
            role.Permissions.Clear();

            if (permissions == null)
            {
                return;
            }
            foreach (var id in permissions)
            {
                role.Permissions.Add(_permissionManager.GetById(id));
            }
        }
    }
}