using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.SYS_POST_CODE to entity <see cref="SysPostCode"/>
    /// </summary>
    internal sealed class SysPostCodeMapping: EntityTypeConfiguration<SysPostCode>
    {
        
        public static readonly SysPostCodeMapping Instance = new SysPostCodeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="SysPostCodeMapping" /> class.
        /// </summary>
        private SysPostCodeMapping()
        {

            ToTable("SYS_POST_CODE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(SysPostCode.Fields.Id)
                .IsRequired();

            Property(t => t.PostCode)
                .HasColumnName(SysPostCode.Fields.PostCode)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.City)
                .HasColumnName(SysPostCode.Fields.City)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.Street)
                .HasColumnName(SysPostCode.Fields.Street)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.CreateDate)
                .HasColumnName(SysPostCode.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(SysPostCode.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(SysPostCode.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(SysPostCode.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(SysPostCode.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(SysPostCode.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(SysPostCode.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(SysPostCode.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
