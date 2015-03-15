using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_RELATIONSHIP_TYPE to entity <see cref="OrgRelationshipType"/>
    /// </summary>
    internal sealed class OrgRelationshipTypeMapping: EntityTypeConfiguration<OrgRelationshipType>
    {
        
        public static readonly OrgRelationshipTypeMapping Instance = new OrgRelationshipTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgRelationshipTypeMapping" /> class.
        /// </summary>
        private OrgRelationshipTypeMapping()
        {

            ToTable("ORG_RELATIONSHIP_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(OrgRelationshipType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(OrgRelationshipType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(OrgRelationshipType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgRelationshipType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgRelationshipType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgRelationshipType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgRelationshipType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgRelationshipType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgRelationshipType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgRelationshipType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrgRelationshipType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrgRelationshipType.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrgRelationshipType.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
