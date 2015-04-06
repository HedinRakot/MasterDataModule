using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_NOTIFICATIONS to entity <see cref="MasterDataNotifications"/>
    /// </summary>
    internal sealed class MasterDataNotificationsMapping: EntityTypeConfiguration<MasterDataNotifications>
    {
        
        public static readonly MasterDataNotificationsMapping Instance = new MasterDataNotificationsMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataNotificationsMapping" /> class.
        /// </summary>
        private MasterDataNotificationsMapping()
        {

            ToTable("MASTER_DATA_NOTIFICATIONS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataNotifications.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.NotificationType)
                .HasColumnName(MasterDataNotifications.Fields.NotificationType)
                .IsRequired();

            Property(t => t.IsAlertOn)
                .HasColumnName(MasterDataNotifications.Fields.IsAlertOn)
                .IsRequired();

            Property(t => t.AlertCheckStatus)
                .HasColumnName(MasterDataNotifications.Fields.AlertCheckStatus)
                .IsRequired();

            Property(t => t.AlertAttemptCount)
                .HasColumnName(MasterDataNotifications.Fields.AlertAttemptCount)
                .IsRequired();

            Property(t => t.Message)
                .HasColumnName(MasterDataNotifications.Fields.Message)
                .IsRequired()
                .IsUnicode();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataNotifications.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataNotifications.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataNotifications.Fields.DeleteDate);

            Property(t => t.Subject)
                .HasColumnName(MasterDataNotifications.Fields.Subject)
                .IsRequired()
                .IsUnicode();


            //Relationships
        }
    }
}
