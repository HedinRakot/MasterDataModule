using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_SITE_CHECK_RESULTS to entity <see cref="MasterDataSiteCheckResults"/>
    /// </summary>
    internal sealed class MasterDataSiteCheckResultsMapping: EntityTypeConfiguration<MasterDataSiteCheckResults>
    {
        
        public static readonly MasterDataSiteCheckResultsMapping Instance = new MasterDataSiteCheckResultsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataSiteCheckResultsMapping" /> class.
        /// </summary>
        private MasterDataSiteCheckResultsMapping()
        {

            ToTable("MASTER_DATA_SITE_CHECK_RESULTS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataSiteCheckResults.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(MasterDataSiteCheckResults.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(MasterDataSiteCheckResults.Fields.CheckDate);

            Property(t => t.Message)
                .HasColumnName(MasterDataSiteCheckResults.Fields.Message)
                .IsUnicode();

            Property(t => t.Attempt)
                .HasColumnName(MasterDataSiteCheckResults.Fields.Attempt);

            Property(t => t.MasterDataSiteInfoId)
                .HasColumnName(MasterDataSiteCheckResults.Fields.MasterDataSiteInfoId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataSiteCheckResults.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataSiteCheckResults.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataSiteCheckResults.Fields.ChangeDate)
                .IsRequired();


            //Relationships
            HasRequired(m => m.MasterDataSiteInfo)
                .WithMany(m => m.MasterDataSiteCheckResults)
                .HasForeignKey(t => t.MasterDataSiteInfoId);
        }
    }
}
