using System.Data.Entity.ModelConfiguration;
using MasterDataModule.Contracts.Entities.Monitor;

namespace MasterDataModule.Lib.Data
{
    internal sealed class ApplicationLogToShowMapping : EntityTypeConfiguration<ApplicationLogToShow>
    {
    public static readonly ApplicationLogToShowMapping Instance = new ApplicationLogToShowMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
    private ApplicationLogToShowMapping()
        {

            ToTable("GET_APPLICATION_LOGS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            
            Property(t => t.LogLevel)
                .HasColumnName(ApplicationLogToShow.Fields.LogLevel);

            Property(t => t.MessageDate)
                .HasColumnName(ApplicationLogToShow.Fields.MessageDate);
                
            Property(t => t.Message)
                .HasColumnName(ApplicationLogToShow.Fields.Message).IsUnicode(); 

            Property(t => t.FileName)
                .HasColumnName(ApplicationLogToShow.Fields.FileName);

            Property(t => t.DeleteDate)
            .HasColumnName(ApplicationLogToShow.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(ApplicationLogToShow.Fields.ChangeDate);

            Property(t => t.CreateDate)
            .HasColumnName(ApplicationLogToShow.Fields.CreateDate);

            Property(t => t.LogTypeInfoId)
           .HasColumnName(ApplicationLogToShow.Fields.LogTypeInfoId);

         
            //Relationships
        }
    }
    
}
