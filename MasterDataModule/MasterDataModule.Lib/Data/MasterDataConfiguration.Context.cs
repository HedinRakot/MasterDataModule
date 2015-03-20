






using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using System.Data.Entity;
using System.Linq;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Database context for for MasterDataConfiguration
    /// </summary>
    public partial class MasterDataConfigurationEntities: IMasterDataConfigurationEntities
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(PermissionMapping.Instance);
            modelBuilder.Configurations.Add(RoleMapping.Instance);
            modelBuilder.Configurations.Add(UserMapping.Instance);
            modelBuilder.Configurations.Add(SysColumnMapping.Instance);
            modelBuilder.Configurations.Add(SysTableMapping.Instance);
        }

        /// <summary>
        ///     Set of <see cref="Permission"/> entities from table dbo.MASTER_DATA_PERMISSION
        /// </summary>
        public IQueryable<Permission> Permission{ get; set; }
        /// <summary>
        ///     Set of <see cref="Role"/> entities from table dbo.MASTER_DATA_ROLE
        /// </summary>
        public IQueryable<Role> Role{ get; set; }
        /// <summary>
        ///     Set of <see cref="User"/> entities from table dbo.MASTER_DATA_USER
        /// </summary>
        public IQueryable<User> User{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysColumn"/> entities from table dbo.SYS_COLUMNS
        /// </summary>
        public IQueryable<SysColumn> SysColumn{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysTable"/> entities from table dbo.SYS_TABLES
        /// </summary>
        public IQueryable<SysTable> SysTable{ get; set; }
    }
}
