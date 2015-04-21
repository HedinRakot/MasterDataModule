using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataSubscribers: ISystemFields
    {
		public MasterDataSubscribers()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public string Email { get; set; } // EMAIL. DE: E-mail  EN: E-mail
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
        public bool? ReportAboutErrorLog { get; set; } // REPORT_ABOUT_ERROR_LOG
	}
}
