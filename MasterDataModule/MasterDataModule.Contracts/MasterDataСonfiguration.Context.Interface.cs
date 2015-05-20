






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
        ///     Set of <see cref="MasterDataWcfInfo"/> entities from table dbo.MASTER_DATA_WCF_INFO
        /// </summary>
        IQueryable<MasterDataWcfInfo> MasterDataWcfInfo{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataWcfCheckResults"/> entities from table dbo.MASTER_DATA_WCF_CHECK_RESULTS
        /// </summary>
        IQueryable<MasterDataWcfCheckResults> MasterDataWcfCheckResults{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataSiteInfo"/> entities from table dbo.MASTER_DATA_SITE_INFO
        /// </summary>
        IQueryable<MasterDataSiteInfo> MasterDataSiteInfo{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataSiteCheckResults"/> entities from table dbo.MASTER_DATA_SITE_CHECK_RESULTS
        /// </summary>
        IQueryable<MasterDataSiteCheckResults> MasterDataSiteCheckResults{get;}
        /// <summary>
        ///     Set of <see cref="SysColumn"/> entities from table dbo.SYS_COLUMNS
        /// </summary>
        IQueryable<SysColumn> SysColumn{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataMonitorState"/> entities from table dbo.MASTER_DATA_MONITOR_STATE
        /// </summary>
        IQueryable<MasterDataMonitorState> MasterDataMonitorState{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataJobInfo"/> entities from table dbo.MASTER_DATA_JOB_INFO
        /// </summary>
        IQueryable<MasterDataJobInfo> MasterDataJobInfo{get;}
        /// <summary>
        ///     Set of <see cref="GetApplicationLogs"/> entities from table dbo.GET_APPLICATION_LOGS
        /// </summary>
        IQueryable<GetApplicationLogs> GetApplicationLogs{get;}
        /// <summary>
        ///     Set of <see cref="SysTable"/> entities from table dbo.SYS_TABLES
        /// </summary>
        IQueryable<SysTable> SysTable{get;}
        /// <summary>
        ///     Set of <see cref="SiteInfosWithLastResult"/> entities from table dbo.SITE_INFOS_WITH_LAST_RESULT
        /// </summary>
        IQueryable<SiteInfosWithLastResult> SiteInfosWithLastResult{get;}
        /// <summary>
        ///     Set of <see cref="WcfInfosWithLastResult"/> entities from table dbo.WCF_INFOS_WITH_LAST_RESULT
        /// </summary>
        IQueryable<WcfInfosWithLastResult> WcfInfosWithLastResult{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataJobCheckResults"/> entities from table dbo.MASTER_DATA_JOB_CHECK_RESULTS
        /// </summary>
        IQueryable<MasterDataJobCheckResults> MasterDataJobCheckResults{get;}
        /// <summary>
        ///     Set of <see cref="WinserviceInfosWithLastResult"/> entities from table dbo.WINSERVICE_INFOS_WITH_LAST_RESULT
        /// </summary>
        IQueryable<WinserviceInfosWithLastResult> WinserviceInfosWithLastResult{get;}
        /// <summary>
        ///     Set of <see cref="JobsInfosWithLastResult"/> entities from table dbo.JOBS_INFOS_WITH_LAST_RESULT
        /// </summary>
        IQueryable<JobsInfosWithLastResult> JobsInfosWithLastResult{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataWindowsServiceInfo"/> entities from table dbo.MASTER_DATA_WINDOWS_SERVICE_INFO
        /// </summary>
        IQueryable<MasterDataWindowsServiceInfo> MasterDataWindowsServiceInfo{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataWindowsServiceCheckResults"/> entities from table dbo.MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS
        /// </summary>
        IQueryable<MasterDataWindowsServiceCheckResults> MasterDataWindowsServiceCheckResults{get;}
        /// <summary>
        ///     Set of <see cref="LogTypeInfo"/> entities from table dbo.LOG_TYPE_INFO
        /// </summary>
        IQueryable<LogTypeInfo> LogTypeInfo{get;}
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
        ///     Set of <see cref="ApplicationLogs"/> entities from table dbo.APPLICATION_LOGS
        /// </summary>
        IQueryable<ApplicationLogs> ApplicationLogs{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataSubscribers"/> entities from table dbo.MASTER_DATA_SUBSCRIBERS
        /// </summary>
        IQueryable<MasterDataSubscribers> MasterDataSubscribers{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataNotifications"/> entities from table dbo.MASTER_DATA_NOTIFICATIONS
        /// </summary>
        IQueryable<MasterDataNotifications> MasterDataNotifications{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp"/> entities from table dbo.MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP
        /// </summary>
        IQueryable<MasterDataMonitorableInfoMasterDataNotificationsRsp> MasterDataMonitorableInfoMasterDataNotificationsRsp{get;}
        /// <summary>
        ///     Set of <see cref="MasterDataNotificationsMasterDataSubscribersRsp"/> entities from table dbo.MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP
        /// </summary>
        IQueryable<MasterDataNotificationsMasterDataSubscribersRsp> MasterDataNotificationsMasterDataSubscribersRsp{get;}
        /// <summary>
        ///     Set of <see cref="GetWinServicesStatus"/> entities from table dbo.GET_WIN_SERVICES_STATUS
        /// </summary>
        IQueryable<GetWinServicesStatus> GetWinServicesStatus{get;}
        /// <summary>
        ///     Set of <see cref="GetSitesStatus"/> entities from table dbo.GET_SITES_STATUS
        /// </summary>
        IQueryable<GetSitesStatus> GetSitesStatus{get;}
        /// <summary>
        ///     Set of <see cref="GetJobsStatus"/> entities from table dbo.GET_JOBS_STATUS
        /// </summary>
        IQueryable<GetJobsStatus> GetJobsStatus{get;}
        /// <summary>
        ///     Set of <see cref="GetWcfServicesStatus"/> entities from table dbo.GET_WCF_SERVICES_STATUS
        /// </summary>
        IQueryable<GetWcfServicesStatus> GetWcfServicesStatus{get;}
    }
}
