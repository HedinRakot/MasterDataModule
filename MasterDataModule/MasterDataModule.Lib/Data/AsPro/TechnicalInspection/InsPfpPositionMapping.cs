using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_PFP_POSITION to entity <see cref="InsPfpPosition"/>
    /// </summary>
    internal sealed class InsPfpPositionMapping: EntityTypeConfiguration<InsPfpPosition>
    {
        
        public static readonly InsPfpPositionMapping Instance = new InsPfpPositionMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsPfpPositionMapping" /> class.
        /// </summary>
        private InsPfpPositionMapping()
        {

            ToTable("INS_PFP_POSITION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Text)
                .HasColumnName(InsPfpPosition.Fields.Text)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.TopId)
                .HasColumnName(InsPfpPosition.Fields.TopId);

            Property(t => t.CreateDate)
                .HasColumnName(InsPfpPosition.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsPfpPosition.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsPfpPosition.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsPfpPosition.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsPfpPosition.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsPfpPosition.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsPfpPosition.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsPfpPosition.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsPfpPosition.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(InsPfpPosition.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(InsPfpPosition.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
