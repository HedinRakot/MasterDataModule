using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataSiteInfo
    {
        public int Id { get; set; } // ID (Primary key)
        public string Name { get; set; } // NAME
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING
        public string SitePath { get; set; } // SITE_PATH
	}
}
