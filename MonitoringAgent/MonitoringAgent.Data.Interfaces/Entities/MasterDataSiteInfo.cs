using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataSiteInfo: ISystemFields
    {
		public MasterDataSiteInfo()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public string Name { get; set; } // NAME. DE: Site-Name  EN: Site name
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING. DE: Timeout  EN: Timeout
        public string SitePath { get; set; } // SITE_PATH. DE: Url  EN: Url
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime FromDate { get; set; } // FROM_DATE. DE:Von Datum  EN:  Date from
        public DateTime ToDate { get; set; } // TO_DATE. DE:Bis Datum  EN:  Date to
        public int? LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
