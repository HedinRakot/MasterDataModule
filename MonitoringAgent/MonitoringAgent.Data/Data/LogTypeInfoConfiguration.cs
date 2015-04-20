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
    // LOG_TYPE_INFO
    internal partial class LogTypeInfoConfiguration : EntityTypeConfiguration<LogTypeInfo>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public LogTypeInfoConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".LOG_TYPE_INFO");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            Property(x => x.FromDate).HasColumnName("FROM_DATE").IsRequired();
            Property(x => x.ToDate).HasColumnName("TO_DATE").IsRequired();
            Property(x => x.FileName).HasColumnName("FILE_NAME").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.FilePattern).HasColumnName("FILE_PATTERN").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.FilePath).HasColumnName("FILE_PATH").IsRequired();
            Property(x => x.LastReadDate).HasColumnName("LAST_READ_DATE").IsOptional();
            Property(x => x.MessagePattern).HasColumnName("MESSAGE_PATTERN").IsOptional();
            Property(x => x.LastReadPosition).HasColumnName("LAST_READ_POSITION").IsOptional();
            Property(x => x.StartMessagePattern).HasColumnName("START_MESSAGE_PATTERN").IsOptional();
            Property(x => x.CheckingTimeout).HasColumnName("CHECKING_TIMEOUT").IsOptional();
            Property(x => x.LastProcessedFile).HasColumnName("LAST_PROCESSED_FILE").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
