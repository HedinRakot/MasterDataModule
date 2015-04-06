using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class ApplicationLogs: ISystemFields
    {
		public ApplicationLogs()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID
        public int LogType { get; set; } // LOG_TYPE
        public int LogLevel { get; set; } // LOG_LEVEL
        public DateTime? Date { get; set; } // DATE
        public string Message { get; set; } // MESSAGE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
	}
}
