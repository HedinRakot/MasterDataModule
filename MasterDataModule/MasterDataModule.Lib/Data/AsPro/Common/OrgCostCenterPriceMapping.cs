using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_COST_CENTER_PRICE to entity <see cref="OrgCostCenterPrice"/>
    /// </summary>
    internal sealed class OrgCostCenterPriceMapping: EntityTypeConfiguration<OrgCostCenterPrice>
    {
        
        public static readonly OrgCostCenterPriceMapping Instance = new OrgCostCenterPriceMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgCostCenterPriceMapping" /> class.
        /// </summary>
        private OrgCostCenterPriceMapping()
        {

            ToTable("ORG_COST_CENTER_PRICE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(OrgCostCenterPrice.Fields.Id)
                .IsRequired();

            Property(t => t.InsCoreDataProductId)
                .HasColumnName(OrgCostCenterPrice.Fields.InsCoreDataProductId)
                .IsRequired();

            Property(t => t.SalesOffice)
                .HasColumnName(OrgCostCenterPrice.Fields.SalesOffice)
                .HasMaxLength(10);

            Property(t => t.SalesGroup)
                .HasColumnName(OrgCostCenterPrice.Fields.SalesGroup)
                .HasMaxLength(10);

            Property(t => t.MinPrice)
                .HasColumnName(OrgCostCenterPrice.Fields.MinPrice);

            Property(t => t.MaxPrice)
                .HasColumnName(OrgCostCenterPrice.Fields.MaxPrice);

            Property(t => t.StandartPrice)
                .HasColumnName(OrgCostCenterPrice.Fields.StandartPrice);

            Property(t => t.Quantity)
                .HasColumnName(OrgCostCenterPrice.Fields.Quantity)
                .IsRequired();

            Property(t => t.UnitOfMeasure)
                .HasColumnName(OrgCostCenterPrice.Fields.UnitOfMeasure)
                .HasMaxLength(10);

            Property(t => t.SysCurrencyId)
                .HasColumnName(OrgCostCenterPrice.Fields.SysCurrencyId);

            Property(t => t.ChangeAbilityType)
                .HasColumnName(OrgCostCenterPrice.Fields.ChangeAbilityType);

            Property(t => t.FromDate)
                .HasColumnName(OrgCostCenterPrice.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrgCostCenterPrice.Fields.ToDate)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(OrgCostCenterPrice.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgCostCenterPrice.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgCostCenterPrice.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgCostCenterPrice.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgCostCenterPrice.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgCostCenterPrice.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgCostCenterPrice.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgCostCenterPrice.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.OrgAccountingAreaId)
                .HasColumnName(OrgCostCenterPrice.Fields.OrgAccountingAreaId);


            //Relationships
        }
    }
}
