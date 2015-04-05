using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataWcfInfo
    {
        public int Id { get; set; } // ID (Primary key)
        public string Name { get; set; } // NAME
        public string WsdlPath { get; set; } // WSDL_PATH
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
	}
}
