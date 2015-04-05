using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataNotificationsMasterDataSubscribersRsp
    {
        public int Id { get; set; } // ID (Primary key)
        public int MasterDataNotificationsId { get; set; } // MASTER_DATA_NOTIFICATIONS_ID
        public int MasterDataSubscribersId { get; set; } // MASTER_DATA_SUBSCRIBERS_ID
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
	}
}