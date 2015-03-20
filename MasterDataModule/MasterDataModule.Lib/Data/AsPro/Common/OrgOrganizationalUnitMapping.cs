using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_ORGANIZATIONAL_UNIT to entity <see cref="OrgOrganizationalUnit"/>
    /// </summary>
    internal sealed class OrgOrganizationalUnitMapping: EntityTypeConfiguration<OrgOrganizationalUnit>
    {
        
        public static readonly OrgOrganizationalUnitMapping Instance = new OrgOrganizationalUnitMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgOrganizationalUnitMapping" /> class.
        /// </summary>
        private OrgOrganizationalUnitMapping()
        {

            ToTable("ORG_ORGANIZATIONAL_UNIT", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.OrgNumber)
                .HasColumnName(OrgOrganizationalUnit.Fields.OrgNumber)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(OrgOrganizationalUnit.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Abbr)
                .HasColumnName(OrgOrganizationalUnit.Fields.Abbr)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.LocationAbbr)
                .HasColumnName(OrgOrganizationalUnit.Fields.LocationAbbr)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.SysLocationId)
                .HasColumnName(OrgOrganizationalUnit.Fields.SysLocationId);

            Property(t => t.OrgTypeId)
                .HasColumnName(OrgOrganizationalUnit.Fields.OrgTypeId)
                .IsRequired();

            Property(t => t.EmailFrom)
                .HasColumnName(OrgOrganizationalUnit.Fields.EmailFrom)
                .HasMaxLength(100);

            Property(t => t.EmailTo)
                .HasColumnName(OrgOrganizationalUnit.Fields.EmailTo)
                .HasMaxLength(512);

            Property(t => t.IsEgdokPrintAlways)
                .HasColumnName(OrgOrganizationalUnit.Fields.IsEgdokPrintAlways)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(OrgOrganizationalUnit.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgOrganizationalUnit.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgOrganizationalUnit.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgOrganizationalUnit.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgOrganizationalUnit.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgOrganizationalUnit.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgOrganizationalUnit.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgOrganizationalUnit.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(OrgOrganizationalUnit.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrgOrganizationalUnit.Fields.ToDate)
                .IsRequired();

            Property(t => t.OrgAccountingAreaId)
                .HasColumnName(OrgOrganizationalUnit.Fields.OrgAccountingAreaId);

            Property(t => t.Id)
                .HasColumnName(OrgOrganizationalUnit.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
