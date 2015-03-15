using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.EMP_EMPLOYEE_TOP_EMPLOYEE_RSP to entity <see cref="EmpEmployeeTopEmployeeRsp"/>
    /// </summary>
    internal sealed class EmpEmployeeTopEmployeeRspMapping: EntityTypeConfiguration<EmpEmployeeTopEmployeeRsp>
    {
        
        public static readonly EmpEmployeeTopEmployeeRspMapping Instance = new EmpEmployeeTopEmployeeRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmpEmployeeTopEmployeeRspMapping" /> class.
        /// </summary>
        private EmpEmployeeTopEmployeeRspMapping()
        {

            ToTable("EMP_EMPLOYEE_TOP_EMPLOYEE_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.EmpEmployeeId)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.EmpEmployeeId)
                .IsRequired();

            Property(t => t.TopEmployeeId)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.TopEmployeeId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.Source)
                .IsUnicode()
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.ToDate)
                .IsRequired();

            Property(t => t.Id)
                .HasColumnName(EmpEmployeeTopEmployeeRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            //Relationships
        }
    }
}
