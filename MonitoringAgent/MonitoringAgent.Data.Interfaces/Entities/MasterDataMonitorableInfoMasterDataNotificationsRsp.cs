using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRsp: ISystemFields
    {
		public MasterDataMonitorableInfoMasterDataNotificationsRsp()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public int MonitorableInfoType { get; set; } // MONITORABLE_INFO_TYPE. DE: Überwachungsobjekt Typ  EN: Monitorable object type
        public int MonitorableInfoId { get; set; } // MONITORABLE_INFO_ID. DE: Überwachungsobjekt  EN: Monitorable object id
        public int MasterDataNotificationsId { get; set; } // MASTER_DATA_NOTIFICATIONS_ID. DE: Überwachungsnachricht  EN: Notification
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
	}
}
