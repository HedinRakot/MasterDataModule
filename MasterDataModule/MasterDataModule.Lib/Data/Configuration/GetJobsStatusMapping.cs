using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.GET_JOBS_STATUS to entity <see cref="GetJobsStatus"/>
    /// </summary>
    internal sealed class GetJobsStatusMapping: EntityTypeConfiguration<GetJobsStatus>
    {
        
        public static readonly GetJobsStatusMapping Instance = new GetJobsStatusMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetJobsStatusMapping" /> class.
        /// </summary>
        private GetJobsStatusMapping()
        {

            ToTable("GET_JOBS_STATUS", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(GetJobsStatus.Fields.Id)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(GetJobsStatus.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(GetJobsStatus.Fields.CheckDate);

            Property(t => t.LastRunTime)
                .HasColumnName(GetJobsStatus.Fields.LastRunTime);

            Property(t => t.Name)
                .HasColumnName(GetJobsStatus.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.JobName)
                .HasColumnName(GetJobsStatus.Fields.JobName)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(GetJobsStatus.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(GetJobsStatus.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(GetJobsStatus.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(GetJobsStatus.Fields.LogTypeInfoId);


            //Relationships
        }
    }
}
