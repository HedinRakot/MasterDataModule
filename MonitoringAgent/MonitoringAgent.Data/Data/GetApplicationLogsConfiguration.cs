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
    // GET_APPLICATION_LOGS
    internal partial class GetApplicationLogsConfiguration : EntityTypeConfiguration<GetApplicationLogs>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public GetApplicationLogsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GET_APPLICATION_LOGS");
            HasKey(x => new { x.Id, x.LogLevel, x.Message, x.FileName, x.CreateDate, x.ChangeDate, x.LogTypeInfoId });

            Property(x => x.Id).HasColumnName("ID").IsRequired();
            Property(x => x.LogLevel).HasColumnName("LOG_LEVEL").IsRequired();
            Property(x => x.MessageDate).HasColumnName("MESSAGE_DATE").IsOptional();
            Property(x => x.Message).HasColumnName("MESSAGE").IsRequired();
            Property(x => x.FileName).HasColumnName("FILE_NAME").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            Property(x => x.LogTypeInfoId).HasColumnName("LOG_TYPE_INFO_ID").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
