using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.WINSERVICE_INFOS_WITH_LAST_RESULT to entity <see cref="WinserviceInfosWithLastResult"/>
    /// </summary>
    internal sealed class WinserviceInfosWithLastResultMapping: EntityTypeConfiguration<WinserviceInfosWithLastResult>
    {
        
        public static readonly WinserviceInfosWithLastResultMapping Instance = new WinserviceInfosWithLastResultMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="WinserviceInfosWithLastResultMapping" /> class.
        /// </summary>
        private WinserviceInfosWithLastResultMapping()
        {

            ToTable("WINSERVICE_INFOS_WITH_LAST_RESULT", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(WinserviceInfosWithLastResult.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(WinserviceInfosWithLastResult.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(WinserviceInfosWithLastResult.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(WinserviceInfosWithLastResult.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(WinserviceInfosWithLastResult.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LastResult)
                .HasColumnName(WinserviceInfosWithLastResult.Fields.LastResult);


            //Relationships
        }
    }
}
