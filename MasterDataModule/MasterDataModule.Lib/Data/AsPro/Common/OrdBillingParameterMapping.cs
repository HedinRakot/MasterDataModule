using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_BILLING_PARAMETER to entity <see cref="OrdBillingParameter"/>
    /// </summary>
    internal sealed class OrdBillingParameterMapping: EntityTypeConfiguration<OrdBillingParameter>
    {
        
        public static readonly OrdBillingParameterMapping Instance = new OrdBillingParameterMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdBillingParameterMapping" /> class.
        /// </summary>
        private OrdBillingParameterMapping()
        {

            ToTable("ORD_BILLING_PARAMETER", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.SapId)
                .HasColumnName(OrdBillingParameter.Fields.SapId)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Description)
                .HasColumnName(OrdBillingParameter.Fields.Description)
                .IsUnicode()
                .HasMaxLength(100);

            Property(t => t.CreateDate)
                .HasColumnName(OrdBillingParameter.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdBillingParameter.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdBillingParameter.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdBillingParameter.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdBillingParameter.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdBillingParameter.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdBillingParameter.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdBillingParameter.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdBillingParameter.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrdBillingParameter.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdBillingParameter.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
