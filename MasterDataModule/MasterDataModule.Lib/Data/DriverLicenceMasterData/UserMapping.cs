

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed class UserMapping : EntityTypeConfiguration<User>
    {
        public static readonly UserMapping Instance = new UserMapping();
        /// <summary>
        /// Instance constructor
        /// </summary>
        private UserMapping()
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

            this.Property(t => t.Login)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            this.Property(t => t.Password)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            this.Property(t => t.RoleId);

            this.Property(t => t.CreateDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MASTER_DATA_USER", "dbo");
            this.Property(t => t.Id).HasColumnName(User.Fields.Id);
            this.Property(t => t.RoleId).HasColumnName(User.Fields.RoleId);
            this.Property(t => t.Login).HasColumnName(User.Fields.Login);
            this.Property(t => t.Name).HasColumnName(User.Fields.Name);
            this.Property(t => t.Password).HasColumnName(User.Fields.Password);

            this.Property(t => t.CreateDate).HasColumnName(User.Fields.CreateDate);
            this.Property(t => t.ChangeDate).HasColumnName(User.Fields.ChangeDate);
            this.Property(t => t.OwnerOrgId).HasColumnName(User.Fields.OwnerOrgId);
            this.Property(t => t.VisibilityOrgId).HasColumnName(User.Fields.VisibilityOrgId);
            this.Property(t => t.CreateEmployeeId).HasColumnName(User.Fields.CreateEmployeeId);
            this.Property(t => t.ChangeEmployeeId).HasColumnName(User.Fields.ChangeEmployeeId);
            this.Property(t => t.FromDate).HasColumnName(User.Fields.FromDate);
            this.Property(t => t.ToDate).HasColumnName(User.Fields.ToDate);
            this.Property(t => t.DeleteDate).HasColumnName(User.Fields.DeleteDate);
        }
    }
}
