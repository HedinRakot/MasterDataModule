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
    // MASTER_DATA_SITE_INFO
    internal partial class MasterDataSiteInfoConfiguration : EntityTypeConfiguration<MasterDataSiteInfo>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataSiteInfoConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MASTER_DATA_SITE_INFO");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("NAME").IsRequired();
            Property(x => x.TimeoutChecking).HasColumnName("TIMEOUT_CHECKING").IsRequired();
            Property(x => x.SitePath).HasColumnName("SITE_PATH").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            Property(x => x.FromDate).HasColumnName("FROM_DATE").IsRequired();
            Property(x => x.ToDate).HasColumnName("TO_DATE").IsRequired();
            Property(x => x.LogTypeInfoId).HasColumnName("LOG_TYPE_INFO_ID").IsOptional();

            // Foreign keys
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
