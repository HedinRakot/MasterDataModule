using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_SEVERITY_TYPE to entity <see cref="InsSeverityType"/>
    /// </summary>
    internal sealed class InsSeverityTypeMapping: EntityTypeConfiguration<InsSeverityType>
    {
        
        public static readonly InsSeverityTypeMapping Instance = new InsSeverityTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsSeverityTypeMapping" /> class.
        /// </summary>
        private InsSeverityTypeMapping()
        {

            ToTable("INS_SEVERITY_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(InsSeverityType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(InsSeverityType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(InsSeverityType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsSeverityType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsSeverityType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsSeverityType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsSeverityType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsSeverityType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsSeverityType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsSeverityType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.SpSeverity)
                .HasColumnName(InsSeverityType.Fields.SpSeverity)
                .HasMaxLength(4);

            Property(t => t.SpTestMarkPreset)
                .HasColumnName(InsSeverityType.Fields.SpTestMarkPreset);

            Property(t => t.Id)
                .HasColumnName(InsSeverityType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsSeverityType.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsSeverityType.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
