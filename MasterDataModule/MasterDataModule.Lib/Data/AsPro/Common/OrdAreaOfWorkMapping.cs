using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_AREA_OF_WORK to entity <see cref="OrdAreaOfWork"/>
    /// </summary>
    internal sealed class OrdAreaOfWorkMapping: EntityTypeConfiguration<OrdAreaOfWork>
    {
        
        public static readonly OrdAreaOfWorkMapping Instance = new OrdAreaOfWorkMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdAreaOfWorkMapping" /> class.
        /// </summary>
        private OrdAreaOfWorkMapping()
        {

            ToTable("ORD_AREA_OF_WORK", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(OrdAreaOfWork.Fields.Name)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(OrdAreaOfWork.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdAreaOfWork.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdAreaOfWork.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdAreaOfWork.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdAreaOfWork.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdAreaOfWork.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdAreaOfWork.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdAreaOfWork.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Description)
                .HasColumnName(OrdAreaOfWork.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.IsProvisionCostAllowed)
                .HasColumnName(OrdAreaOfWork.Fields.IsProvisionCostAllowed)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(OrdAreaOfWork.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrdAreaOfWork.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdAreaOfWork.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
