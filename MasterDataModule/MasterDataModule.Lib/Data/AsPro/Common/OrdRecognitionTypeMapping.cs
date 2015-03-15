using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_RECOGNITION_TYPE to entity <see cref="OrdRecognitionType"/>
    /// </summary>
    internal sealed class OrdRecognitionTypeMapping: EntityTypeConfiguration<OrdRecognitionType>
    {
        
        public static readonly OrdRecognitionTypeMapping Instance = new OrdRecognitionTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
        private OrdRecognitionTypeMapping()
        {

            ToTable("ORD_RECOGNITION_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(OrdRecognitionType.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(OrdRecognitionType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdRecognitionType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdRecognitionType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdRecognitionType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdRecognitionType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdRecognitionType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdRecognitionType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdRecognitionType.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdRecognitionType.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrdRecognitionType.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdRecognitionType.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
