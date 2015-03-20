using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_DRIVER_SCHOOL to entity <see cref="DriverSchool"/>
    /// </summary>
    internal sealed class DriverSchoolMapping: EntityTypeConfiguration<DriverSchool>
    {
        
        public static readonly DriverSchoolMapping Instance = new DriverSchoolMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="DriverSchoolMapping" /> class.
        /// </summary>
        private DriverSchoolMapping()
        {

            ToTable("DRL_DRIVER_SCHOOL", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(DriverSchool.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.DriverSchoolNumber)
                .HasColumnName(DriverSchool.Fields.DriverSchoolNumber)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.OrdCustomerId)
                .HasColumnName(DriverSchool.Fields.OrdCustomerId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(DriverSchool.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(DriverSchool.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(DriverSchool.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(DriverSchool.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(DriverSchool.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(DriverSchool.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(DriverSchool.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(DriverSchool.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(DriverSchool.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(DriverSchool.Fields.ToDate)
                .IsRequired();

            Property(t => t.RowVersion)
                .HasColumnName(DriverSchool.Fields.RowVersion)
                .IsRequired();


            //Relationships
        }
    }
}
