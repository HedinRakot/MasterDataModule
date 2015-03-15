using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_TAX_CODE to entity <see cref="InsTaxCode"/>
    /// </summary>
    internal sealed class InsTaxCodeMapping: EntityTypeConfiguration<InsTaxCode>
    {
        
        public static readonly InsTaxCodeMapping Instance = new InsTaxCodeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsTaxCodeMapping" /> class.
        /// </summary>
        private InsTaxCodeMapping()
        {

            ToTable("INS_TAX_CODE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.TaxCode)
                .HasColumnName(InsTaxCode.Fields.TaxCode)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.CreateDate)
                .HasColumnName(InsTaxCode.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsTaxCode.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsTaxCode.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsTaxCode.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsTaxCode.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsTaxCode.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsTaxCode.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsTaxCode.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsTaxCode.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsTaxCode.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsTaxCode.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
