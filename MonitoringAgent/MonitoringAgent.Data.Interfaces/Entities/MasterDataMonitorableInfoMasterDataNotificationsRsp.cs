using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRsp
    {
        public int Id { get; set; } // ID (Primary key)
        public int MonitorableInfoType { get; set; } // MONITORABLE_INFO_TYPE
        public int MonitorableInfoId { get; set; } // MONITORABLE_INFO_ID
        public int MasterDataNotificationsId { get; set; } // MASTER_DATA_NOTIFICATIONS_ID
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
	}
}
