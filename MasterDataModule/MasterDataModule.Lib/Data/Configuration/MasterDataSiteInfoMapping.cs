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

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataSiteInfo.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataSiteInfo.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataSiteInfo.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(MasterDataSiteInfo.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataSiteInfo.Fields.ToDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(MasterDataSiteInfo.Fields.LogTypeInfoId);


            //Relationships
            HasOptional(m => m.LogTypeInfo)
                .WithMany(l => l.MasterDataSiteInfos)
                .HasForeignKey(t => t.LogTypeInfoId);
        }
    }
}
