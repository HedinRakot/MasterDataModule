using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_CONTACT_PERSON_FUNCTION to entity <see cref="OrdContactPersonFunction"/>
    /// </summary>
    internal sealed class OrdContactPersonFunctionMapping: EntityTypeConfiguration<OrdContactPersonFunction>
    {
        
        public static readonly OrdContactPersonFunctionMapping Instance = new OrdContactPersonFunctionMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdContactPersonFunctionMapping" /> class.
        /// </summary>
        private OrdContactPersonFunctionMapping()
        {

            ToTable("ORD_CONTACT_PERSON_FUNCTION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.SapId)
                .HasColumnName(OrdContactPersonFunction.Fields.SapId)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Description)
                .HasColumnName(OrdContactPersonFunction.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(OrdContactPersonFunction.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdContactPersonFunction.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdContactPersonFunction.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdContactPersonFunction.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdContactPersonFunction.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdContactPersonFunction.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdContactPersonFunction.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdContactPersonFunction.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdContactPersonFunction.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
