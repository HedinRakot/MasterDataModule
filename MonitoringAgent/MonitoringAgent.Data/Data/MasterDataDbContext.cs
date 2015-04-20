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
    public partial class MasterDataDbContext : DbContext, IMasterDataDbContext
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<ApplicationLogs> ApplicationLogs { get; set; } // APPLICATION_LOGS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<GetApplicationLogs> GetApplicationLogs { get; set; } // GET_APPLICATION_LOGS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<GetJobsStatus> GetJobsStatus { get; set; } // GET_JOBS_STATUS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<GetSitesStatus> GetSitesStatus { get; set; } // GET_SITES_STATUS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<GetWcfServicesStatus> GetWcfServicesStatus { get; set; } // GET_WCF_SERVICES_STATUS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<GetWinServicesStatus> GetWinServicesStatus { get; set; } // GET_WIN_SERVICES_STATUS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<JobsInfosWithLastResult> JobsInfosWithLastResults { get; set; } // JOBS_INFOS_WITH_LAST_RESULT

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<LogTypeInfo> LogTypeInfoes { get; set; } // LOG_TYPE_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataJobCheckResults> MasterDataJobCheckResults { get; set; } // MASTER_DATA_JOB_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataJobInfo> MasterDataJobInfoes { get; set; } // MASTER_DATA_JOB_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataMonitorableInfoMasterDataNotificationsRsp> MasterDataMonitorableInfoMasterDataNotificationsRsps { get; set; } // MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataMonitorState> MasterDataMonitorStates { get; set; } // MASTER_DATA_MONITOR_STATE

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataNotifications> MasterDataNotifications { get; set; } // MASTER_DATA_NOTIFICATIONS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataNotificationsMasterDataSubscribersRsp> MasterDataNotificationsMasterDataSubscribersRsps { get; set; } // MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataSiteCheckResults> MasterDataSiteCheckResults { get; set; } // MASTER_DATA_SITE_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataSiteInfo> MasterDataSiteInfoes { get; set; } // MASTER_DATA_SITE_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataSubscribers> MasterDataSubscribers { get; set; } // MASTER_DATA_SUBSCRIBERS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataWcfCheckResults> MasterDataWcfCheckResults { get; set; } // MASTER_DATA_WCF_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataWcfInfo> MasterDataWcfInfoes { get; set; } // MASTER_DATA_WCF_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataWindowsServiceCheckResults> MasterDataWindowsServiceCheckResults { get; set; } // MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataWindowsServiceInfo> MasterDataWindowsServiceInfoes { get; set; } // MASTER_DATA_WINDOWS_SERVICE_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<SiteInfosWithLastResult> SiteInfosWithLastResults { get; set; } // SITE_INFOS_WITH_LAST_RESULT

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<WcfInfosWithLastResult> WcfInfosWithLastResults { get; set; } // WCF_INFOS_WITH_LAST_RESULT

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<WinserviceInfosWithLastResult> WinserviceInfosWithLastResults { get; set; } // WINSERVICE_INFOS_WITH_LAST_RESULT

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        static MasterDataDbContext()
        {
            Database.SetInitializer<MasterDataDbContext>(null);
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataDbContext()
            : base("Name=MasterDataMonitoringModelContainer")
        {
            InitializePartial();
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataDbContext(string connectionString) : base(connectionString)
        {
            InitializePartial();
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
            InitializePartial();
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ApplicationLogsConfiguration());
            modelBuilder.Configurations.Add(new GetApplicationLogsConfiguration());
            modelBuilder.Configurations.Add(new GetJobsStatusConfiguration());
            modelBuilder.Configurations.Add(new GetSitesStatusConfiguration());
            modelBuilder.Configurations.Add(new GetWcfServicesStatusConfiguration());
            modelBuilder.Configurations.Add(new GetWinServicesStatusConfiguration());
            modelBuilder.Configurations.Add(new JobsInfosWithLastResultConfiguration());
            modelBuilder.Configurations.Add(new LogTypeInfoConfiguration());
            modelBuilder.Configurations.Add(new MasterDataJobCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataJobInfoConfiguration());
            modelBuilder.Configurations.Add(new MasterDataMonitorableInfoMasterDataNotificationsRspConfiguration());
            modelBuilder.Configurations.Add(new MasterDataMonitorStateConfiguration());
            modelBuilder.Configurations.Add(new MasterDataNotificationsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataNotificationsMasterDataSubscribersRspConfiguration());
            modelBuilder.Configurations.Add(new MasterDataSiteCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataSiteInfoConfiguration());
            modelBuilder.Configurations.Add(new MasterDataSubscribersConfiguration());
            modelBuilder.Configurations.Add(new MasterDataWcfCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataWcfInfoConfiguration());
            modelBuilder.Configurations.Add(new MasterDataWindowsServiceCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataWindowsServiceInfoConfiguration());
            modelBuilder.Configurations.Add(new SiteInfosWithLastResultConfiguration());
            modelBuilder.Configurations.Add(new WcfInfosWithLastResultConfiguration());
            modelBuilder.Configurations.Add(new WinserviceInfosWithLastResultConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ApplicationLogsConfiguration(schema));
            modelBuilder.Configurations.Add(new GetApplicationLogsConfiguration(schema));
            modelBuilder.Configurations.Add(new GetJobsStatusConfiguration(schema));
            modelBuilder.Configurations.Add(new GetSitesStatusConfiguration(schema));
            modelBuilder.Configurations.Add(new GetWcfServicesStatusConfiguration(schema));
            modelBuilder.Configurations.Add(new GetWinServicesStatusConfiguration(schema));
            modelBuilder.Configurations.Add(new JobsInfosWithLastResultConfiguration(schema));
            modelBuilder.Configurations.Add(new LogTypeInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataJobCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataJobInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataMonitorableInfoMasterDataNotificationsRspConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataMonitorStateConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataNotificationsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataNotificationsMasterDataSubscribersRspConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataSiteCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataSiteInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataSubscribersConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataWcfCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataWcfInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataWindowsServiceCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataWindowsServiceInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new SiteInfosWithLastResultConfiguration(schema));
            modelBuilder.Configurations.Add(new WcfInfosWithLastResultConfiguration(schema));
            modelBuilder.Configurations.Add(new WinserviceInfosWithLastResultConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
    }
}
