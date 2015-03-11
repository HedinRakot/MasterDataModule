using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.KSS_EXPENSE_GROUND to entity <see cref="KssExpenseGround"/>
    /// </summary>
    internal sealed class KssExpenseGroundMapping: EntityTypeConfiguration<KssExpenseGround>
    {
        
        public static readonly KssExpenseGroundMapping Instance = new KssExpenseGroundMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="KssExpenseGroundMapping" /> class.
        /// </summary>
        private KssExpenseGroundMapping()
        {

            ToTable("KSS_EXPENSE_GROUND", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(KssExpenseGround.Fields.Id)
                .IsRequired();

            Property(t => t.Description)
                .HasColumnName(KssExpenseGround.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Account)
                .HasColumnName(KssExpenseGround.Fields.Account)
                .HasMaxLength(10);

            Property(t => t.InsVatTypeId)
                .HasColumnName(KssExpenseGround.Fields.InsVatTypeId);

            Property(t => t.MaxAmount)
                .HasColumnName(KssExpenseGround.Fields.MaxAmount);

            Property(t => t.Payer)
                .HasColumnName(KssExpenseGround.Fields.Payer)
                .IsUnicode()
                .HasMaxLength(100);

            Property(t => t.CreateDate)
                .HasColumnName(KssExpenseGround.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(KssExpenseGround.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(KssExpenseGround.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(KssExpenseGround.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(KssExpenseGround.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(KssExpenseGround.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(KssExpenseGround.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(KssExpenseGround.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(KssExpenseGround.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(KssExpenseGround.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
