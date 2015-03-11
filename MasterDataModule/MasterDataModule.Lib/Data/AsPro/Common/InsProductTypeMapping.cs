using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PRODUCT_TYPE to entity <see cref="InsProductType"/>
    /// </summary>
    internal sealed class InsProductTypeMapping: EntityTypeConfiguration<InsProductType>
    {
        
        public static readonly InsProductTypeMapping Instance = new InsProductTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsProductTypeMapping" /> class.
        /// </summary>
        private InsProductTypeMapping()
        {

            ToTable("INS_PRODUCT_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsProductType.Fields.Id)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(InsProductType.Fields.Name)
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(InsProductType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsProductType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsProductType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsProductType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsProductType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsProductType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsProductType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsProductType.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
