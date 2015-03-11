using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_AVAILABLE_INSPECTION_TEXT to entity <see cref="InsAvailableInspectionText"/>
    /// </summary>
    internal sealed class InsAvailableInspectionTextMapping: EntityTypeConfiguration<InsAvailableInspectionText>
    {
        
        public static readonly InsAvailableInspectionTextMapping Instance = new InsAvailableInspectionTextMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsAvailableInspectionTextMapping" /> class.
        /// </summary>
        private InsAvailableInspectionTextMapping()
        {

            ToTable("INS_AVAILABLE_INSPECTION_TEXT", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsAvailableInspectionText.Fields.Id)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsAvailableInspectionText.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsAvailableInspectionText.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsAvailableInspectionText.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsAvailableInspectionText.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsAvailableInspectionText.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsAvailableInspectionText.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsAvailableInspectionText.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsAvailableInspectionText.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
