using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_UNIT_CODE to entity <see cref="InsUnitCode"/>
    /// </summary>
    internal sealed class InsUnitCodeMapping: EntityTypeConfiguration<InsUnitCode>
    {
        
        public static readonly InsUnitCodeMapping Instance = new InsUnitCodeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsUnitCodeMapping" /> class.
        /// </summary>
        private InsUnitCodeMapping()
        {

            ToTable("INS_UNIT_CODE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.OrgAccountingAreaId)
                .HasColumnName(InsUnitCode.Fields.OrgAccountingAreaId)
                .IsRequired();

            Property(t => t.OrdFederalStateId)
                .HasColumnName(InsUnitCode.Fields.OrdFederalStateId)
                .IsRequired();

            Property(t => t.OrdAreaOfWorkId)
                .HasColumnName(InsUnitCode.Fields.OrdAreaOfWorkId)
                .IsRequired();

            Property(t => t.UnitCode)
                .HasColumnName(InsUnitCode.Fields.UnitCode)
                .IsUnicode()
                .HasMaxLength(8);

            Property(t => t.CreateDate)
                .HasColumnName(InsUnitCode.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsUnitCode.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsUnitCode.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsUnitCode.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsUnitCode.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsUnitCode.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsUnitCode.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsUnitCode.Fields.Source)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(InsUnitCode.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsUnitCode.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(InsUnitCode.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
