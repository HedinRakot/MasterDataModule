

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed class SysColumnMapping : EntityTypeConfiguration<SysColumn>
    {
        public static readonly SysColumnMapping Instance = new SysColumnMapping();
        /// <summary>
        /// Instance constructor
        /// </summary>
        private SysColumnMapping()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            this.Property(t => t.SysTableId);

            this.Property(t => t.Description)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);//TODO Ask Vasily

            this.Property(t => t.ReadOnly);

            this.Property(t => t.CreateDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("SYS_COLUMNS", "dbo");
            this.Property(t => t.Id).HasColumnName(SysColumn.Fields.Id);
            this.Property(t => t.Name).HasColumnName(SysColumn.Fields.Name);
            this.Property(t => t.SysTableId).HasColumnName(SysColumn.Fields.SysTableId);
            this.Property(t => t.Description).HasColumnName(SysColumn.Fields.Description);
            this.Property(t => t.ReadOnly).HasColumnName(SysColumn.Fields.ReadOnly);

            this.Property(t => t.CreateDate).HasColumnName(SysColumn.Fields.CreateDate);
            this.Property(t => t.DeleteDate).HasColumnName(SysColumn.Fields.DeleteDate);
        }
    }
}
