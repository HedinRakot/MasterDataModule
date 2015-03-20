using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_CORE_DATA_PRODUCT_LOCALIZATION to entity <see cref="InsCoreDataProductLocalization"/>
    /// </summary>
    internal sealed class InsCoreDataProductLocalizationMapping: EntityTypeConfiguration<InsCoreDataProductLocalization>
    {
        
        public static readonly InsCoreDataProductLocalizationMapping Instance = new InsCoreDataProductLocalizationMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsCoreDataProductLocalizationMapping" /> class.
        /// </summary>
        private InsCoreDataProductLocalizationMapping()
        {

            ToTable("INS_CORE_DATA_PRODUCT_LOCALIZATION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.InsCoreDataProductId)
                .HasColumnName(InsCoreDataProductLocalization.Fields.InsCoreDataProductId)
                .IsRequired();

            Property(t => t.SysLanguageId)
                .HasColumnName(InsCoreDataProductLocalization.Fields.SysLanguageId)
                .IsRequired();

            Property(t => t.ProductName)
                .HasColumnName(InsCoreDataProductLocalization.Fields.ProductName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.Description)
                .HasColumnName(InsCoreDataProductLocalization.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(InsCoreDataProductLocalization.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsCoreDataProductLocalization.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsCoreDataProductLocalization.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsCoreDataProductLocalization.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsCoreDataProductLocalization.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsCoreDataProductLocalization.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsCoreDataProductLocalization.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsCoreDataProductLocalization.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(InsCoreDataProductLocalization.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsCoreDataProductLocalization.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(InsCoreDataProductLocalization.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
