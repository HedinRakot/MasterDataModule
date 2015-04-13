






using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Lib.Data.Configuration;
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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(MasterDataWcfInfoMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataWcfCheckResultsMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataSiteInfoMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataSiteCheckResultsMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataMonitorStateMapping.Instance);
            modelBuilder.Configurations.Add(ApplicationLogsMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataJobInfoMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataJobCheckResultsMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataWindowsServiceInfoMapping.Instance);
            modelBuilder.Configurations.Add(SysColumnMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataWindowsServiceCheckResultsMapping.Instance);
            modelBuilder.Configurations.Add(SysTableMapping.Instance);
            modelBuilder.Configurations.Add(RoleMapping.Instance);
            modelBuilder.Configurations.Add(PermissionMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataRolePermissionRspMapping.Instance);
            modelBuilder.Configurations.Add(UserMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataSubscribersMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataMonitorableInfoMasterDataNotificationsRspMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataNotificationsMasterDataSubscribersRspMapping.Instance);
            modelBuilder.Configurations.Add(MasterDataNotificationsMapping.Instance);
        }

        /// <summary>
        ///     Set of <see cref="MasterDataWcfInfo"/> entities from table dbo.MASTER_DATA_WCF_INFO
        /// </summary>
        public IQueryable<MasterDataWcfInfo> MasterDataWcfInfo{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataWcfCheckResults"/> entities from table dbo.MASTER_DATA_WCF_CHECK_RESULTS
        /// </summary>
        public IQueryable<MasterDataWcfCheckResults> MasterDataWcfCheckResults{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataSiteInfo"/> entities from table dbo.MASTER_DATA_SITE_INFO
        /// </summary>
        public IQueryable<MasterDataSiteInfo> MasterDataSiteInfo{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataSiteCheckResults"/> entities from table dbo.MASTER_DATA_SITE_CHECK_RESULTS
        /// </summary>
        public IQueryable<MasterDataSiteCheckResults> MasterDataSiteCheckResults{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataMonitorState"/> entities from table dbo.MASTER_DATA_MONITOR_STATE
        /// </summary>
        public IQueryable<MasterDataMonitorState> MasterDataMonitorState{ get; set; }
        /// <summary>
        ///     Set of <see cref="ApplicationLogs"/> entities from table dbo.APPLICATION_LOGS
        /// </summary>
        public IQueryable<ApplicationLogs> ApplicationLogs{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataJobInfo"/> entities from table dbo.MASTER_DATA_JOB_INFO
        /// </summary>
        public IQueryable<MasterDataJobInfo> MasterDataJobInfo{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataJobCheckResults"/> entities from table dbo.MASTER_DATA_JOB_CHECK_RESULTS
        /// </summary>
        public IQueryable<MasterDataJobCheckResults> MasterDataJobCheckResults{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataWindowsServiceInfo"/> entities from table dbo.MASTER_DATA_WINDOWS_SERVICE_INFO
        /// </summary>
        public IQueryable<MasterDataWindowsServiceInfo> MasterDataWindowsServiceInfo{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysColumn"/> entities from table dbo.SYS_COLUMNS
        /// </summary>
        public IQueryable<SysColumn> SysColumn{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataWindowsServiceCheckResults"/> entities from table dbo.MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS
        /// </summary>
        public IQueryable<MasterDataWindowsServiceCheckResults> MasterDataWindowsServiceCheckResults{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysTable"/> entities from table dbo.SYS_TABLES
        /// </summary>
        public IQueryable<SysTable> SysTable{ get; set; }
        /// <summary>
        ///     Set of <see cref="Role"/> entities from table dbo.MASTER_DATA_ROLE
        /// </summary>
        public IQueryable<Role> Role{ get; set; }
        /// <summary>
        ///     Set of <see cref="Permission"/> entities from table dbo.MASTER_DATA_PERMISSION
        /// </summary>
        public IQueryable<Permission> Permission{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataRolePermissionRsp"/> entities from table dbo.MASTER_DATA_ROLE_PERMISSION_RSP
        /// </summary>
        public IQueryable<MasterDataRolePermissionRsp> MasterDataRolePermissionRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="User"/> entities from table dbo.MASTER_DATA_USER
        /// </summary>
        public IQueryable<User> User{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataSubscribers"/> entities from table dbo.MASTER_DATA_SUBSCRIBERS
        /// </summary>
        public IQueryable<MasterDataSubscribers> MasterDataSubscribers{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp"/> entities from table dbo.MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP
        /// </summary>
        public IQueryable<MasterDataMonitorableInfoMasterDataNotificationsRsp> MasterDataMonitorableInfoMasterDataNotificationsRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataNotificationsMasterDataSubscribersRsp"/> entities from table dbo.MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP
        /// </summary>
        public IQueryable<MasterDataNotificationsMasterDataSubscribersRsp> MasterDataNotificationsMasterDataSubscribersRsp{ get; set; }
        /// <summary>
        ///     Set of <see cref="MasterDataNotifications"/> entities from table dbo.MASTER_DATA_NOTIFICATIONS
        /// </summary>
        public IQueryable<MasterDataNotifications> MasterDataNotifications{ get; set; }
    }
}
