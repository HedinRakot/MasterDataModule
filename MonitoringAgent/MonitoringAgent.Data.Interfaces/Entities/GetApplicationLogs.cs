using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class GetApplicationLogs: ISystemFields
    {
		public GetApplicationLogs()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID
        public int LogLevel { get; set; } // LOG_LEVEL
        public DateTime? MessageDate { get; set; } // MESSAGE_DATE
        public string Message { get; set; } // MESSAGE
        public string FileName { get; set; } // FILE_NAME
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public int LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
