using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_STATISTIC_GROUP to entity <see cref="InsStatisticGroup"/>
    /// </summary>
    internal sealed class InsStatisticGroupMapping: EntityTypeConfiguration<InsStatisticGroup>
    {
        
        public static readonly InsStatisticGroupMapping Instance = new InsStatisticGroupMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsStatisticGroupMapping" /> class.
        /// </summary>
        private InsStatisticGroupMapping()
        {

            ToTable("INS_STATISTIC_GROUP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Description)
                .HasColumnName(InsStatisticGroup.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(InsStatisticGroup.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsStatisticGroup.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsStatisticGroup.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsStatisticGroup.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsStatisticGroup.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsStatisticGroup.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsStatisticGroup.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsStatisticGroup.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(InsStatisticGroup.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
