using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.WCF_INFOS_WITH_LAST_RESULT to entity <see cref="WcfInfosWithLastResult"/>
    /// </summary>
    internal sealed class WcfInfosWithLastResultMapping: EntityTypeConfiguration<WcfInfosWithLastResult>
    {
        
        public static readonly WcfInfosWithLastResultMapping Instance = new WcfInfosWithLastResultMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="WcfInfosWithLastResultMapping" /> class.
        /// </summary>
        private WcfInfosWithLastResultMapping()
        {

            ToTable("WCF_INFOS_WITH_LAST_RESULT", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(WcfInfosWithLastResult.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(WcfInfosWithLastResult.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(WcfInfosWithLastResult.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(WcfInfosWithLastResult.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(WcfInfosWithLastResult.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LastResult)
                .HasColumnName(WcfInfosWithLastResult.Fields.LastResult);


            //Relationships
        }
    }
}
