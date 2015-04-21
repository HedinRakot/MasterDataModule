using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataNotificationsMasterDataSubscribersRsp: ISystemFields
    {
		public MasterDataNotificationsMasterDataSubscribersRsp()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public int MasterDataNotificationsId { get; set; } // MASTER_DATA_NOTIFICATIONS_ID. DE: Überwachungsnachricht  EN: Notification
        public int MasterDataSubscribersId { get; set; } // MASTER_DATA_SUBSCRIBERS_ID. DE: Empfänger  EN: Subscriber
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
	}
}
