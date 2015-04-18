using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.GET_SITES_STATUS to entity <see cref="GetSitesStatus"/>
    /// </summary>
    internal sealed class GetSitesStatusMapping: EntityTypeConfiguration<GetSitesStatus>
    {
        
        public static readonly GetSitesStatusMapping Instance = new GetSitesStatusMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetSitesStatusMapping" /> class.
        /// </summary>
        private GetSitesStatusMapping()
        {

            ToTable("GET_SITES_STATUS", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(GetSitesStatus.Fields.Id)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(GetSitesStatus.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(GetSitesStatus.Fields.CheckDate);

            Property(t => t.Message)
                .HasColumnName(GetSitesStatus.Fields.Message)
                .IsUnicode();

            Property(t => t.Attempt)
                .HasColumnName(GetSitesStatus.Fields.Attempt);

            Property(t => t.Name)
                .HasColumnName(GetSitesStatus.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.SitePath)
                .HasColumnName(GetSitesStatus.Fields.SitePath)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(GetSitesStatus.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(GetSitesStatus.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(GetSitesStatus.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(GetSitesStatus.Fields.LogTypeInfoId);


            //Relationships
        }
    }
}
