using System.Data.Entity.ModelConfiguration;
using MasterDataModule.Contracts.Entities.Monitor;

namespace MasterDataModule.Lib.Data
{
    internal sealed class WinServicesInfoMapping : EntityTypeConfiguration<WinServiceStatus>
    {
    public static readonly WinServicesInfoMapping Instance = new WinServicesInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
    private WinServicesInfoMapping()
        {

            ToTable("GET_WIN_SERVICES_STATUS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(WinServiceStatus.Fields.Name)
                .IsUnicode();
                

            Property(t => t.Attempt)
                .HasColumnName(WinServiceStatus.Fields.Attempt);

            Property(t => t.CheckDate)
                .HasColumnName(WinServiceStatus.Fields.CheckDate);

            Property(t => t.CheckStatus)
                .HasColumnName(WinServiceStatus.Fields.CheckStatus);

            Property(t => t.Message)
                .HasColumnName(WinServiceStatus.Fields.Message);

            Property(t => t.MachineName)
                .HasColumnName(WinServiceStatus.Fields.MachineName);

            Property(t => t.DeleteDate)
            .HasColumnName(WinServiceStatus.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(WinServiceStatus.Fields.ChangeDate);

            Property(t => t.CreateDate)
            .HasColumnName(WinServiceStatus.Fields.CreateDate);

         
            //Relationships
        }
    }
    
}
