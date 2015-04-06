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
        public string Name { get; set; } // NAME
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING
        public string SitePath { get; set; } // SITE_PATH
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
	}
}
