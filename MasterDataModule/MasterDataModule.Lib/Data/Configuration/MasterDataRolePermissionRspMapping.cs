using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_ROLE_PERMISSION_RSP to entity <see cref="MasterDataRolePermissionRsp"/>
    /// </summary>
    internal sealed class MasterDataRolePermissionRspMapping: EntityTypeConfiguration<MasterDataRolePermissionRsp>
    {
        
        public static readonly MasterDataRolePermissionRspMapping Instance = new MasterDataRolePermissionRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataRolePermissionRspMapping" /> class.
        /// </summary>
        private MasterDataRolePermissionRspMapping()
        {

            ToTable("MASTER_DATA_ROLE_PERMISSION_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.MasterDataRoleId)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.MasterDataRoleId)
                .IsRequired();

            Property(t => t.MasterDataPermissionId)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.MasterDataPermissionId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataRolePermissionRsp.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasRequired(m => m.Permission)
                .WithMany(p => p.MasterDataRolePermissionRsps)
                .HasForeignKey(t => t.MasterDataPermissionId);
            HasRequired(m => m.Role)
                .WithMany(r => r.MasterDataRolePermissionRsps)
                .HasForeignKey(t => t.MasterDataRoleId);
        }
    }
}
