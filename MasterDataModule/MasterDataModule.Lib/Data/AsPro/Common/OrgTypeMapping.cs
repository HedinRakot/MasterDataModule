using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_TYPE to entity <see cref="OrgType"/>
    /// </summary>
    internal sealed class OrgTypeMapping: EntityTypeConfiguration<OrgType>
    {
        
        public static readonly OrgTypeMapping Instance = new OrgTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgTypeMapping" /> class.
        /// </summary>
        private OrgTypeMapping()
        {

            ToTable("ORG_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(OrgType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(OrgType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(OrgType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrgType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrgType.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrgType.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
