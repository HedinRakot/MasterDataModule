

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed class SysTableMapping : EntityTypeConfiguration<SysTable>
    {
        public static readonly SysTableMapping Instance = new SysTableMapping();
        /// <summary>
        /// Instance constructor
        /// </summary>
        private SysTableMapping()
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

            this.Property(t => t.Description)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(256);//TODO Ask Vasily

            this.Property(t => t.EditMode);
            
            this.Property(t => t.CreateDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("SYS_TABLES", "dbo");
            this.Property(t => t.Id).HasColumnName(SysTable.Fields.Id);
            this.Property(t => t.Name).HasColumnName(SysTable.Fields.Name);
            this.Property(t => t.Description).HasColumnName(SysTable.Fields.Description);
            this.Property(t => t.EditMode).HasColumnName(SysTable.Fields.EditMode);

            this.Property(t => t.CreateDate).HasColumnName(SysTable.Fields.CreateDate);
            this.Property(t => t.DeleteDate).HasColumnName(SysTable.Fields.DeleteDate);
        }
    }
}
