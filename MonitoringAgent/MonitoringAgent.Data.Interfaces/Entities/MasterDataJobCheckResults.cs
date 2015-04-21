using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataJobCheckResults: ISystemFields
    {
		public MasterDataJobCheckResults()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public DateTime? LastRunTime { get; set; } // LAST_RUN_TIME. DE: Letztes Prüfungsdatum  EN: Last run time
        public DateTime? CheckDate { get; set; } // CHECK_DATE. DE: Prüfungsdatum  EN: Check date
        public int? CheckStatus { get; set; } // CHECK_STATUS. DE: Status  EN: Status
        public int MasterDataJobInfoId { get; set; } // MASTER_DATA_JOB_INFO_ID. DE: Hintergrundprozess  EN: Job info
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
	}
}
