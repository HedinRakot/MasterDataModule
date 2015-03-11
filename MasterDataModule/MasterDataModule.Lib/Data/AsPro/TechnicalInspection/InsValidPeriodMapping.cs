using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_VALID_PERIOD to entity <see cref="InsValidPeriod"/>
    /// </summary>
    internal sealed class InsValidPeriodMapping: EntityTypeConfiguration<InsValidPeriod>
    {
        
        public static readonly InsValidPeriodMapping Instance = new InsValidPeriodMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsValidPeriodMapping" /> class.
        /// </summary>
        private InsValidPeriodMapping()
        {

            ToTable("INS_VALID_PERIOD", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsValidPeriod.Fields.Id)
                .IsRequired();

            Property(t => t.Description)
                .HasColumnName(InsValidPeriod.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.ValidityPeriod)
                .HasColumnName(InsValidPeriod.Fields.ValidityPeriod);

            Property(t => t.IsNextTerminPossible)
                .HasColumnName(InsValidPeriod.Fields.IsNextTerminPossible);

            Property(t => t.CreateDate)
                .HasColumnName(InsValidPeriod.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsValidPeriod.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsValidPeriod.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsValidPeriod.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsValidPeriod.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsValidPeriod.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsValidPeriod.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsValidPeriod.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
