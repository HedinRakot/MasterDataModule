using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORG_BANK_INFORMATION to entity <see cref="OrgBankInformation"/>
    /// </summary>
    internal sealed class OrgBankInformationMapping: EntityTypeConfiguration<OrgBankInformation>
    {
        
        public static readonly OrgBankInformationMapping Instance = new OrgBankInformationMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrgBankInformationMapping" /> class.
        /// </summary>
        private OrgBankInformationMapping()
        {

            ToTable("ORG_BANK_INFORMATION", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.BankName)
                .HasColumnName(OrgBankInformation.Fields.BankName)
                .IsUnicode()
                .HasMaxLength(250);

            Property(t => t.BankCode)
                .HasColumnName(OrgBankInformation.Fields.BankCode)
                .HasMaxLength(250);

            Property(t => t.BankAccount)
                .HasColumnName(OrgBankInformation.Fields.BankAccount)
                .HasMaxLength(250);

            Property(t => t.CreateDate)
                .HasColumnName(OrgBankInformation.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrgBankInformation.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrgBankInformation.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrgBankInformation.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrgBankInformation.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrgBankInformation.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrgBankInformation.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrgBankInformation.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.TransferValue)
                .HasColumnName(OrgBankInformation.Fields.TransferValue)
                .HasMaxLength(2);

            Property(t => t.TransferXValue)
                .HasColumnName(OrgBankInformation.Fields.TransferXValue)
                .HasMaxLength(4);

            Property(t => t.Id)
                .HasColumnName(OrgBankInformation.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
