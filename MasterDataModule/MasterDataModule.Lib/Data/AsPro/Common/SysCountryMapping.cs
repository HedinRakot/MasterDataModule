using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_COUNTRY to entity <see cref="SysCountry"/>
    /// </summary>
    internal sealed class SysCountryMapping: EntityTypeConfiguration<SysCountry>
    {
        
        public static readonly SysCountryMapping Instance = new SysCountryMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysCountryMapping" /> class.
        /// </summary>
        private SysCountryMapping()
        {

            ToTable("SYS_COUNTRY", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(SysCountry.Fields.Id)
                .IsRequired();

            Property(t => t.SapId)
                .HasColumnName(SysCountry.Fields.SapId)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.Name)
                .HasColumnName(SysCountry.Fields.Name)
                .IsUnicode()
                .HasMaxLength(100);

            Property(t => t.IsEu)
                .HasColumnName(SysCountry.Fields.IsEu);

            Property(t => t.CreateDate)
                .HasColumnName(SysCountry.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(SysCountry.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(SysCountry.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(SysCountry.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(SysCountry.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(SysCountry.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(SysCountry.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(SysCountry.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
