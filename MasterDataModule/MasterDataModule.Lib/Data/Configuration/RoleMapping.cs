using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_ROLE to entity <see cref="Role"/>
    /// </summary>
    internal sealed class RoleMapping: EntityTypeConfiguration<Role>
    {
        
        public static readonly RoleMapping Instance = new RoleMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="RoleMapping" /> class.
        /// </summary>
        private RoleMapping()
        {

            ToTable("MASTER_DATA_ROLE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(Role.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(Role.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            Property(t => t.CreateDate)
                .HasColumnName(Role.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(Role.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(Role.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(Role.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(Role.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(Role.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(Role.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(Role.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(Role.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(Role.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
