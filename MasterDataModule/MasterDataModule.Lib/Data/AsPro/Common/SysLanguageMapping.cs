using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_LANGUAGE to entity <see cref="SysLanguage"/>
    /// </summary>
    internal sealed class SysLanguageMapping: EntityTypeConfiguration<SysLanguage>
    {
        
        public static readonly SysLanguageMapping Instance = new SysLanguageMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysLanguageMapping" /> class.
        /// </summary>
        private SysLanguageMapping()
        {

            ToTable("SYS_LANGUAGE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.SapId)
                .HasColumnName(SysLanguage.Fields.SapId)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            Property(t => t.SapIdIso)
                .HasColumnName(SysLanguage.Fields.SapIdIso)
                .HasMaxLength(10);

            Property(t => t.ResourceFileName)
                .HasColumnName(SysLanguage.Fields.ResourceFileName)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.IsAvailable)
                .HasColumnName(SysLanguage.Fields.IsAvailable)
                .IsRequired();

            Property(t => t.Description)
                .HasColumnName(SysLanguage.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(SysLanguage.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(SysLanguage.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(SysLanguage.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(SysLanguage.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(SysLanguage.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(SysLanguage.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(SysLanguage.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(SysLanguage.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(SysLanguage.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
