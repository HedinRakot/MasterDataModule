using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_TAX_CLASS to entity <see cref="InsTaxClass"/>
    /// </summary>
    internal sealed class InsTaxClassMapping: EntityTypeConfiguration<InsTaxClass>
    {
        
        public static readonly InsTaxClassMapping Instance = new InsTaxClassMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsTaxClassMapping" /> class.
        /// </summary>
        private InsTaxClassMapping()
        {

            ToTable("INS_TAX_CLASS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.TaxClass)
                .HasColumnName(InsTaxClass.Fields.TaxClass)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.CreateDate)
                .HasColumnName(InsTaxClass.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsTaxClass.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsTaxClass.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsTaxClass.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsTaxClass.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsTaxClass.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsTaxClass.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsTaxClass.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsTaxClass.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsTaxClass.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsTaxClass.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
