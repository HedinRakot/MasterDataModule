using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_ACCOUNTING_AREA to entity <see cref="OrgAccountingArea"/>
    /// </summary>
    internal sealed class OrgAccountingAreaMapping: EntityTypeConfiguration<OrgAccountingArea>
    {
        
        public static readonly OrgAccountingAreaMapping Instance = new OrgAccountingAreaMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgAccountingAreaMapping" /> class.
        /// </summary>
        private OrgAccountingAreaMapping()
        {

            ToTable("ORG_ACCOUNTING_AREA", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.AccountingArea)
                .HasColumnName(OrgAccountingArea.Fields.AccountingArea)
                .IsRequired()
                .HasMaxLength(4)
                .IsFixedLength();

            Property(t => t.MaxOrderSum)
                .HasColumnName(OrgAccountingArea.Fields.MaxOrderSum)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(OrgAccountingArea.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgAccountingArea.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgAccountingArea.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgAccountingArea.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgAccountingArea.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgAccountingArea.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgAccountingArea.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgAccountingArea.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrgAccountingArea.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrgAccountingArea.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrgAccountingArea.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
