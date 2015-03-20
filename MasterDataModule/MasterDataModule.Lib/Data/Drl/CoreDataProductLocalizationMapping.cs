using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_CORE_DATA_PRODUCT_LOCALIZATION to entity <see cref="CoreDataProductLocalization"/>
    /// </summary>
    internal sealed class CoreDataProductLocalizationMapping: EntityTypeConfiguration<CoreDataProductLocalization>
    {
        
        public static readonly CoreDataProductLocalizationMapping Instance = new CoreDataProductLocalizationMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="CoreDataProductLocalizationMapping" /> class.
        /// </summary>
        private CoreDataProductLocalizationMapping()
        {

            ToTable("DRL_CORE_DATA_PRODUCT_LOCALIZATION", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(CoreDataProductLocalization.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.CoreDataProductId)
                .HasColumnName(CoreDataProductLocalization.Fields.CoreDataProductId)
                .IsRequired();

            Property(t => t.SysLanguageId)
                .HasColumnName(CoreDataProductLocalization.Fields.SysLanguageId)
                .IsRequired();

            Property(t => t.ProductName)
                .HasColumnName(CoreDataProductLocalization.Fields.ProductName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.Description)
                .HasColumnName(CoreDataProductLocalization.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(CoreDataProductLocalization.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(CoreDataProductLocalization.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(CoreDataProductLocalization.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(CoreDataProductLocalization.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(CoreDataProductLocalization.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(CoreDataProductLocalization.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(CoreDataProductLocalization.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(CoreDataProductLocalization.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(CoreDataProductLocalization.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(CoreDataProductLocalization.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasRequired(c => c.CoreDataProduct)
                .WithMany(c => c.CoreDataProductLocalizations)
                .HasForeignKey(t => t.CoreDataProductId);
        }
    }
}
