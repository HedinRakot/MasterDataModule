using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_JOB_INFO to entity <see cref="MasterDataJobInfo"/>
    /// </summary>
    internal sealed class MasterDataJobInfoMapping: EntityTypeConfiguration<MasterDataJobInfo>
    {
        
        public static readonly MasterDataJobInfoMapping Instance = new MasterDataJobInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataJobInfoMapping" /> class.
        /// </summary>
        private MasterDataJobInfoMapping()
        {

            ToTable("MASTER_DATA_JOB_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataJobInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.ConnectionString)
                .HasColumnName(MasterDataJobInfo.Fields.ConnectionString)
                .IsRequired()
                .IsUnicode();

            Property(t => t.TableName)
                .HasColumnName(MasterDataJobInfo.Fields.TableName)
                .IsRequired()
                .IsUnicode();

            Property(t => t.TimeoutChecking)
                .HasColumnName(MasterDataJobInfo.Fields.TimeoutChecking)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(MasterDataJobInfo.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.JobName)
                .HasColumnName(MasterDataJobInfo.Fields.JobName)
                .IsRequired()
                .IsUnicode();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataJobInfo.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataJobInfo.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataJobInfo.Fields.ChangeDate)
                .IsRequired();


            //Relationships
        }
    }
}
