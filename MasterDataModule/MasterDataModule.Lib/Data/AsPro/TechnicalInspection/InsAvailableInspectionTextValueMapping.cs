using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_AVAILABLE_INSPECTION_TEXT_VALUE to entity <see cref="InsAvailableInspectionTextValue"/>
    /// </summary>
    internal sealed class InsAvailableInspectionTextValueMapping: EntityTypeConfiguration<InsAvailableInspectionTextValue>
    {
        
        public static readonly InsAvailableInspectionTextValueMapping Instance = new InsAvailableInspectionTextValueMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsAvailableInspectionTextValueMapping" /> class.
        /// </summary>
        private InsAvailableInspectionTextValueMapping()
        {

            ToTable("INS_AVAILABLE_INSPECTION_TEXT_VALUE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.InsAvailableInspectionTextId)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.InsAvailableInspectionTextId)
                .IsRequired();

            Property(t => t.SysLanguageId)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.SysLanguageId)
                .IsRequired();

            Property(t => t.Text)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.Text)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(512);

            Property(t => t.CreateDate)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(InsAvailableInspectionTextValue.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
