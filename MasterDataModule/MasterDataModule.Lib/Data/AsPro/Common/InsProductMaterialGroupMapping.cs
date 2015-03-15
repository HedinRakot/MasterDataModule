using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PRODUCT_MATERIAL_GROUP to entity <see cref="InsProductMaterialGroup"/>
    /// </summary>
    internal sealed class InsProductMaterialGroupMapping: EntityTypeConfiguration<InsProductMaterialGroup>
    {
        
        public static readonly InsProductMaterialGroupMapping Instance = new InsProductMaterialGroupMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsProductMaterialGroupMapping" /> class.
        /// </summary>
        private InsProductMaterialGroupMapping()
        {

            ToTable("INS_PRODUCT_MATERIAL_GROUP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsProductMaterialGroup.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.SapId)
                .HasColumnName(InsProductMaterialGroup.Fields.SapId)
                .HasMaxLength(10);

            Property(t => t.CreateDate)
                .HasColumnName(InsProductMaterialGroup.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsProductMaterialGroup.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsProductMaterialGroup.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsProductMaterialGroup.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsProductMaterialGroup.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsProductMaterialGroup.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsProductMaterialGroup.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsProductMaterialGroup.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsProductMaterialGroup.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsProductMaterialGroup.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsProductMaterialGroup.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
