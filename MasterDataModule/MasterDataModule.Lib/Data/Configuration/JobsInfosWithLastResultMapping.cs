using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.JOBS_INFOS_WITH_LAST_RESULT to entity <see cref="JobsInfosWithLastResult"/>
    /// </summary>
    internal sealed class JobsInfosWithLastResultMapping: EntityTypeConfiguration<JobsInfosWithLastResult>
    {
        
        public static readonly JobsInfosWithLastResultMapping Instance = new JobsInfosWithLastResultMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="JobsInfosWithLastResultMapping" /> class.
        /// </summary>
        private JobsInfosWithLastResultMapping()
        {

            ToTable("JOBS_INFOS_WITH_LAST_RESULT", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(JobsInfosWithLastResult.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(JobsInfosWithLastResult.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(JobsInfosWithLastResult.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(JobsInfosWithLastResult.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(JobsInfosWithLastResult.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LastResult)
                .HasColumnName(JobsInfosWithLastResult.Fields.LastResult);


            //Relationships
        }
    }
}
