using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.APPLICATION_LOGS to entity <see cref="ApplicationLogs"/>
    /// </summary>
    internal sealed class ApplicationLogsMapping: EntityTypeConfiguration<ApplicationLogs>
    {
        
        public static readonly ApplicationLogsMapping Instance = new ApplicationLogsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationLogsMapping" /> class.
        /// </summary>
        private ApplicationLogsMapping()
        {

            ToTable("APPLICATION_LOGS", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(ApplicationLogs.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.LogType)
                .HasColumnName(ApplicationLogs.Fields.LogType)
                .IsRequired();

            Property(t => t.LogLevel)
                .HasColumnName(ApplicationLogs.Fields.LogLevel)
                .IsRequired();

            Property(t => t.Date)
                .HasColumnName(ApplicationLogs.Fields.Date);

            Property(t => t.Message)
                .HasColumnName(ApplicationLogs.Fields.Message)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(ApplicationLogs.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(ApplicationLogs.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(ApplicationLogs.Fields.CreateDate)
                .IsRequired();


            //Relationships
        }
    }
}
