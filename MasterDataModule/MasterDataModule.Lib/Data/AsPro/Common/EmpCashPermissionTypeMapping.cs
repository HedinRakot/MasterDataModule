using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_CASH_PERMISSION_TYPE to entity <see cref="EmpCashPermissionType"/>
    /// </summary>
    internal sealed class EmpCashPermissionTypeMapping: EntityTypeConfiguration<EmpCashPermissionType>
    {
        
        public static readonly EmpCashPermissionTypeMapping Instance = new EmpCashPermissionTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpCashPermissionTypeMapping" /> class.
        /// </summary>
        private EmpCashPermissionTypeMapping()
        {

            ToTable("EMP_CASH_PERMISSION_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(EmpCashPermissionType.Fields.Id)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(EmpCashPermissionType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.Description)
                .HasColumnName(EmpCashPermissionType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(EmpCashPermissionType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpCashPermissionType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpCashPermissionType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpCashPermissionType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpCashPermissionType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpCashPermissionType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpCashPermissionType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpCashPermissionType.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
