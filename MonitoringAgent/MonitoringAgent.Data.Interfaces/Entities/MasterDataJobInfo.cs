using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataJobInfo: ISystemFields
    {
		public MasterDataJobInfo()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public string ConnectionString { get; set; } // CONNECTION_STRING. DE: Connection string  EN: Connection string
        public string TableName { get; set; } // TABLE_NAME. DE: Tabelle  EN: Table name
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING. DE: Timeout checking  EN: Timeout checking
        public string Name { get; set; } // NAME. DE: Name  EN: Name
        public string JobName { get; set; } // JOB_NAME. DE: Hintergrundprozess Name  EN:  Job name
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
        public int? LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
