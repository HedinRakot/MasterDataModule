using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PRODUCT_CLASS_GROUP to entity <see cref="InsProductClassGroup"/>
    /// </summary>
    internal sealed class InsProductClassGroupMapping: EntityTypeConfiguration<InsProductClassGroup>
    {
        
        public static readonly InsProductClassGroupMapping Instance = new InsProductClassGroupMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsProductClassGroupMapping" /> class.
        /// </summary>
        private InsProductClassGroupMapping()
        {

            ToTable("INS_PRODUCT_CLASS_GROUP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsProductClassGroup.Fields.Description)
                .IsUnicode()
                .HasMaxLength(500);

            Property(t => t.SapId)
                .HasColumnName(InsProductClassGroup.Fields.SapId)
                .HasMaxLength(10);

            Property(t => t.CreateDate)
                .HasColumnName(InsProductClassGroup.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsProductClassGroup.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsProductClassGroup.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsProductClassGroup.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsProductClassGroup.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsProductClassGroup.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsProductClassGroup.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsProductClassGroup.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsProductClassGroup.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsProductClassGroup.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsProductClassGroup.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
