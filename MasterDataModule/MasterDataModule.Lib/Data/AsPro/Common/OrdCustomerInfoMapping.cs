using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_CUSTOMER_INFO to entity <see cref="OrdCustomerInfo"/>
    /// </summary>
    internal sealed class OrdCustomerInfoMapping: EntityTypeConfiguration<OrdCustomerInfo>
    {
        
        public static readonly OrdCustomerInfoMapping Instance = new OrdCustomerInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdCustomerInfoMapping" /> class.
        /// </summary>
        private OrdCustomerInfoMapping()
        {

            ToTable("ORD_CUSTOMER_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.TextValue)
                .HasColumnName(OrdCustomerInfo.Fields.TextValue)
                .IsUnicode()
                .HasMaxLength(512);

            Property(t => t.NumberValue)
                .HasColumnName(OrdCustomerInfo.Fields.NumberValue);

            Property(t => t.InfoType)
                .HasColumnName(OrdCustomerInfo.Fields.InfoType)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(OrdCustomerInfo.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdCustomerInfo.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdCustomerInfo.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdCustomerInfo.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdCustomerInfo.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdCustomerInfo.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdCustomerInfo.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdCustomerInfo.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrdCustomerInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(OrdCustomerInfo.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdCustomerInfo.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
