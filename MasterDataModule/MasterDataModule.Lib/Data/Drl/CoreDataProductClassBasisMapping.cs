using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP to entity <see cref="CoreDataProductClassBasis"/>
    /// </summary>
    internal sealed class CoreDataProductClassBasisMapping: EntityTypeConfiguration<CoreDataProductClassBasis>
    {
        
        public static readonly CoreDataProductClassBasisMapping Instance = new CoreDataProductClassBasisMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="CoreDataProductClassBasisMapping" /> class.
        /// </summary>
        private CoreDataProductClassBasisMapping()
        {

            ToTable("DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(CoreDataProductClassBasis.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.ExamClassId)
                .HasColumnName(CoreDataProductClassBasis.Fields.ExamClassId)
                .IsRequired();

            Property(t => t.CoreDataProductId)
                .HasColumnName(CoreDataProductClassBasis.Fields.CoreDataProductId)
                .IsRequired();

            Property(t => t.LegalBasisId)
                .HasColumnName(CoreDataProductClassBasis.Fields.LegalBasisId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(CoreDataProductClassBasis.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(CoreDataProductClassBasis.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(CoreDataProductClassBasis.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(CoreDataProductClassBasis.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(CoreDataProductClassBasis.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(CoreDataProductClassBasis.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(CoreDataProductClassBasis.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(CoreDataProductClassBasis.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(CoreDataProductClassBasis.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(CoreDataProductClassBasis.Fields.ToDate)
                .IsRequired();

            Property(t => t.SortOrder)
                .HasColumnName(CoreDataProductClassBasis.Fields.SortOrder)
                .IsRequired();


            //Relationships
            HasRequired(c => c.ExamClass)
                .WithMany(e => e.CoreDataProductClassBases)
                .HasForeignKey(t => t.ExamClassId);
            HasRequired(c => c.LegalBasis)
                .WithMany(l => l.CoreDataProductClassBases)
                .HasForeignKey(t => t.LegalBasisId);
            HasRequired(c => c.CoreDataProduct)
                .WithMany(c => c.CoreDataProductClassBases)
                .HasForeignKey(t => t.CoreDataProductId);
        }
    }
}
