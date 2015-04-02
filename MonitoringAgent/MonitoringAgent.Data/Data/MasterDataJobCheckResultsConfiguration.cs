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
    // MASTER_DATA_JOB_CHECK_RESULTS
    internal partial class MasterDataJobCheckResultsConfiguration : EntityTypeConfiguration<MasterDataJobCheckResults>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataJobCheckResultsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MASTER_DATA_JOB_CHECK_RESULTS");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastRunTime).HasColumnName("LAST_RUN_TIME").IsOptional();
            Property(x => x.CheckDate).HasColumnName("CHECK_DATE").IsOptional();
            Property(x => x.CheckStatus).HasColumnName("CHECK_STATUS").IsOptional();
            Property(x => x.MasterDataJobInfoId).HasColumnName("MASTER_DATA_JOB_INFO_ID").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
