using System.Data.Entity.ModelConfiguration;
using MasterDataModule.Contracts.Entities.Monitor;

namespace MasterDataModule.Lib.Data
{
    internal sealed class WebSitesInfoMapping : EntityTypeConfiguration<WebSiteStatus>
    {
    public static readonly WebSitesInfoMapping Instance = new WebSitesInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
    private WebSitesInfoMapping()
        {

            ToTable("GET_SITES_STATUS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(WebSiteStatus.Fields.Name)
                .IsUnicode();
                

            Property(t => t.Attempt)
                .HasColumnName(WebSiteStatus.Fields.Attempt);

            Property(t => t.CheckDate)
                .HasColumnName(WebSiteStatus.Fields.CheckDate);

            Property(t => t.CheckStatus)
                .HasColumnName(WebSiteStatus.Fields.CheckStatus);

            Property(t => t.Message)
                .HasColumnName(WebSiteStatus.Fields.Message);

            Property(t => t.SitePath)
                .HasColumnName(WebSiteStatus.Fields.SitePath);

            Property(t => t.DeleteDate)
            .HasColumnName(WebSiteStatus.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(WebSiteStatus.Fields.ChangeDate);

            Property(t => t.CreateDate)
            .HasColumnName(WebSiteStatus.Fields.CreateDate);

            Property(t => t.LogTypeInfoId)
         .HasColumnName(WebSiteStatus.Fields.LogTypeInfoId);

         
            //Relationships
        }
    }
    
}
