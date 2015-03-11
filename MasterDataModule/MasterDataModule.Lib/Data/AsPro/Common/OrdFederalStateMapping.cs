using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table dbo.ORD_FEDERAL_STATE to entity <see cref="OrdFederalState"/>
    /// </summary>
    internal sealed class OrdFederalStateMapping: EntityTypeConfiguration<OrdFederalState>
    {
        
        public static readonly OrdFederalStateMapping Instance = new OrdFederalStateMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdFederalStateMapping" /> class.
        /// </summary>
        private OrdFederalStateMapping()
        {

            ToTable("ORD_FEDERAL_STATE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(OrdFederalState.Fields.Id)
                .IsRequired();

            Property(t => t.FederalStateName)
                .HasColumnName(OrdFederalState.Fields.FederalStateName)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Description)
                .HasColumnName(OrdFederalState.Fields.Description)
                .IsUnicode()
                .HasMaxLength(50);

            Property(t => t.StatistikKey)
                .HasColumnName(OrdFederalState.Fields.StatistikKey);

            Property(t => t.SysCountryId)
                .HasColumnName(OrdFederalState.Fields.SysCountryId);

            Property(t => t.CreateDate)
                .HasColumnName(OrdFederalState.Fields.CreateDate);

            Property(t => t.ChangeDate)
                .HasColumnName(OrdFederalState.Fields.ChangeDate);

            Property(t => t.DeleteDate)
                .HasColumnName(OrdFederalState.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(OrdFederalState.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(OrdFederalState.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(OrdFederalState.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(OrdFederalState.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(OrdFederalState.Fields.Source)
                .HasMaxLength(4);

            Property(t => t.FromDate)
                .HasColumnName(OrdFederalState.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(OrdFederalState.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
