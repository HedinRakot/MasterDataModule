using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EXP_PASSENGERS_TYPE to entity <see cref="ExpPassengersType"/>
    /// </summary>
    internal sealed class ExpPassengersTypeMapping: EntityTypeConfiguration<ExpPassengersType>
    {
        
        public static readonly ExpPassengersTypeMapping Instance = new ExpPassengersTypeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="ExpPassengersTypeMapping" /> class.
        /// </summary>
        private ExpPassengersTypeMapping()
        {

            ToTable("EXP_PASSENGERS_TYPE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(ExpPassengersType.Fields.Id)
                .IsRequired();

            Property(t => t.Text)
                .HasColumnName(ExpPassengersType.Fields.Text)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);

            Property(t => t.Code)
                .HasColumnName(ExpPassengersType.Fields.Code)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            Property(t => t.CreateDate)
                .HasColumnName(ExpPassengersType.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(ExpPassengersType.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(ExpPassengersType.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(ExpPassengersType.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(ExpPassengersType.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(ExpPassengersType.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(ExpPassengersType.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(ExpPassengersType.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
