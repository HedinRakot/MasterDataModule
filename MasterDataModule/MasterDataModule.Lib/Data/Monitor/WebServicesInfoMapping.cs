using System.Data.Entity.ModelConfiguration;
using MasterDataModule.Contracts.Entities.Monitor;

namespace MasterDataModule.Lib.Data
{
    internal sealed class WebServicesInfoMapping : EntityTypeConfiguration<WcfServiceStatus>
    {
    public static readonly WebServicesInfoMapping Instance = new WebServicesInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
    private WebServicesInfoMapping()
        {

            ToTable("GET_WCF_SERVICES_STATUS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(WcfServiceStatus.Fields.Name)
                .IsUnicode();
                

            Property(t => t.Attempt)
                .HasColumnName(WcfServiceStatus.Fields.Attempt);

            Property(t => t.CheckDate)
                .HasColumnName(WcfServiceStatus.Fields.CheckDate);

            Property(t => t.CheckStatus)
                .HasColumnName(WcfServiceStatus.Fields.CheckStatus);

            Property(t => t.Message)
                .HasColumnName(WcfServiceStatus.Fields.Message);

            Property(t => t.WsdlPath)
                .HasColumnName(WcfServiceStatus.Fields.WsdlPath);

            Property(t => t.DeleteDate)
            .HasColumnName(WcfServiceStatus.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(WcfServiceStatus.Fields.ChangeDate);

            Property(t => t.CreateDate)
            .HasColumnName(WcfServiceStatus.Fields.CreateDate);

         
            //Relationships
        }
    }
    
}
