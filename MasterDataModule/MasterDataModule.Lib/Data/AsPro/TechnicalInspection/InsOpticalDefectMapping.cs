using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_OPTICAL_DEFECT to entity <see cref="InsOpticalDefect"/>
    /// </summary>
    internal sealed class InsOpticalDefectMapping: EntityTypeConfiguration<InsOpticalDefect>
    {
        
        public static readonly InsOpticalDefectMapping Instance = new InsOpticalDefectMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsOpticalDefectMapping" /> class.
        /// </summary>
        private InsOpticalDefectMapping()
        {

            ToTable("INS_OPTICAL_DEFECT", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(InsOpticalDefect.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(20);

            Property(t => t.Description)
                .HasColumnName(InsOpticalDefect.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.IsCustom)
                .HasColumnName(InsOpticalDefect.Fields.IsCustom)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsOpticalDefect.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsOpticalDefect.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsOpticalDefect.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsOpticalDefect.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsOpticalDefect.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsOpticalDefect.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsOpticalDefect.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsOpticalDefect.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsOpticalDefect.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsOpticalDefect.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsOpticalDefect.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
