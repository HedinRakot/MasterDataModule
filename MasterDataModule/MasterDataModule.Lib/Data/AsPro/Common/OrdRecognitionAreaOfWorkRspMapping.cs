using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_RECOGNITION_AREA_OF_WORK_RSP to entity <see cref="OrdRecognitionAreaOfWorkRsp"/>
    /// </summary>
    internal sealed class OrdRecognitionAreaOfWorkRspMapping: EntityTypeConfiguration<OrdRecognitionAreaOfWorkRsp>
    {
        
        public static readonly OrdRecognitionAreaOfWorkRspMapping Instance = new OrdRecognitionAreaOfWorkRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionAreaOfWorkRspMapping" /> class.
        /// </summary>
        private OrdRecognitionAreaOfWorkRspMapping()
        {

            ToTable("ORD_RECOGNITION_AREA_OF_WORK_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.Id)
                .IsRequired();

            Property(t => t.OrdRecognitionId)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.OrdRecognitionId)
                .IsRequired();

            Property(t => t.OrdAreaOfWorkId)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.OrdAreaOfWorkId)
                .IsRequired();

            Property(t => t.Priority)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.Priority)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdRecognitionAreaOfWorkRsp.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
