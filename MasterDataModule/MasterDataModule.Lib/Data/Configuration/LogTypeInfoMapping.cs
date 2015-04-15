using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.LOG_TYPE_INFO to entity <see cref="LogTypeInfo"/>
    /// </summary>
    internal sealed class LogTypeInfoMapping: EntityTypeConfiguration<LogTypeInfo>
    {
        
        public static readonly LogTypeInfoMapping Instance = new LogTypeInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="LogTypeInfoMapping" /> class.
        /// </summary>
        private LogTypeInfoMapping()
        {

            ToTable("LOG_TYPE_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(LogTypeInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(LogTypeInfo.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(LogTypeInfo.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(LogTypeInfo.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(LogTypeInfo.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(LogTypeInfo.Fields.ToDate)
                .IsRequired();

            Property(t => t.FileName)
                .HasColumnName(LogTypeInfo.Fields.FileName)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.FilePattern)
                .HasColumnName(LogTypeInfo.Fields.FilePattern)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.FilePath)
                .HasColumnName(LogTypeInfo.Fields.FilePath)
                .IsRequired();


            //Relationships
        }
    }
}
