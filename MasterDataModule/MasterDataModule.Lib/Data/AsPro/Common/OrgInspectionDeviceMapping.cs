using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_INSPECTION_DEVICE to entity <see cref="OrgInspectionDevice"/>
    /// </summary>
    internal sealed class OrgInspectionDeviceMapping: EntityTypeConfiguration<OrgInspectionDevice>
    {
        
        public static readonly OrgInspectionDeviceMapping Instance = new OrgInspectionDeviceMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgInspectionDeviceMapping" /> class.
        /// </summary>
        private OrgInspectionDeviceMapping()
        {

            ToTable("ORG_INSPECTION_DEVICE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.DebitorCustomerNumber)
                .HasColumnName(OrgInspectionDevice.Fields.DebitorCustomerNumber)
                .HasMaxLength(10);

            Property(t => t.Identification)
                .HasColumnName(OrgInspectionDevice.Fields.Identification)
                .IsRequired()
                .HasMaxLength(15)
                .IsFixedLength();

            Property(t => t.NewIdentification)
                .HasColumnName(OrgInspectionDevice.Fields.NewIdentification)
                .HasMaxLength(15);

            Property(t => t.OldIdentification)
                .HasColumnName(OrgInspectionDevice.Fields.OldIdentification)
                .HasMaxLength(15);

            Property(t => t.Type)
                .HasColumnName(OrgInspectionDevice.Fields.Type)
                .HasMaxLength(1)
                .IsFixedLength();

            Property(t => t.SerialNumber)
                .HasColumnName(OrgInspectionDevice.Fields.SerialNumber)
                .HasMaxLength(50);

            Property(t => t.Name)
                .HasColumnName(OrgInspectionDevice.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasColumnName(OrgInspectionDevice.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.LastInspectionDate)
                .HasColumnName(OrgInspectionDevice.Fields.LastInspectionDate);

            Property(t => t.LastInspectionResult)
                .HasColumnName(OrgInspectionDevice.Fields.LastInspectionResult)
                .IsUnicode()
                .HasMaxLength(20);

            Property(t => t.InspectionDate)
                .HasColumnName(OrgInspectionDevice.Fields.InspectionDate);

            Property(t => t.InspectionInterval)
                .HasColumnName(OrgInspectionDevice.Fields.InspectionInterval);

            Property(t => t.CreateDate)
                .HasColumnName(OrgInspectionDevice.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgInspectionDevice.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgInspectionDevice.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgInspectionDevice.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgInspectionDevice.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgInspectionDevice.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgInspectionDevice.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgInspectionDevice.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrgInspectionDevice.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
