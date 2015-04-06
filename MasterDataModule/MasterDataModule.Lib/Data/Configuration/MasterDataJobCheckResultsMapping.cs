using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_JOB_CHECK_RESULTS to entity <see cref="MasterDataJobCheckResults"/>
    /// </summary>
    internal sealed class MasterDataJobCheckResultsMapping: EntityTypeConfiguration<MasterDataJobCheckResults>
    {
        
        public static readonly MasterDataJobCheckResultsMapping Instance = new MasterDataJobCheckResultsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataJobCheckResultsMapping" /> class.
        /// </summary>
        private MasterDataJobCheckResultsMapping()
        {

            ToTable("MASTER_DATA_JOB_CHECK_RESULTS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataJobCheckResults.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.LastRunTime)
                .HasColumnName(MasterDataJobCheckResults.Fields.LastRunTime);

            Property(t => t.CheckDate)
                .HasColumnName(MasterDataJobCheckResults.Fields.CheckDate);

            Property(t => t.CheckStatus)
                .HasColumnName(MasterDataJobCheckResults.Fields.CheckStatus);

            Property(t => t.MasterDataJobInfoId)
                .HasColumnName(MasterDataJobCheckResults.Fields.MasterDataJobInfoId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataJobCheckResults.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataJobCheckResults.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataJobCheckResults.Fields.ChangeDate)
                .IsRequired();


            //Relationships
        }
    }
}
