using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class ApplicationLogs: ISystemFields
    {
		public ApplicationLogs()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public int LogLevel { get; set; } // LOG_LEVEL. DE: Log-Stufe  EN: logs level
        public DateTime? Date { get; set; } // DATE. DE: Datum  EN: Date
        public string Message { get; set; } // MESSAGE. DE: Text  EN: Text
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
        public int LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
