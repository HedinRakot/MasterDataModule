using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_CORE_DATA_PRODUCT_GROUP to entity <see cref="InsCoreDataProductGroup"/>
    /// </summary>
    internal sealed class InsCoreDataProductGroupMapping: EntityTypeConfiguration<InsCoreDataProductGroup>
    {
        
        public static readonly InsCoreDataProductGroupMapping Instance = new InsCoreDataProductGroupMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsCoreDataProductGroupMapping" /> class.
        /// </summary>
        private InsCoreDataProductGroupMapping()
        {

            ToTable("INS_CORE_DATA_PRODUCT_GROUP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsCoreDataProductGroup.Fields.Id)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(InsCoreDataProductGroup.Fields.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.DefaultDuration)
                .HasColumnName(InsCoreDataProductGroup.Fields.DefaultDuration)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(InsCoreDataProductGroup.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsCoreDataProductGroup.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsCoreDataProductGroup.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsCoreDataProductGroup.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsCoreDataProductGroup.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsCoreDataProductGroup.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsCoreDataProductGroup.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsCoreDataProductGroup.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
