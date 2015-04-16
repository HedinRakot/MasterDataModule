using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP to entity <see cref="MasterDataNotificationsMasterDataSubscribersRsp"/>
    /// </summary>
    internal sealed class MasterDataNotificationsMasterDataSubscribersRspMapping: EntityTypeConfiguration<MasterDataNotificationsMasterDataSubscribersRsp>
    {
        
        public static readonly MasterDataNotificationsMasterDataSubscribersRspMapping Instance = new MasterDataNotificationsMasterDataSubscribersRspMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataNotificationsMasterDataSubscribersRspMapping" /> class.
        /// </summary>
        private MasterDataNotificationsMasterDataSubscribersRspMapping()
        {

            ToTable("MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.MasterDataNotificationsId)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.MasterDataNotificationsId)
                .IsRequired();

            Property(t => t.MasterDataSubscribersId)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.MasterDataSubscribersId)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.DeleteDate);

            Property(t => t.FromDate)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataNotificationsMasterDataSubscribersRsp.Fields.ToDate)
                .IsRequired();


            //Relationships
            HasRequired(m => m.MasterDataNotifications)
                .WithMany(m => m.MasterDataNotificationsMasterDataSubscribersRsps)
                .HasForeignKey(t => t.MasterDataNotificationsId);
            HasRequired(m => m.MasterDataSubscribers)
                .WithMany(m => m.MasterDataNotificationsMasterDataSubscribersRsps)
                .HasForeignKey(t => t.MasterDataSubscribersId);
        }
    }
}
