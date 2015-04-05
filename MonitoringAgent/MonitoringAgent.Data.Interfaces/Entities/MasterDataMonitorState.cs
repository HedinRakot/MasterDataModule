using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataMonitorState
    {
        public int Id { get; set; } // ID (Primary key)
        public bool? Reconfigure { get; set; } // RECONFIGURE
        public int ReconfigureCheckingTimeout { get; set; } // RECONFIGURE_CHECKING_TIMEOUT
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
	}
}
