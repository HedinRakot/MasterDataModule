using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_INFORMATION to entity <see cref="OrgInformation"/>
    /// </summary>
    internal sealed class OrgInformationMapping: EntityTypeConfiguration<OrgInformation>
    {
        
        public static readonly OrgInformationMapping Instance = new OrgInformationMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgInformationMapping" /> class.
        /// </summary>
        private OrgInformationMapping()
        {

            ToTable("ORG_INFORMATION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(OrgInformation.Fields.Id)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(OrgInformation.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Value)
                .HasColumnName(OrgInformation.Fields.Value)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(OrgInformation.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgInformation.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgInformation.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgInformation.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgInformation.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgInformation.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgInformation.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgInformation.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
