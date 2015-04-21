using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataWindowsServiceInfo: ISystemFields
    {
		public MasterDataWindowsServiceInfo()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public string Name { get; set; } // NAME. DE: Name  EN: Name
        public string MachineName { get; set; } // MACHINE_NAME. DE: Machine Name  EN: Machine name
        public string ServiceName { get; set; } // SERVICE_NAME. DE: Windows-Service Name  EN: Service name
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING. DE: Timeout  EN: Timeout checking
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
        public int? LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
