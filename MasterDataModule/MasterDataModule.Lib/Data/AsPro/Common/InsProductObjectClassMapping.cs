using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PRODUCT_OBJECT_CLASS to entity <see cref="InsProductObjectClass"/>
    /// </summary>
    internal sealed class InsProductObjectClassMapping: EntityTypeConfiguration<InsProductObjectClass>
    {
        
        public static readonly InsProductObjectClassMapping Instance = new InsProductObjectClassMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsProductObjectClassMapping" /> class.
        /// </summary>
        private InsProductObjectClassMapping()
        {

            ToTable("INS_PRODUCT_OBJECT_CLASS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsProductObjectClass.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.WeightFrom)
                .HasColumnName(InsProductObjectClass.Fields.WeightFrom);

            Property(t => t.WeightTo)
                .HasColumnName(InsProductObjectClass.Fields.WeightTo);

            Property(t => t.CreateDate)
                .HasColumnName(InsProductObjectClass.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsProductObjectClass.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsProductObjectClass.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsProductObjectClass.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsProductObjectClass.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsProductObjectClass.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsProductObjectClass.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsProductObjectClass.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsProductObjectClass.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsProductObjectClass.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsProductObjectClass.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
