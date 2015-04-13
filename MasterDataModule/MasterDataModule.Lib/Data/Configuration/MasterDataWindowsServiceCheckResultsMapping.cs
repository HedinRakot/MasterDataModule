using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS to entity <see cref="MasterDataWindowsServiceCheckResults"/>
    /// </summary>
    internal sealed class MasterDataWindowsServiceCheckResultsMapping: EntityTypeConfiguration<MasterDataWindowsServiceCheckResults>
    {
        
        public static readonly MasterDataWindowsServiceCheckResultsMapping Instance = new MasterDataWindowsServiceCheckResultsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataWindowsServiceCheckResultsMapping" /> class.
        /// </summary>
        private MasterDataWindowsServiceCheckResultsMapping()
        {

            ToTable("MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.CheckDate);

            Property(t => t.Message)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.Message)
                .IsUnicode();

            Property(t => t.Attempt)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.Attempt);

            Property(t => t.MasterDataWindowsServiceInfoId)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.MasterDataWindowsServiceInfoId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataWindowsServiceCheckResults.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasRequired(m => m.MasterDataWindowsServiceInfo)
                .WithMany(m => m.MasterDataWindowsServiceCheckResults)
                .HasForeignKey(t => t.MasterDataWindowsServiceInfoId);
        }
    }
}
