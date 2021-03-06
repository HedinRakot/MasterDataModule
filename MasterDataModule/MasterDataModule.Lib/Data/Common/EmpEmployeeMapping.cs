//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;    
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
        /// <summary>
        /// Database mapping for <see cref="EmpEmployee"/> to table EMP_EMPLOYEE
        /// </summary>
        internal sealed class EmpEmployeeMapping : EntityTypeConfiguration<EmpEmployee>
        {
    	    public static readonly EmpEmployeeMapping Instance = new EmpEmployeeMapping();
    	    /// <summary>
            /// Instance constructor
            /// </summary>
            private EmpEmployeeMapping()
            {
                // Primary Key
                this.HasKey(t => t.Id);
    
                // Properties
                this.Property(t => t.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
                this.Property(t => t.PersonalNumber)
                    .IsRequired()
                    .HasMaxLength(10);
    
                this.Property(t => t.Domain)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.UserName)
                    .IsUnicode()
                    .HasMaxLength(50);
    
                this.Property(t => t.WindowsUserName)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.Name)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.MiddleName)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.LastName)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.Comment)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.Title)
                    .IsUnicode()
                    .HasMaxLength(90);
    
                this.Property(t => t.CreateDate)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.Source)
                    .HasMaxLength(4);
    
                // Table & Column Mappings
                this.ToTable("EMP_EMPLOYEE", "DBO");
                this.Property(t => t.Id).HasColumnName(EmpEmployee.Fields.Id);
                //this.Property(t => t.UserId).HasColumnName(EmpEmployee.Fields.UserId);
                this.Property(t => t.PersonalNumber).HasColumnName(EmpEmployee.Fields.PersonalNumber);
                this.Property(t => t.Domain).HasColumnName(EmpEmployee.Fields.Domain);
                this.Property(t => t.UserName).HasColumnName(EmpEmployee.Fields.UserName);
                this.Property(t => t.WindowsUserName).HasColumnName(EmpEmployee.Fields.WindowsUserName);
                //this.Property(t => t.OrgCostCenterId).HasColumnName(EmpEmployee.Fields.OrgCostCenterId);
                //this.Property(t => t.ContactEmployeeId).HasColumnName(EmpEmployee.Fields.ContactEmployeeId);
                this.Property(t => t.IsSsoAllowed).HasColumnName(EmpEmployee.Fields.IsSsoAllowed);
                this.Property(t => t.IsPasswordLoginAllowed).HasColumnName(EmpEmployee.Fields.IsPasswordLoginAllowed);
                this.Property(t => t.IsEmergencyLoginAllowed).HasColumnName(EmpEmployee.Fields.IsEmergencyLoginAllowed);
                this.Property(t => t.EmpCoreAddressId).HasColumnName(EmpEmployee.Fields.EmpCoreAddressId);
                this.Property(t => t.Name).HasColumnName(EmpEmployee.Fields.Name);
                this.Property(t => t.MiddleName).HasColumnName(EmpEmployee.Fields.MiddleName);
                this.Property(t => t.LastName).HasColumnName(EmpEmployee.Fields.LastName);
                //this.Property(t => t.CountryFlag).HasColumnName(EmpEmployee.Fields.CountryFlag);
                this.Property(t => t.Comment).HasColumnName(EmpEmployee.Fields.Comment);
                this.Property(t => t.SexType).HasColumnName(EmpEmployee.Fields.SexType);
                this.Property(t => t.Title).HasColumnName(EmpEmployee.Fields.Title);
                this.Property(t => t.Birthdate).HasColumnName(EmpEmployee.Fields.Birthdate);
                //this.Property(t => t.TopEmployeeId).HasColumnName(EmpEmployee.Fields.TopEmployeeId);
                this.Property(t => t.CreateDate).HasColumnName(EmpEmployee.Fields.CreateDate);
                this.Property(t => t.ChangeDate).HasColumnName(EmpEmployee.Fields.ChangeDate);
                this.Property(t => t.DeleteDate).HasColumnName(EmpEmployee.Fields.DeleteDate);
                this.Property(t => t.OwnerOrgId).HasColumnName(EmpEmployee.Fields.OwnerOrgId);
                this.Property(t => t.VisibilityOrgId).HasColumnName(EmpEmployee.Fields.VisibilityOrgId);
                this.Property(t => t.CreateEmployeeId).HasColumnName(EmpEmployee.Fields.CreateEmployeeId);
                this.Property(t => t.ChangeEmployeeId).HasColumnName(EmpEmployee.Fields.ChangeEmployeeId);
                this.Property(t => t.Source).HasColumnName(EmpEmployee.Fields.Source);
                this.Property(t => t.FromDate).HasColumnName(EmpEmployee.Fields.FromDate);
                this.Property(t => t.ToDate).HasColumnName(EmpEmployee.Fields.ToDate);
    
    
            }
        }
}
