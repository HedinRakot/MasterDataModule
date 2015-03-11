using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_AVAILABLE_INSPECTION_STEP to entity <see cref="InsAvailableInspectionStep"/>
    /// </summary>
    internal sealed class InsAvailableInspectionStepMapping: EntityTypeConfiguration<InsAvailableInspectionStep>
    {
        
        public static readonly InsAvailableInspectionStepMapping Instance = new InsAvailableInspectionStepMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsAvailableInspectionStepMapping" /> class.
        /// </summary>
        private InsAvailableInspectionStepMapping()
        {

            ToTable("INS_AVAILABLE_INSPECTION_STEP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsAvailableInspectionStep.Fields.Id)
                .IsRequired();

            Property(t => t.InsInspectionStepId)
                .HasColumnName(InsAvailableInspectionStep.Fields.InsInspectionStepId)
                .IsRequired();

            Property(t => t.IsMandatory)
                .HasColumnName(InsAvailableInspectionStep.Fields.IsMandatory)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsAvailableInspectionStep.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsAvailableInspectionStep.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsAvailableInspectionStep.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsAvailableInspectionStep.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsAvailableInspectionStep.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsAvailableInspectionStep.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsAvailableInspectionStep.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsAvailableInspectionStep.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(InsAvailableInspectionStep.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsAvailableInspectionStep.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
