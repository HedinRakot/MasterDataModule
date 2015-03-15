using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_ORG_ASSOCIATION_TYPE to entity <see cref="EmpOrgAssociationType"/>
    /// </summary>
    internal sealed class EmpOrgAssociationTypeMapping: EntityTypeConfiguration<EmpOrgAssociationType>
    {
        
        public static readonly EmpOrgAssociationTypeMapping Instance = new EmpOrgAssociationTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpOrgAssociationTypeMapping" /> class.
        /// </summary>
        private EmpOrgAssociationTypeMapping()
        {

            ToTable("EMP_ORG_ASSOCIATION_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(EmpOrgAssociationType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.Description)
                .HasColumnName(EmpOrgAssociationType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(EmpOrgAssociationType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpOrgAssociationType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpOrgAssociationType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpOrgAssociationType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpOrgAssociationType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpOrgAssociationType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpOrgAssociationType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpOrgAssociationType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(EmpOrgAssociationType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(EmpOrgAssociationType.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(EmpOrgAssociationType.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
