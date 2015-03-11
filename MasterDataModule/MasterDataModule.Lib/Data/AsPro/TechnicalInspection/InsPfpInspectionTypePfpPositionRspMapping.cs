using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP to entity <see cref="InsPfpInspectionTypePfpPositionRsp"/>
    /// </summary>
    internal sealed class InsPfpInspectionTypePfpPositionRspMapping: EntityTypeConfiguration<InsPfpInspectionTypePfpPositionRsp>
    {
        
        public static readonly InsPfpInspectionTypePfpPositionRspMapping Instance = new InsPfpInspectionTypePfpPositionRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsPfpInspectionTypePfpPositionRspMapping" /> class.
        /// </summary>
        private InsPfpInspectionTypePfpPositionRspMapping()
        {

            ToTable("INS_PFP_INSPECTION_TYPE_PFP_POSITION_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.Id)
                .IsRequired();

            Property(t => t.InsPfpPositionId)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.InsPfpPositionId)
                .IsRequired();

            Property(t => t.InsPfpInspectionTypeId)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.InsPfpInspectionTypeId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsPfpInspectionTypePfpPositionRsp.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
