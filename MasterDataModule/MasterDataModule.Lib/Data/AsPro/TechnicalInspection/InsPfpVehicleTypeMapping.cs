using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PFP_VEHICLE_TYPE to entity <see cref="InsPfpVehicleType"/>
    /// </summary>
    internal sealed class InsPfpVehicleTypeMapping: EntityTypeConfiguration<InsPfpVehicleType>
    {
        
        public static readonly InsPfpVehicleTypeMapping Instance = new InsPfpVehicleTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsPfpVehicleTypeMapping" /> class.
        /// </summary>
        private InsPfpVehicleTypeMapping()
        {

            ToTable("INS_PFP_VEHICLE_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsPfpVehicleType.Fields.Id)
                .IsRequired();

            Property(t => t.Description)
                .HasColumnName(InsPfpVehicleType.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.ImageFileName)
                .HasColumnName(InsPfpVehicleType.Fields.ImageFileName)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.IsPolygonDataValid)
                .HasColumnName(InsPfpVehicleType.Fields.IsPolygonDataValid);

            Property(t => t.CreateDate)
                .HasColumnName(InsPfpVehicleType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsPfpVehicleType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsPfpVehicleType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsPfpVehicleType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsPfpVehicleType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsPfpVehicleType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsPfpVehicleType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsPfpVehicleType.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
