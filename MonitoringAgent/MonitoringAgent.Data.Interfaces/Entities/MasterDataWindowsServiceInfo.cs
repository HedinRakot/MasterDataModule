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
        public string Name { get; set; } // NAME
        public string MachineName { get; set; } // MACHINE_NAME
        public string ServiceName { get; set; } // SERVICE_NAME
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
	}
}
