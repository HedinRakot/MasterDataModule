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
    // MASTER_DATA_WCF_CHECK_RESULTS
    internal partial class MasterDataWcfCheckResultsConfiguration : EntityTypeConfiguration<MasterDataWcfCheckResults>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataWcfCheckResultsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MASTER_DATA_WCF_CHECK_RESULTS");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CheckStatus).HasColumnName("CHECK_STATUS").IsOptional();
            Property(x => x.CheckDate).HasColumnName("CHECK_DATE").IsOptional();
            Property(x => x.Message).HasColumnName("MESSAGE").IsOptional();
            Property(x => x.Attempt).HasColumnName("ATTEMPT").IsOptional();
            Property(x => x.MasterDataWcfInfoId).HasColumnName("MASTER_DATA_WCF_INFO_ID").IsRequired();

            // Foreign keys
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
