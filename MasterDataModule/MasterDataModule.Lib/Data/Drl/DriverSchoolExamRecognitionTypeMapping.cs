using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP to entity <see cref="DriverSchoolExamRecognitionType"/>
    /// </summary>
    internal sealed class DriverSchoolExamRecognitionTypeMapping: EntityTypeConfiguration<DriverSchoolExamRecognitionType>
    {
        
        public static readonly DriverSchoolExamRecognitionTypeMapping Instance = new DriverSchoolExamRecognitionTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="DriverSchoolExamRecognitionTypeMapping" /> class.
        /// </summary>
        private DriverSchoolExamRecognitionTypeMapping()
        {

            ToTable("DRL_DRIVER_SCHOOL_EXAM_RECOGNITION_TYPE_RSP", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.DriverSchoolId)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.DriverSchoolId)
                .IsRequired();

            Property(t => t.ExamRecognitionTypeId)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.ExamRecognitionTypeId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(DriverSchoolExamRecognitionType.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasRequired(d => d.DriverSchool)
                .WithMany(d => d.DriverSchoolExamRecognitionTypes)
                .HasForeignKey(t => t.DriverSchoolId);
            HasRequired(d => d.ExamRecognitionType)
                .WithMany(e => e.DriverSchoolExamRecognitionTypes)
                .HasForeignKey(t => t.ExamRecognitionTypeId);
        }
    }
}
