using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataNotifications
    {
        public int Id { get; set; } // ID (Primary key)
        public int NotificationType { get; set; } // NOTIFICATION_TYPE
        public bool IsAlertOn { get; set; } // IS_ALERT_ON
        public int AlertCheckStatus { get; set; } // ALERT_CHECK_STATUS
        public int AlertAttemptCount { get; set; } // ALERT_ATTEMPT_COUNT
        public string Message { get; set; } // MESSAGE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
	}
}
