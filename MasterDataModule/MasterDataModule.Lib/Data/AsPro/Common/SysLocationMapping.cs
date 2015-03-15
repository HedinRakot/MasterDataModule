using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_LOCATION to entity <see cref="SysLocation"/>
    /// </summary>
    internal sealed class SysLocationMapping: EntityTypeConfiguration<SysLocation>
    {
        
        public static readonly SysLocationMapping Instance = new SysLocationMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysLocationMapping" /> class.
        /// </summary>
        private SysLocationMapping()
        {

            ToTable("SYS_LOCATION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.LocationCode)
                .HasColumnName(SysLocation.Fields.LocationCode)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.LocationName)
                .HasColumnName(SysLocation.Fields.LocationName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);

            Property(t => t.SysCountryId)
                .HasColumnName(SysLocation.Fields.SysCountryId);

            Property(t => t.OrdFederalStateId)
                .HasColumnName(SysLocation.Fields.OrdFederalStateId);

            Property(t => t.CreateDate)
                .HasColumnName(SysLocation.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(SysLocation.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(SysLocation.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(SysLocation.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(SysLocation.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(SysLocation.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(SysLocation.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(SysLocation.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(SysLocation.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(SysLocation.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(SysLocation.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
