using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_RECOGNITION to entity <see cref="OrdRecognition"/>
    /// </summary>
    internal sealed class OrdRecognitionMapping: EntityTypeConfiguration<OrdRecognition>
    {
        
        public static readonly OrdRecognitionMapping Instance = new OrdRecognitionMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionMapping" /> class.
        /// </summary>
        private OrdRecognitionMapping()
        {

            ToTable("ORD_RECOGNITION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(OrdRecognition.Fields.Id)
                .IsRequired();

            Property(t => t.OrdRecognitionTypeId)
                .HasColumnName(OrdRecognition.Fields.OrdRecognitionTypeId);

            Property(t => t.CreateDate)
                .HasColumnName(OrdRecognition.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdRecognition.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdRecognition.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdRecognition.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdRecognition.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdRecognition.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdRecognition.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdRecognition.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(OrdRecognition.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdRecognition.Fields.ToDate)
                .IsRequired();

            Property(t => t.OrgAccountingAreaId)
                .HasColumnName(OrdRecognition.Fields.OrgAccountingAreaId);


            //Relationships
        }
    }
}
