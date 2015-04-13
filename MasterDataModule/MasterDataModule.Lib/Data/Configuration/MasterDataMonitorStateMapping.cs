using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_MONITOR_STATE to entity <see cref="MasterDataMonitorState"/>
    /// </summary>
    internal sealed class MasterDataMonitorStateMapping: EntityTypeConfiguration<MasterDataMonitorState>
    {
        
        public static readonly MasterDataMonitorStateMapping Instance = new MasterDataMonitorStateMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataMonitorStateMapping" /> class.
        /// </summary>
        private MasterDataMonitorStateMapping()
        {

            ToTable("MASTER_DATA_MONITOR_STATE", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataMonitorState.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Reconfigure)
                .HasColumnName(MasterDataMonitorState.Fields.Reconfigure);

            Property(t => t.ReconfigureCheckingTimeout)
                .HasColumnName(MasterDataMonitorState.Fields.ReconfigureCheckingTimeout)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataMonitorState.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataMonitorState.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataMonitorState.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(MasterDataMonitorState.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataMonitorState.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
