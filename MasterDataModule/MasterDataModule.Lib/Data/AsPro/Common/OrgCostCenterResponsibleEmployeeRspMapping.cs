using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP to entity <see cref="OrgCostCenterResponsibleEmployeeRsp"/>
    /// </summary>
    internal sealed class OrgCostCenterResponsibleEmployeeRspMapping: EntityTypeConfiguration<OrgCostCenterResponsibleEmployeeRsp>
    {
        
        public static readonly OrgCostCenterResponsibleEmployeeRspMapping Instance = new OrgCostCenterResponsibleEmployeeRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgCostCenterResponsibleEmployeeRspMapping" /> class.
        /// </summary>
        private OrgCostCenterResponsibleEmployeeRspMapping()
        {

            ToTable("ORG_COST_CENTER_RESPONSIBLE_EMPLOYEE_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.OrgCostCenterId)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.OrgCostCenterId)
                .IsRequired();

            Property(t => t.EmpEmployeeId)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.EmpEmployeeId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.Source)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(OrgCostCenterResponsibleEmployeeRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
