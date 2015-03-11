using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_EMPLOYEE_ORG_COST_CENTER_RSP to entity <see cref="EmpEmployeeOrgCostCenterRsp"/>
    /// </summary>
    internal sealed class EmpEmployeeOrgCostCenterRspMapping: EntityTypeConfiguration<EmpEmployeeOrgCostCenterRsp>
    {
        
        public static readonly EmpEmployeeOrgCostCenterRspMapping Instance = new EmpEmployeeOrgCostCenterRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpEmployeeOrgCostCenterRspMapping" /> class.
        /// </summary>
        private EmpEmployeeOrgCostCenterRspMapping()
        {

            ToTable("EMP_EMPLOYEE_ORG_COST_CENTER_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.Id)
                .IsRequired();

            Property(t => t.EmpEmployeeId)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.EmpEmployeeId)
                .IsRequired();

            Property(t => t.OrgCostCenterId)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.OrgCostCenterId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.Source)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(EmpEmployeeOrgCostCenterRsp.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
