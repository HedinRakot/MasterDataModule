using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_CORE_DATA_PRODUCT to entity <see cref="CoreDataProduct"/>
    /// </summary>
    internal sealed class CoreDataProductMapping: EntityTypeConfiguration<CoreDataProduct>
    {
        
        public static readonly CoreDataProductMapping Instance = new CoreDataProductMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="CoreDataProductMapping" /> class.
        /// </summary>
        private CoreDataProductMapping()
        {

            ToTable("DRL_CORE_DATA_PRODUCT", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(CoreDataProduct.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.InsCoreDataProductId)
                .HasColumnName(CoreDataProduct.Fields.InsCoreDataProductId)
                .IsRequired();

            Property(t => t.PointAmount)
                .HasColumnName(CoreDataProduct.Fields.PointAmount)
                .IsRequired();

            Property(t => t.MinAge)
                .HasColumnName(CoreDataProduct.Fields.MinAge)
                .IsRequired();

            Property(t => t.MaxAge)
                .HasColumnName(CoreDataProduct.Fields.MaxAge);

            Property(t => t.ExamType)
                .HasColumnName(CoreDataProduct.Fields.ExamType)
                .IsRequired();

            Property(t => t.PriorTimeInMonths)
                .HasColumnName(CoreDataProduct.Fields.PriorTimeInMonths)
                .IsRequired();

            Property(t => t.ExpirationInMonth)
                .HasColumnName(CoreDataProduct.Fields.ExpirationInMonth)
                .IsRequired();

            Property(t => t.RepeatTimeInDays)
                .HasColumnName(CoreDataProduct.Fields.RepeatTimeInDays)
                .IsRequired();

            Property(t => t.TrainingCertFlag)
                .HasColumnName(CoreDataProduct.Fields.TrainingCertFlag)
                .IsRequired();

            Property(t => t.ResultFlag)
                .HasColumnName(CoreDataProduct.Fields.ResultFlag)
                .IsRequired();

            Property(t => t.MultiplyFlag)
                .HasColumnName(CoreDataProduct.Fields.MultiplyFlag)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(CoreDataProduct.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(CoreDataProduct.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(CoreDataProduct.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(CoreDataProduct.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(CoreDataProduct.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(CoreDataProduct.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(CoreDataProduct.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(CoreDataProduct.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(CoreDataProduct.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(CoreDataProduct.Fields.ToDate)
                .IsRequired();

            Property(t => t.IsMofaPrint)
                .HasColumnName(CoreDataProduct.Fields.IsMofaPrint)
                .IsRequired();

            Property(t => t.IsAdditionalProduct)
                .HasColumnName(CoreDataProduct.Fields.IsAdditionalProduct)
                .IsRequired();

            Property(t => t.IsPrepaymentRequired)
                .HasColumnName(CoreDataProduct.Fields.IsPrepaymentRequired)
                .IsRequired();

            Property(t => t.IsMandatory)
                .HasColumnName(CoreDataProduct.Fields.IsMandatory)
                .IsRequired();

            Property(t => t.FeProductNumber)
                .HasColumnName(CoreDataProduct.Fields.FeProductNumber)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            Property(t => t.RepeatTimeInDaysReduced)
                .HasColumnName(CoreDataProduct.Fields.RepeatTimeInDaysReduced)
                .IsRequired();


            //Relationships
        }
    }
}
