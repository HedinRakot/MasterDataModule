using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_SITE_INFO to entity <see cref="MasterDataSiteInfo"/>
    /// </summary>
    internal sealed class MasterDataSiteInfoMapping: EntityTypeConfiguration<MasterDataSiteInfo>
    {
        
        public static readonly MasterDataSiteInfoMapping Instance = new MasterDataSiteInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataSiteInfoMapping" /> class.
        /// </summary>
        private MasterDataSiteInfoMapping()
        {

            ToTable("MASTER_DATA_SITE_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataSiteInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(MasterDataSiteInfo.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.TimeoutChecking)
                .HasColumnName(MasterDataSiteInfo.Fields.TimeoutChecking)
                .IsRequired();

            Property(t => t.SitePath)
                .HasColumnName(MasterDataSiteInfo.Fields.SitePath)
                .IsRequired()
                .IsUnicode();


            //Relationships
        }
    }
}
