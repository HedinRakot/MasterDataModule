using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_DRIVER_SCHOOL_INFO_RSP to entity <see cref="DriverSchoolInfo"/>
    /// </summary>
    internal sealed class DriverSchoolInfoMapping: EntityTypeConfiguration<DriverSchoolInfo>
    {
        
        public static readonly DriverSchoolInfoMapping Instance = new DriverSchoolInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="DriverSchoolInfoMapping" /> class.
        /// </summary>
        private DriverSchoolInfoMapping()
        {

            ToTable("DRL_DRIVER_SCHOOL_INFO_RSP", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(DriverSchoolInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.SchoolInfoId)
                .HasColumnName(DriverSchoolInfo.Fields.SchoolInfoId)
                .IsRequired();

            Property(t => t.DriverSchoolId)
                .HasColumnName(DriverSchoolInfo.Fields.DriverSchoolId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(DriverSchoolInfo.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(DriverSchoolInfo.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(DriverSchoolInfo.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(DriverSchoolInfo.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(DriverSchoolInfo.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(DriverSchoolInfo.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(DriverSchoolInfo.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(DriverSchoolInfo.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(DriverSchoolInfo.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(DriverSchoolInfo.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasRequired(d => d.DriverSchool)
                .WithMany(d => d.DriverSchoolInfos)
                .HasForeignKey(t => t.DriverSchoolId);
            HasRequired(d => d.SchoolInfo)
                .WithMany(s => s.DriverSchoolInfos)
                .HasForeignKey(t => t.SchoolInfoId);
        }
    }
}
