using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataWindowsServiceCheckResults: ISystemFields
    {
		public MasterDataWindowsServiceCheckResults()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public int? CheckStatus { get; set; } // CHECK_STATUS. DE: Status  EN: Status
        public DateTime? CheckDate { get; set; } // CHECK_DATE. DE: Prüfungsdatum  EN: Check date
        public string Message { get; set; } // MESSAGE. DE: Nachricht  EN: Message
        public int? Attempt { get; set; } // ATTEMPT. DE: Zähler  EN: Attempt
        public int MasterDataWindowsServiceInfoId { get; set; } // MASTER_DATA_WINDOWS_SERVICE_INFO_ID. DE: Windows-Service  EN: Windows service info
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
	}
}
