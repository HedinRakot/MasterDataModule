// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MonitoringAgent.Data.Interfaces.Entities;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace MonitoringAgent.Common.Data
{
    // MASTER_DATA_NOTIFICATIONS
    internal partial class MasterDataNotificationsConfiguration : EntityTypeConfiguration<MasterDataNotifications>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MasterDataNotificationsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".MASTER_DATA_NOTIFICATIONS");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.NotificationType).HasColumnName("NOTIFICATION_TYPE").IsRequired();
            Property(x => x.IsAlertOn).HasColumnName("IS_ALERT_ON").IsRequired();
            Property(x => x.AlertCheckStatus).HasColumnName("ALERT_CHECK_STATUS").IsRequired();
            Property(x => x.AlertAttemptCount).HasColumnName("ALERT_ATTEMPT_COUNT").IsRequired();
            Property(x => x.Message).HasColumnName("MESSAGE").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.Subject).HasColumnName("SUBJECT").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
