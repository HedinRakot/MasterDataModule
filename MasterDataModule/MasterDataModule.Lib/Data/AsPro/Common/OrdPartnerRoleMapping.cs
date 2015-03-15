using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_PARTNER_ROLE to entity <see cref="OrdPartnerRole"/>
    /// </summary>
    internal sealed class OrdPartnerRoleMapping: EntityTypeConfiguration<OrdPartnerRole>
    {
        
        public static readonly OrdPartnerRoleMapping Instance = new OrdPartnerRoleMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdPartnerRoleMapping" /> class.
        /// </summary>
        private OrdPartnerRoleMapping()
        {

            ToTable("ORD_PARTNER_ROLE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.SapQualifier)
                .HasColumnName(OrdPartnerRole.Fields.SapQualifier)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(OrdPartnerRole.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdPartnerRole.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdPartnerRole.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdPartnerRole.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdPartnerRole.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdPartnerRole.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdPartnerRole.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdPartnerRole.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdPartnerRole.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
