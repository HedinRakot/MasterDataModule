using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.GET_WIN_SERVICES_STATUS to entity <see cref="GetWinServicesStatus"/>
    /// </summary>
    internal sealed class GetWinServicesStatusMapping: EntityTypeConfiguration<GetWinServicesStatus>
    {
        
        public static readonly GetWinServicesStatusMapping Instance = new GetWinServicesStatusMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetWinServicesStatusMapping" /> class.
        /// </summary>
        private GetWinServicesStatusMapping()
        {

            ToTable("GET_WIN_SERVICES_STATUS", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(GetWinServicesStatus.Fields.Id)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(GetWinServicesStatus.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(GetWinServicesStatus.Fields.CheckDate);

            Property(t => t.Message)
                .HasColumnName(GetWinServicesStatus.Fields.Message)
                .IsUnicode();

            Property(t => t.Attempt)
                .HasColumnName(GetWinServicesStatus.Fields.Attempt);

            Property(t => t.Name)
                .HasColumnName(GetWinServicesStatus.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.MachineName)
                .HasColumnName(GetWinServicesStatus.Fields.MachineName)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(GetWinServicesStatus.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(GetWinServicesStatus.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(GetWinServicesStatus.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(GetWinServicesStatus.Fields.LogTypeInfoId);


            //Relationships
        }
    }
}
