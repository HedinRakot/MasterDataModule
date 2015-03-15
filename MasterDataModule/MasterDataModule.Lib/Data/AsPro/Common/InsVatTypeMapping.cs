using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_VAT_TYPE to entity <see cref="InsVatType"/>
    /// </summary>
    internal sealed class InsVatTypeMapping: EntityTypeConfiguration<InsVatType>
    {
        
        public static readonly InsVatTypeMapping Instance = new InsVatTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsVatTypeMapping" /> class.
        /// </summary>
        private InsVatTypeMapping()
        {

            ToTable("INS_VAT_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsVatType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.TaxCode)
                .HasColumnName(InsVatType.Fields.TaxCode)
                .HasMaxLength(10);

            Property(t => t.Percent)
                .HasColumnName(InsVatType.Fields.Percent);

            Property(t => t.CreateDate)
                .HasColumnName(InsVatType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsVatType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsVatType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsVatType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsVatType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsVatType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsVatType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsVatType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsVatType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
