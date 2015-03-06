

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed class PermissionMapping : EntityTypeConfiguration<Permission>
    {
        public static readonly PermissionMapping Instance = new PermissionMapping();
        /// <summary>
        /// Instance constructor
        /// </summary>
        private PermissionMapping()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            this.Property(t => t.SystemName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            this.Property(t => t.CreateDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MASTER_DATA_PERMISSION", "dbo");
            this.Property(t => t.Id).HasColumnName(Permission.Fields.Id);
            this.Property(t => t.Name).HasColumnName(Permission.Fields.Name);
            this.Property(t => t.SystemName).HasColumnName(Permission.Fields.SystemName);

            this.Property(t => t.CreateDate).HasColumnName(Permission.Fields.CreateDate);
            this.Property(t => t.ChangeDate).HasColumnName(Permission.Fields.ChangeDate);
            this.Property(t => t.OwnerOrgId).HasColumnName(Permission.Fields.OwnerOrgId);
            this.Property(t => t.VisibilityOrgId).HasColumnName(Permission.Fields.VisibilityOrgId);
            this.Property(t => t.CreateEmployeeId).HasColumnName(Permission.Fields.CreateEmployeeId);
            this.Property(t => t.ChangeEmployeeId).HasColumnName(Permission.Fields.ChangeEmployeeId);
            this.Property(t => t.FromDate).HasColumnName(Permission.Fields.FromDate);
            this.Property(t => t.ToDate).HasColumnName(Permission.Fields.ToDate);
            this.Property(t => t.DeleteDate).HasColumnName(Permission.Fields.DeleteDate);
        }
    }
}
