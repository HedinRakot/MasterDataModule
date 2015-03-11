using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PRODUCT_COMBINATION_TYPE to entity <see cref="InsProductCombinationType"/>
    /// </summary>
    internal sealed class InsProductCombinationTypeMapping: EntityTypeConfiguration<InsProductCombinationType>
    {
        
        public static readonly InsProductCombinationTypeMapping Instance = new InsProductCombinationTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsProductCombinationTypeMapping" /> class.
        /// </summary>
        private InsProductCombinationTypeMapping()
        {

            ToTable("INS_PRODUCT_COMBINATION_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsProductCombinationType.Fields.Id)
                .IsRequired();

            Property(t => t.Description)
                .HasColumnName(InsProductCombinationType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(InsProductCombinationType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsProductCombinationType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsProductCombinationType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsProductCombinationType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsProductCombinationType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsProductCombinationType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsProductCombinationType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsProductCombinationType.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
