using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataNotifications: ISystemFields
    {
		public MasterDataNotifications()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public int NotificationType { get; set; } // NOTIFICATION_TYPE. DE: Überwachungsnachricht Typ  EN: Notification type
        public bool IsAlertOn { get; set; } // IS_ALERT_ON. DE: Aktiv  EN: Is alert on
        public int AlertCheckStatus { get; set; } // ALERT_CHECK_STATUS. DE: Status  EN: Check status for alert
        public int AlertAttemptCount { get; set; } // ALERT_ATTEMPT_COUNT. DE: Versuchanzahl  EN: Attempt count for alert
        public string Message { get; set; } // MESSAGE. DE: Nachricht  EN: Message
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public string Subject { get; set; } // SUBJECT. DE: Thema  EN: Subject
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
	}
}
