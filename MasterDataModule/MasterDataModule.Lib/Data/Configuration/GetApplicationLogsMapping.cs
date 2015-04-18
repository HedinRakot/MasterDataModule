using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.GET_APPLICATION_LOGS to entity <see cref="GetApplicationLogs"/>
    /// </summary>
    internal sealed class GetApplicationLogsMapping: EntityTypeConfiguration<GetApplicationLogs>
    {
        
        public static readonly GetApplicationLogsMapping Instance = new GetApplicationLogsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetApplicationLogsMapping" /> class.
        /// </summary>
        private GetApplicationLogsMapping()
        {

            ToTable("GET_APPLICATION_LOGS", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(GetApplicationLogs.Fields.Id)
                .IsRequired();

            Property(t => t.LogLevel)
                .HasColumnName(GetApplicationLogs.Fields.LogLevel)
                .IsRequired();

            Property(t => t.MessageDate)
                .HasColumnName(GetApplicationLogs.Fields.MessageDate);

            Property(t => t.Message)
                .HasColumnName(GetApplicationLogs.Fields.Message)
                .IsRequired()
                .IsUnicode();

            Property(t => t.FileName)
                .HasColumnName(GetApplicationLogs.Fields.FileName)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.DeleteDate)
                .HasColumnName(GetApplicationLogs.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(GetApplicationLogs.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(GetApplicationLogs.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(GetApplicationLogs.Fields.LogTypeInfoId)
                .IsRequired();


            //Relationships
        }
    }
}
