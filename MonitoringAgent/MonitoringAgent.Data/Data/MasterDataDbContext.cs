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
        public IDbSet<MasterDataJobCheckResults> MasterDataJobCheckResults { get; set; } // MASTER_DATA_JOB_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataJobInfo> MasterDataJobInfoes { get; set; } // MASTER_DATA_JOB_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataMonitorState> MasterDataMonitorStates { get; set; } // MASTER_DATA_MONITOR_STATE

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataSiteCheckResults> MasterDataSiteCheckResults { get; set; } // MASTER_DATA_SITE_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataSiteInfo> MasterDataSiteInfoes { get; set; } // MASTER_DATA_SITE_INFO

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataWcfCheckResults> MasterDataWcfCheckResults { get; set; } // MASTER_DATA_WCF_CHECK_RESULTS

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<MasterDataWcfInfo> MasterDataWcfInfoes { get; set; } // MASTER_DATA_WCF_INFO

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

            modelBuilder.Configurations.Add(new MasterDataJobCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataJobInfoConfiguration());
            modelBuilder.Configurations.Add(new MasterDataMonitorStateConfiguration());
            modelBuilder.Configurations.Add(new MasterDataSiteCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataSiteInfoConfiguration());
            modelBuilder.Configurations.Add(new MasterDataWcfCheckResultsConfiguration());
            modelBuilder.Configurations.Add(new MasterDataWcfInfoConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new MasterDataJobCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataJobInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataMonitorStateConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataSiteCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataSiteInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataWcfCheckResultsConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterDataWcfInfoConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
    }
}
