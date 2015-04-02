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
    // MASTER_DATA_JOB_INFO
    internal partial class MasterDataJobInfoConfiguration : EntityTypeConfiguration<MasterDataJobInfo>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataJobInfoConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MASTER_DATA_JOB_INFO");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ConnectionString).HasColumnName("CONNECTION_STRING").IsRequired();
            Property(x => x.TableName).HasColumnName("TABLE_NAME").IsRequired();
            Property(x => x.TimeoutChecking).HasColumnName("TIMEOUT_CHECKING").IsRequired();
            Property(x => x.Name).HasColumnName("NAME").IsRequired();
            Property(x => x.JobName).HasColumnName("JOB_NAME").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
