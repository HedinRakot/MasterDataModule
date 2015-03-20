using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_CORE_DATA_PRODUCT to entity <see cref="InsCoreDataProduct"/>
    /// </summary>
    internal sealed class InsCoreDataProductMapping: EntityTypeConfiguration<InsCoreDataProduct>
    {
        
        public static readonly InsCoreDataProductMapping Instance = new InsCoreDataProductMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsCoreDataProductMapping" /> class.
        /// </summary>
        private InsCoreDataProductMapping()
        {

            ToTable("INS_CORE_DATA_PRODUCT", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.ProductNumber)
                .HasColumnName(InsCoreDataProduct.Fields.ProductNumber)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.IsNextInspectionProduct)
                .HasColumnName(InsCoreDataProduct.Fields.IsNextInspectionProduct);

            Property(t => t.IsProvisionCostMayBeCalculated)
                .HasColumnName(InsCoreDataProduct.Fields.IsProvisionCostMayBeCalculated);

            Property(t => t.PriceReportRequired)
                .HasColumnName(InsCoreDataProduct.Fields.PriceReportRequired);

            Property(t => t.InsProductTypeId)
                .HasColumnName(InsCoreDataProduct.Fields.InsProductTypeId)
                .IsRequired();

            Property(t => t.InsProductObjectClassId)
                .HasColumnName(InsCoreDataProduct.Fields.InsProductObjectClassId);

            Property(t => t.InsProductObjectTypeId)
                .HasColumnName(InsCoreDataProduct.Fields.InsProductObjectTypeId);

            Property(t => t.InsProductMaterialGroupId)
                .HasColumnName(InsCoreDataProduct.Fields.InsProductMaterialGroupId);

            Property(t => t.InsProductClassId)
                .HasColumnName(InsCoreDataProduct.Fields.InsProductClassId);

            Property(t => t.InsCoreDataProductGroupId)
                .HasColumnName(InsCoreDataProduct.Fields.InsCoreDataProductGroupId);

            Property(t => t.IsIngener)
                .HasColumnName(InsCoreDataProduct.Fields.IsIngener);

            Property(t => t.IsProductive)
                .HasColumnName(InsCoreDataProduct.Fields.IsProductive)
                .IsRequired();

            Property(t => t.IsKmGeld)
                .HasColumnName(InsCoreDataProduct.Fields.IsKmGeld)
                .IsRequired();

            Property(t => t.IsOtherMaterial)
                .HasColumnName(InsCoreDataProduct.Fields.IsOtherMaterial)
                .IsRequired();

            Property(t => t.IsTrip)
                .HasColumnName(InsCoreDataProduct.Fields.IsTrip)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsCoreDataProduct.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsCoreDataProduct.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsCoreDataProduct.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsCoreDataProduct.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsCoreDataProduct.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsCoreDataProduct.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsCoreDataProduct.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsCoreDataProduct.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(InsCoreDataProduct.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsCoreDataProduct.Fields.ToDate)
                .IsRequired();

            Property(t => t.ReusageType)
                .HasColumnName(InsCoreDataProduct.Fields.ReusageType)
                .IsRequired();

            Property(t => t.InsTaxCodeId)
                .HasColumnName(InsCoreDataProduct.Fields.InsTaxCodeId);

            Property(t => t.OldProductNumber)
                .HasColumnName(InsCoreDataProduct.Fields.OldProductNumber)
                .HasMaxLength(50);

            Property(t => t.Id)
                .HasColumnName(InsCoreDataProduct.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
