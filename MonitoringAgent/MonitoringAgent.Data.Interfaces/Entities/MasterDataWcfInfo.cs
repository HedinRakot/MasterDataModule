using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataWcfInfo
    {
        public int Id { get; set; } // ID (Primary key)
        public string Name { get; set; } // NAME
        public string WsdlPath { get; set; } // WSDL_PATH
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING
	}
}
