using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.SITE_INFOS_WITH_LAST_RESULT to entity <see cref="SiteInfosWithLastResult"/>
    /// </summary>
    internal sealed class SiteInfosWithLastResultMapping: EntityTypeConfiguration<SiteInfosWithLastResult>
    {
        
        public static readonly SiteInfosWithLastResultMapping Instance = new SiteInfosWithLastResultMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SiteInfosWithLastResultMapping" /> class.
        /// </summary>
        private SiteInfosWithLastResultMapping()
        {

            ToTable("SITE_INFOS_WITH_LAST_RESULT", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(SiteInfosWithLastResult.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(SiteInfosWithLastResult.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(SiteInfosWithLastResult.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(SiteInfosWithLastResult.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(SiteInfosWithLastResult.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LastResult)
                .HasColumnName(SiteInfosWithLastResult.Fields.LastResult);


            //Relationships
        }
    }
}
