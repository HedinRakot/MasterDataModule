using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PRODUCT_OBJECT_TYPE to entity <see cref="InsProductObjectType"/>
    /// </summary>
    internal sealed class InsProductObjectTypeMapping: EntityTypeConfiguration<InsProductObjectType>
    {
        
        public static readonly InsProductObjectTypeMapping Instance = new InsProductObjectTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsProductObjectTypeMapping" /> class.
        /// </summary>
        private InsProductObjectTypeMapping()
        {

            ToTable("INS_PRODUCT_OBJECT_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsProductObjectType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.SapId)
                .HasColumnName(InsProductObjectType.Fields.SapId)
                .HasMaxLength(10);

            Property(t => t.CreateDate)
                .HasColumnName(InsProductObjectType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsProductObjectType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsProductObjectType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsProductObjectType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsProductObjectType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsProductObjectType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsProductObjectType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsProductObjectType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.IsAuNecessary)
                .HasColumnName(InsProductObjectType.Fields.IsAuNecessary)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(InsProductObjectType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
