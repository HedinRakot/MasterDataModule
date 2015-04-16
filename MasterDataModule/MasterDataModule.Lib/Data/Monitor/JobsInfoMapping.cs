using System.Data.Entity.ModelConfiguration;
using MasterDataModule.Contracts.Entities.Monitor;

namespace MasterDataModule.Lib.Data
{
    internal sealed class JobsInfoMapping : EntityTypeConfiguration<JobStatus>
    {
    public static readonly JobsInfoMapping Instance = new JobsInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
    private JobsInfoMapping()
        {

            ToTable("GET_JOBS_STATUS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(JobStatus.Fields.Name)
                .IsUnicode();
                

            Property(t => t.LastRunTime)
                .HasColumnName(JobStatus.Fields.LastRunTime);

            Property(t => t.CheckDate)
                .HasColumnName(JobStatus.Fields.CheckDate);

            Property(t => t.CheckStatus)
                .HasColumnName(JobStatus.Fields.CheckStatus);

            Property(t => t.JobName)
                .HasColumnName(JobStatus.Fields.JobName);
                
            Property(t => t.DeleteDate)
            .HasColumnName(JobStatus.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(JobStatus.Fields.ChangeDate);

            Property(t => t.CreateDate)
            .HasColumnName(JobStatus.Fields.CreateDate);

            Property(t => t.LogTypeInfoId)
         .HasColumnName(JobStatus.Fields.LogTypeInfoId);

         
            //Relationships
        }
    }
    
}
