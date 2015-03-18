using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_COLUMNS to entity <see cref="SysColumn"/>
    /// </summary>
    internal sealed class SysColumnMapping: EntityTypeConfiguration<SysColumn>
    {
        
        public static readonly SysColumnMapping Instance = new SysColumnMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysColumnMapping" /> class.
        /// </summary>
        private SysColumnMapping()
        {

            ToTable("SYS_COLUMNS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(SysColumn.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.SysTableId)
                .HasColumnName(SysColumn.Fields.SysTableId)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(SysColumn.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            Property(t => t.CreateDate)
                .HasColumnName(SysColumn.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(SysColumn.Fields.DeleteDate);

            Property(t => t.Description)
                .HasColumnName(SysColumn.Fields.Description)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            Property(t => t.ReadOnly)
                .HasColumnName(SysColumn.Fields.ReadOnly)
                .IsRequired();

            Ignore(r => r.ChangeDate);

            //Relationships
            HasRequired(s => s.SysTable)
                .WithMany(s => s.SysColumns)
                .HasForeignKey(t => t.SysTableId);
        }
    }
}
