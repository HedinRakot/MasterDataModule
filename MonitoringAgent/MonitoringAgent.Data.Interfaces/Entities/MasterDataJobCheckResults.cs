using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataJobCheckResults
    {
        public int Id { get; set; } // ID (Primary key)
        public DateTime? LastRunTime { get; set; } // LAST_RUN_TIME
        public DateTime? CheckDate { get; set; } // CHECK_DATE
        public int? CheckStatus { get; set; } // CHECK_STATUS
        public int MasterDataJobInfoId { get; set; } // MASTER_DATA_JOB_INFO_ID
	}
}
