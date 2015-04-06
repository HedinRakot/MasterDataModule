using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_WCF_CHECK_RESULTS to entity <see cref="MasterDataWcfCheckResults"/>
    /// </summary>
    internal sealed class MasterDataWcfCheckResultsMapping: EntityTypeConfiguration<MasterDataWcfCheckResults>
    {
        
        public static readonly MasterDataWcfCheckResultsMapping Instance = new MasterDataWcfCheckResultsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataWcfCheckResultsMapping" /> class.
        /// </summary>
        private MasterDataWcfCheckResultsMapping()
        {

            ToTable("MASTER_DATA_WCF_CHECK_RESULTS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataWcfCheckResults.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(MasterDataWcfCheckResults.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(MasterDataWcfCheckResults.Fields.CheckDate);

            Property(t => t.Message)
                .HasColumnName(MasterDataWcfCheckResults.Fields.Message)
                .IsUnicode();

            Property(t => t.Attempt)
                .HasColumnName(MasterDataWcfCheckResults.Fields.Attempt);

            Property(t => t.MasterDataWcfInfoId)
                .HasColumnName(MasterDataWcfCheckResults.Fields.MasterDataWcfInfoId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataWcfCheckResults.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataWcfCheckResults.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataWcfCheckResults.Fields.ChangeDate)
                .IsRequired();


            //Relationships
            HasRequired(m => m.MasterDataWcfInfo)
                .WithMany(m => m.MasterDataWcfCheckResults)
                .HasForeignKey(t => t.MasterDataWcfInfoId);
        }
    }
}
