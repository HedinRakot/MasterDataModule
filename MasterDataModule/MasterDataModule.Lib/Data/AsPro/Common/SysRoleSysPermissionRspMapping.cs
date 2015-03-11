using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_ROLE_SYS_PERMISSION_RSP to entity <see cref="SysRoleSysPermissionRsp"/>
    /// </summary>
    internal sealed class SysRoleSysPermissionRspMapping: EntityTypeConfiguration<SysRoleSysPermissionRsp>
    {
        
        public static readonly SysRoleSysPermissionRspMapping Instance = new SysRoleSysPermissionRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysRoleSysPermissionRspMapping" /> class.
        /// </summary>
        private SysRoleSysPermissionRspMapping()
        {

            ToTable("SYS_ROLE_SYS_PERMISSION_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.Id)
                .IsRequired();

            Property(t => t.SysRoleId)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.SysRoleId)
                .IsRequired();

            Property(t => t.SysPermissionId)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.SysPermissionId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(SysRoleSysPermissionRsp.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
