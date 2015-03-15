using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_SUMMARY_FIELD to entity <see cref="InsSummaryField"/>
    /// </summary>
    internal sealed class InsSummaryFieldMapping: EntityTypeConfiguration<InsSummaryField>
    {
        
        public static readonly InsSummaryFieldMapping Instance = new InsSummaryFieldMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsSummaryFieldMapping" /> class.
        /// </summary>
        private InsSummaryFieldMapping()
        {

            ToTable("INS_SUMMARY_FIELD", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsSummaryField.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(InsSummaryField.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsSummaryField.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsSummaryField.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsSummaryField.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsSummaryField.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsSummaryField.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsSummaryField.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsSummaryField.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsSummaryField.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsSummaryField.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsSummaryField.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
