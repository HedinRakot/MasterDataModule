using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_ACCOUNT_TYPE to entity <see cref="OrgAccountType"/>
    /// </summary>
    internal sealed class OrgAccountTypeMapping: EntityTypeConfiguration<OrgAccountType>
    {
        
        public static readonly OrgAccountTypeMapping Instance = new OrgAccountTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgAccountTypeMapping" /> class.
        /// </summary>
        private OrgAccountTypeMapping()
        {

            ToTable("ORG_ACCOUNT_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(OrgAccountType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(OrgAccountType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(OrgAccountType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgAccountType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgAccountType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgAccountType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgAccountType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgAccountType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgAccountType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgAccountType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrgAccountType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
