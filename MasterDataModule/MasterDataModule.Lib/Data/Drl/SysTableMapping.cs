using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_TABLES to entity <see cref="SysTable"/>
    /// </summary>
    internal sealed class SysTableMapping: EntityTypeConfiguration<SysTable>
    {
        
        public static readonly SysTableMapping Instance = new SysTableMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysTableMapping" /> class.
        /// </summary>
        private SysTableMapping()
        {

            ToTable("SYS_TABLES", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(SysTable.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(SysTable.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            Property(t => t.CreateDate)
                .HasColumnName(SysTable.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(SysTable.Fields.DeleteDate);

            Property(t => t.Description)
                .HasColumnName(SysTable.Fields.Description)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);

            Property(t => t.EditMode)
                .HasColumnName(SysTable.Fields.EditMode)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(SysTable.Fields.ChangeDate)
                .IsRequired();


            //Relationships
        }
    }
}
