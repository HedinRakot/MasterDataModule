// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MonitoringAgent.Data.Interfaces.Entities;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace MonitoringAgent.Common.Data
{
    public interface IMasterDataDbContext : IDisposable
    {
        IDbSet<ApplicationLogs> ApplicationLogs { get; set; } // APPLICATION_LOGS
        IDbSet<GetWcfServicesStatus> GetWcfServicesStatus { get; set; } // GET_WCF_SERVICES_STATUS
        IDbSet<MasterDataJobCheckResults> MasterDataJobCheckResults { get; set; } // MASTER_DATA_JOB_CHECK_RESULTS
        IDbSet<MasterDataJobInfo> MasterDataJobInfoes { get; set; } // MASTER_DATA_JOB_INFO
        IDbSet<MasterDataMonitorableInfoMasterDataNotificationsRsp> MasterDataMonitorableInfoMasterDataNotificationsRsps { get; set; } // MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP
        IDbSet<MasterDataMonitorState> MasterDataMonitorStates { get; set; } // MASTER_DATA_MONITOR_STATE
        IDbSet<MasterDataNotifications> MasterDataNotifications { get; set; } // MASTER_DATA_NOTIFICATIONS
        IDbSet<MasterDataNotificationsMasterDataSubscribersRsp> MasterDataNotificationsMasterDataSubscribersRsps { get; set; } // MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP
        IDbSet<MasterDataSiteCheckResults> MasterDataSiteCheckResults { get; set; } // MASTER_DATA_SITE_CHECK_RESULTS
        IDbSet<MasterDataSiteInfo> MasterDataSiteInfoes { get; set; } // MASTER_DATA_SITE_INFO
        IDbSet<MasterDataSubscribers> MasterDataSubscribers { get; set; } // MASTER_DATA_SUBSCRIBERS
        IDbSet<MasterDataWcfCheckResults> MasterDataWcfCheckResults { get; set; } // MASTER_DATA_WCF_CHECK_RESULTS
        IDbSet<MasterDataWcfInfo> MasterDataWcfInfoes { get; set; } // MASTER_DATA_WCF_INFO
        IDbSet<MasterDataWindowsServiceCheckResults> MasterDataWindowsServiceCheckResults { get; set; } // MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS
        IDbSet<MasterDataWindowsServiceInfo> MasterDataWindowsServiceInfoes { get; set; } // MASTER_DATA_WINDOWS_SERVICE_INFO

        int SaveChanges();
    }

}
