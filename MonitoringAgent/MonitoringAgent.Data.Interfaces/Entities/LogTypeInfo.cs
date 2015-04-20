using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class LogTypeInfo: ISystemFields
    {
		public LogTypeInfo()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
        public string FileName { get; set; } // FILE_NAME
        public string FilePattern { get; set; } // FILE_PATTERN
        public string FilePath { get; set; } // FILE_PATH
        public DateTime? LastReadDate { get; set; } // LAST_READ_DATE
        public string MessagePattern { get; set; } // MESSAGE_PATTERN
        public long? LastReadPosition { get; set; } // LAST_READ_POSITION
        public string StartMessagePattern { get; set; } // START_MESSAGE_PATTERN
        public int? CheckingTimeout { get; set; } // CHECKING_TIMEOUT
        public string LastProcessedFile { get; set; } // LAST_PROCESSED_FILE
	}
}
