

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed class RoleMapping : EntityTypeConfiguration<Role>
    {
        public static readonly RoleMapping Instance = new RoleMapping();
        /// <summary>
        /// Instance constructor
        /// </summary>
        private RoleMapping()
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
            
            this.Property(t => t.CreateDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MASTER_DATA_ROLE", "dbo");
            this.Property(t => t.Id).HasColumnName(Role.Fields.Id);
            this.Property(t => t.Name).HasColumnName(Role.Fields.Name);

            this.Property(t => t.CreateDate).HasColumnName(Role.Fields.CreateDate);
            this.Property(t => t.ChangeDate).HasColumnName(Role.Fields.ChangeDate);
            this.Property(t => t.OwnerOrgId).HasColumnName(Role.Fields.OwnerOrgId);
            this.Property(t => t.VisibilityOrgId).HasColumnName(Role.Fields.VisibilityOrgId);
            this.Property(t => t.CreateEmployeeId).HasColumnName(Role.Fields.CreateEmployeeId);
            this.Property(t => t.ChangeEmployeeId).HasColumnName(Role.Fields.ChangeEmployeeId);
            this.Property(t => t.FromDate).HasColumnName(Role.Fields.FromDate);
            this.Property(t => t.ToDate).HasColumnName(Role.Fields.ToDate);
            this.Property(t => t.DeleteDate).HasColumnName(Role.Fields.DeleteDate);
        }
    }
}
