using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP to entity <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp"/>
    /// </summary>
    internal sealed class MasterDataMonitorableInfoMasterDataNotificationsRspMapping: EntityTypeConfiguration<MasterDataMonitorableInfoMasterDataNotificationsRsp>
    {
        
        public static readonly MasterDataMonitorableInfoMasterDataNotificationsRspMapping Instance = new MasterDataMonitorableInfoMasterDataNotificationsRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataMonitorableInfoMasterDataNotificationsRspMapping" /> class.
        /// </summary>
        private MasterDataMonitorableInfoMasterDataNotificationsRspMapping()
        {

            ToTable("MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.MonitorableInfoType)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.MonitorableInfoType)
                .IsRequired();

            Property(t => t.MonitorableInfoId)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.MonitorableInfoId)
                .IsRequired();

            Property(t => t.MasterDataNotificationsId)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.MasterDataNotificationsId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataMonitorableInfoMasterDataNotificationsRsp.Fields.DeleteDate);


            //Relationships
        }
    }
}
