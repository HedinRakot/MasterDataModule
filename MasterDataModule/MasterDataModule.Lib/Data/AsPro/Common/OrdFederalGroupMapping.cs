using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_FEDERAL_GROUP to entity <see cref="OrdFederalGroup"/>
    /// </summary>
    internal sealed class OrdFederalGroupMapping: EntityTypeConfiguration<OrdFederalGroup>
    {
        
        public static readonly OrdFederalGroupMapping Instance = new OrdFederalGroupMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdFederalGroupMapping" /> class.
        /// </summary>
        private OrdFederalGroupMapping()
        {

            ToTable("ORD_FEDERAL_GROUP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(OrdFederalGroup.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(OrdFederalGroup.Fields.Description)
                .IsUnicode()
                .HasMaxLength(200);

            Property(t => t.CreateDate)
                .HasColumnName(OrdFederalGroup.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdFederalGroup.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdFederalGroup.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdFederalGroup.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdFederalGroup.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdFederalGroup.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdFederalGroup.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdFederalGroup.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdFederalGroup.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrdFederalGroup.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdFederalGroup.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
