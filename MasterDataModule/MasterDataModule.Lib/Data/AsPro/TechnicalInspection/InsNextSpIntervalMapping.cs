using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_NEXT_SP_INTERVAL to entity <see cref="InsNextSpInterval"/>
    /// </summary>
    internal sealed class InsNextSpIntervalMapping: EntityTypeConfiguration<InsNextSpInterval>
    {
        
        public static readonly InsNextSpIntervalMapping Instance = new InsNextSpIntervalMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsNextSpIntervalMapping" /> class.
        /// </summary>
        private InsNextSpIntervalMapping()
        {

            ToTable("INS_NEXT_SP_INTERVAL", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsNextSpInterval.Fields.Id)
                .IsRequired();

            Property(t => t.InsProductObjectTypeId)
                .HasColumnName(InsNextSpInterval.Fields.InsProductObjectTypeId)
                .IsRequired();

            Property(t => t.InsProductObjectClassId)
                .HasColumnName(InsNextSpInterval.Fields.InsProductObjectClassId)
                .IsRequired();

            Property(t => t.AgeMonthFrom)
                .HasColumnName(InsNextSpInterval.Fields.AgeMonthFrom)
                .IsRequired();

            Property(t => t.AgeMonthTo)
                .HasColumnName(InsNextSpInterval.Fields.AgeMonthTo);

            Property(t => t.SpInterval)
                .HasColumnName(InsNextSpInterval.Fields.SpInterval)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsNextSpInterval.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsNextSpInterval.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsNextSpInterval.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsNextSpInterval.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsNextSpInterval.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsNextSpInterval.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsNextSpInterval.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsNextSpInterval.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
