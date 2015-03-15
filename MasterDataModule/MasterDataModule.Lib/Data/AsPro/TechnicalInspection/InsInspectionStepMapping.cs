using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_INSPECTION_STEP to entity <see cref="InsInspectionStep"/>
    /// </summary>
    internal sealed class InsInspectionStepMapping: EntityTypeConfiguration<InsInspectionStep>
    {
        
        public static readonly InsInspectionStepMapping Instance = new InsInspectionStepMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsInspectionStepMapping" /> class.
        /// </summary>
        private InsInspectionStepMapping()
        {

            ToTable("INS_INSPECTION_STEP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsInspectionStep.Fields.Description)
                .IsUnicode()
                .HasMaxLength(150);

            Property(t => t.CreateDate)
                .HasColumnName(InsInspectionStep.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsInspectionStep.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsInspectionStep.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsInspectionStep.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsInspectionStep.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsInspectionStep.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsInspectionStep.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsInspectionStep.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsInspectionStep.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsInspectionStep.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsInspectionStep.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
