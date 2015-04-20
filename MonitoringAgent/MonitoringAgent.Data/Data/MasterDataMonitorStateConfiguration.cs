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
    // MASTER_DATA_MONITOR_STATE
    internal partial class MasterDataMonitorStateConfiguration : EntityTypeConfiguration<MasterDataMonitorState>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataMonitorStateConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MASTER_DATA_MONITOR_STATE");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Reconfigure).HasColumnName("RECONFIGURE").IsOptional();
            Property(x => x.ReconfigureCheckingTimeout).HasColumnName("RECONFIGURE_CHECKING_TIMEOUT").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            Property(x => x.FromDate).HasColumnName("FROM_DATE").IsRequired();
            Property(x => x.ToDate).HasColumnName("TO_DATE").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
