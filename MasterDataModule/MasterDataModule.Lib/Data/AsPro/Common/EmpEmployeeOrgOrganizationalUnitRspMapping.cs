using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP to entity <see cref="EmpEmployeeOrgOrganizationalUnitRsp"/>
    /// </summary>
    internal sealed class EmpEmployeeOrgOrganizationalUnitRspMapping: EntityTypeConfiguration<EmpEmployeeOrgOrganizationalUnitRsp>
    {
        
        public static readonly EmpEmployeeOrgOrganizationalUnitRspMapping Instance = new EmpEmployeeOrgOrganizationalUnitRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpEmployeeOrgOrganizationalUnitRspMapping" /> class.
        /// </summary>
        private EmpEmployeeOrgOrganizationalUnitRspMapping()
        {

            ToTable("EMP_EMPLOYEE_ORG_ORGANIZATIONAL_UNIT_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.EmpEmployeeId)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.EmpEmployeeId)
                .IsRequired();

            Property(t => t.OrgOrganizationalUnitId)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.OrgOrganizationalUnitId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(EmpEmployeeOrgOrganizationalUnitRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
