using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_USER to entity <see cref="User"/>
    /// </summary>
    internal sealed class UserMapping: EntityTypeConfiguration<User>
    {
        
        public static readonly UserMapping Instance = new UserMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="UserMapping" /> class.
        /// </summary>
        private UserMapping()
        {

            ToTable("MASTER_DATA_USER", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(User.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.MasterDataRoleId)
                .HasColumnName(User.Fields.MasterDataRoleId);

            Property(t => t.Login)
                .HasColumnName(User.Fields.Login)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            Property(t => t.Name)
                .HasColumnName(User.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            Property(t => t.Password)
                .HasColumnName(User.Fields.Password)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            Property(t => t.CreateDate)
                .HasColumnName(User.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(User.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(User.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(User.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(User.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(User.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(User.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(User.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(User.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(User.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasOptional(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(t => t.MasterDataRoleId);
        }
    }
}
