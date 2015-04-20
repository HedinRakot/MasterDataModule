using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class GetSitesStatus: ISystemFields
    {
		public GetSitesStatus()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID
        public int? CheckStatus { get; set; } // CHECK_STATUS
        public DateTime? CheckDate { get; set; } // CHECK_DATE
        public string Message { get; set; } // MESSAGE
        public int? Attempt { get; set; } // ATTEMPT
        public string Name { get; set; } // NAME
        public string SitePath { get; set; } // SITE_PATH
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public int? LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
