using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_ROLE to entity <see cref="SysRole"/>
    /// </summary>
    internal sealed class SysRoleMapping: EntityTypeConfiguration<SysRole>
    {
        
        public static readonly SysRoleMapping Instance = new SysRoleMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysRoleMapping" /> class.
        /// </summary>
        private SysRoleMapping()
        {

            ToTable("SYS_ROLE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.RoleNumber)
                .HasColumnName(SysRole.Fields.RoleNumber);

            Property(t => t.Name)
                .HasColumnName(SysRole.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(SysRole.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(SysRole.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(SysRole.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(SysRole.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(SysRole.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(SysRole.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(SysRole.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(SysRole.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(SysRole.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(SysRole.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(SysRole.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(SysRole.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
