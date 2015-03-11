using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_COST_CENTER to entity <see cref="OrgCostCenter"/>
    /// </summary>
    internal sealed class OrgCostCenterMapping: EntityTypeConfiguration<OrgCostCenter>
    {
        
        public static readonly OrgCostCenterMapping Instance = new OrgCostCenterMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgCostCenterMapping" /> class.
        /// </summary>
        private OrgCostCenterMapping()
        {

            ToTable("ORG_COST_CENTER", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(OrgCostCenter.Fields.Id)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(OrgCostCenter.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(OrgCostCenter.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(OrgCostCenter.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgCostCenter.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgCostCenter.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgCostCenter.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgCostCenter.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgCostCenter.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgCostCenter.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgCostCenter.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
