using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataMonitorState: ISystemFields
    {
		public MasterDataMonitorState()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public bool? Reconfigure { get; set; } // RECONFIGURE. DE: Neue Konfiguration  EN: Reconfigure
        public int ReconfigureCheckingTimeout { get; set; } // RECONFIGURE_CHECKING_TIMEOUT. DE: Neue Konfiguration Timeout  EN: Reconfigure flag checking timeout
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
	}
}
