using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.GET_WCF_SERVICES_STATUS to entity <see cref="GetWcfServicesStatus"/>
    /// </summary>
    internal sealed class GetWcfServicesStatusMapping: EntityTypeConfiguration<GetWcfServicesStatus>
    {
        
        public static readonly GetWcfServicesStatusMapping Instance = new GetWcfServicesStatusMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetWcfServicesStatusMapping" /> class.
        /// </summary>
        private GetWcfServicesStatusMapping()
        {

            ToTable("GET_WCF_SERVICES_STATUS", "dbo");

            //Properties
            Property(t => t.Id)
                .HasColumnName(GetWcfServicesStatus.Fields.Id)
                .IsRequired();

            Property(t => t.CheckStatus)
                .HasColumnName(GetWcfServicesStatus.Fields.CheckStatus);

            Property(t => t.CheckDate)
                .HasColumnName(GetWcfServicesStatus.Fields.CheckDate);

            Property(t => t.Message)
                .HasColumnName(GetWcfServicesStatus.Fields.Message)
                .IsUnicode();

            Property(t => t.Attempt)
                .HasColumnName(GetWcfServicesStatus.Fields.Attempt);

            Property(t => t.Name)
                .HasColumnName(GetWcfServicesStatus.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.WsdlPath)
                .HasColumnName(GetWcfServicesStatus.Fields.WsdlPath)
                .IsRequired()
                .IsUnicode();

            Property(t => t.DeleteDate)
                .HasColumnName(GetWcfServicesStatus.Fields.DeleteDate);

            Property(t => t.CreateDate)
                .HasColumnName(GetWcfServicesStatus.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(GetWcfServicesStatus.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(GetWcfServicesStatus.Fields.LogTypeInfoId);


            //Relationships
        }
    }
}
