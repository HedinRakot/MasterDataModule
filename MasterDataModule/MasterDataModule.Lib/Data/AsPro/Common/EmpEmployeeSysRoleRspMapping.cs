using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_EMPLOYEE_SYS_ROLE_RSP to entity <see cref="EmpEmployeeSysRoleRsp"/>
    /// </summary>
    internal sealed class EmpEmployeeSysRoleRspMapping: EntityTypeConfiguration<EmpEmployeeSysRoleRsp>
    {
        
        public static readonly EmpEmployeeSysRoleRspMapping Instance = new EmpEmployeeSysRoleRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpEmployeeSysRoleRspMapping" /> class.
        /// </summary>
        private EmpEmployeeSysRoleRspMapping()
        {

            ToTable("EMP_EMPLOYEE_SYS_ROLE_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.EmpEmployeeId)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.EmpEmployeeId)
                .IsRequired();

            Property(t => t.SysRoleId)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.SysRoleId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(EmpEmployeeSysRoleRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
