using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_PERMISSION to entity <see cref="Permission"/>
    /// </summary>
    internal sealed class PermissionMapping: EntityTypeConfiguration<Permission>
    {
        
        public static readonly PermissionMapping Instance = new PermissionMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="PermissionMapping" /> class.
        /// </summary>
        private PermissionMapping()
        {

            ToTable("MASTER_DATA_PERMISSION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(Permission.Fields.Id)
                .IsRequired();

            Property(t => t.SystemName)
                .HasColumnName(Permission.Fields.SystemName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            Property(t => t.Name)
                .HasColumnName(Permission.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            Property(t => t.CreateDate)
                .HasColumnName(Permission.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(Permission.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(Permission.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(Permission.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(Permission.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(Permission.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(Permission.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(Permission.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(Permission.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(Permission.Fields.ToDate)
                .IsRequired();

            Property(t => t.RoleId)
                .HasColumnName(Permission.Fields.RoleId);


            //Relationships
        }
    }
}
