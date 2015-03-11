using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_EMPLOYEE to entity <see cref="EmpEmployee"/>
    /// </summary>
    internal sealed class EmpEmployeeMapping: EntityTypeConfiguration<EmpEmployee>
    {
        
        public static readonly EmpEmployeeMapping Instance = new EmpEmployeeMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpEmployeeMapping" /> class.
        /// </summary>
        private EmpEmployeeMapping()
        {

            ToTable("EMP_EMPLOYEE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(EmpEmployee.Fields.Id)
                .IsRequired();

            Property(t => t.PersonalNumber)
                .HasColumnName(EmpEmployee.Fields.PersonalNumber)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Domain)
                .HasColumnName(EmpEmployee.Fields.Domain)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.UserName)
                .HasColumnName(EmpEmployee.Fields.UserName)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.WindowsUserName)
                .HasColumnName(EmpEmployee.Fields.WindowsUserName)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.IsSsoAllowed)
                .HasColumnName(EmpEmployee.Fields.IsSsoAllowed);

            Property(t => t.IsPasswordLoginAllowed)
                .HasColumnName(EmpEmployee.Fields.IsPasswordLoginAllowed);

            Property(t => t.IsEmergencyLoginAllowed)
                .HasColumnName(EmpEmployee.Fields.IsEmergencyLoginAllowed);

            Property(t => t.EmpCoreAddressId)
                .HasColumnName(EmpEmployee.Fields.EmpCoreAddressId);

            Property(t => t.Name)
                .HasColumnName(EmpEmployee.Fields.Name)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.MiddleName)
                .HasColumnName(EmpEmployee.Fields.MiddleName)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.LastName)
                .HasColumnName(EmpEmployee.Fields.LastName)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.Comment)
                .HasColumnName(EmpEmployee.Fields.Comment)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.SexType)
                .HasColumnName(EmpEmployee.Fields.SexType);

            Property(t => t.Title)
                .HasColumnName(EmpEmployee.Fields.Title)
                .IsUnicode()
                .HasMaxLength(90);

            Property(t => t.Birthdate)
                .HasColumnName(EmpEmployee.Fields.Birthdate)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(EmpEmployee.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpEmployee.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpEmployee.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpEmployee.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpEmployee.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpEmployee.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpEmployee.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpEmployee.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(EmpEmployee.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(EmpEmployee.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
