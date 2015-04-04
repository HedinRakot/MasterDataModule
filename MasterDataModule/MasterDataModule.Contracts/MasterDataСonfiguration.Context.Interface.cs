






using MasterDataModule.Contracts.Entities.Configuration;
using System.Linq;

namespace MasterDataModule.Contracts
{
    /// <summary>
    ///     Interface for MasterDataConfiguration context
    /// </summary>
    public partial interface IMasterDataConfigurationEntities
    {
        /// <summary>
        ///     Set of <see cref="SysColumn"/> entities from table dbo.SYS_COLUMNS
        /// </summary>
        IQueryable<SysColumn> SysColumn{get;}
        /// <summary>
        ///     Set of <see cref="SysTable"/> entities from table dbo.SYS_TABLES
        /// </summary>
        IQueryable<SysTable> SysTable{get;}
        /// <summary>
        ///     Set of <see cref="Role"/> entities from table dbo.MASTER_DATA_ROLE
        /// </summary>
        IQueryable<Role> Role{get;}
        /// <summary>
        ///     Set of <see cref="Permission"/> entities from table dbo.MASTER_DATA_PERMISSION
        /// </summary>
        IQueryable<Permission> Permission{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataRolePermissionRsp"/> entities from table dbo.MASTER_DATA_ROLE_PERMISSION_RSP
        /// </summary>
        IQueryable<MasterDataRolePermissionRsp> MasterDataRolePermissionRsp{get;}
        /// <summary>
        ///     Set of <see cref="User"/> entities from table dbo.MASTER_DATA_USER
        /// </summary>
        IQueryable<User> User{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataSiteInfo"/> entities from table dbo.MASTER_DATA_SITE_INFO
        /// </summary>
        IQueryable<MasterDataSiteInfo> MasterDataSiteInfo{get;}
    }
}
