using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.INS_OBD_STATUS to entity <see cref="InsObdStatus"/>
    /// </summary>
    internal sealed class InsObdStatusMapping: EntityTypeConfiguration<InsObdStatus>
    {
        
        public static readonly InsObdStatusMapping Instance = new InsObdStatusMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="InsObdStatusMapping" /> class.
        /// </summary>
        private InsObdStatusMapping()
        {

            ToTable("INS_OBD_STATUS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(InsObdStatus.Fields.Id)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(InsObdStatus.Fields.Name)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Description)
                .HasColumnName(InsObdStatus.Fields.Description)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.AuView)
                .HasColumnName(InsObdStatus.Fields.AuView)
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength();

            Property(t => t.CreateDate)
                .HasColumnName(InsObdStatus.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(InsObdStatus.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(InsObdStatus.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(InsObdStatus.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(InsObdStatus.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(InsObdStatus.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(InsObdStatus.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(InsObdStatus.Fields.Source)
                .HasMaxLength(4);


            //Relationships
        }
    }
}
