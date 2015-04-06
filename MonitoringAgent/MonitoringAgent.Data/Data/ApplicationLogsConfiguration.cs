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
    // APPLICATION_LOGS
    internal partial class ApplicationLogsConfiguration : EntityTypeConfiguration<ApplicationLogs>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public ApplicationLogsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".APPLICATION_LOGS");
            HasKey(x => new { x.Id, x.LogType, x.LogLevel, x.Message, x.ChangeDate, x.CreateDate });

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LogType).HasColumnName("LOG_TYPE").IsRequired();
            Property(x => x.LogLevel).HasColumnName("LOG_LEVEL").IsRequired();
            Property(x => x.Date).HasColumnName("DATE").IsOptional();
            Property(x => x.Message).HasColumnName("MESSAGE").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}