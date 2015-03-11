using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_NEXT_INSPECTION to entity <see cref="InsNextInspection"/>
    /// </summary>
    internal sealed class InsNextInspectionMapping: EntityTypeConfiguration<InsNextInspection>
    {
        
        public static readonly InsNextInspectionMapping Instance = new InsNextInspectionMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsNextInspectionMapping" /> class.
        /// </summary>
        private InsNextInspectionMapping()
        {

            ToTable("INS_NEXT_INSPECTION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsNextInspection.Fields.Id)
                .IsRequired();

            Property(t => t.Description)
                .HasColumnName(InsNextInspection.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(InsNextInspection.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsNextInspection.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsNextInspection.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsNextInspection.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsNextInspection.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsNextInspection.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsNextInspection.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsNextInspection.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
