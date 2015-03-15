using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_ORDER_CANCELATION_REASON to entity <see cref="OrdOrderCancelationReason"/>
    /// </summary>
    internal sealed class OrdOrderCancelationReasonMapping: EntityTypeConfiguration<OrdOrderCancelationReason>
    {
        
        public static readonly OrdOrderCancelationReasonMapping Instance = new OrdOrderCancelationReasonMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdOrderCancelationReasonMapping" /> class.
        /// </summary>
        private OrdOrderCancelationReasonMapping()
        {

            ToTable("ORD_ORDER_CANCELATION_REASON", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.CancelationReasonText)
                .HasColumnName(OrdOrderCancelationReason.Fields.CancelationReasonText)
                .IsUnicode()
                .HasMaxLength(1024);

            Property(t => t.CreateDate)
                .HasColumnName(OrdOrderCancelationReason.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdOrderCancelationReason.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdOrderCancelationReason.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdOrderCancelationReason.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdOrderCancelationReason.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdOrderCancelationReason.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdOrderCancelationReason.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdOrderCancelationReason.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdOrderCancelationReason.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrdOrderCancelationReason.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdOrderCancelationReason.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
