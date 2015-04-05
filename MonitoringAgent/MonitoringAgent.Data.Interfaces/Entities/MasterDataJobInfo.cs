using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataJobInfo
    {
        public int Id { get; set; } // ID (Primary key)
        public string ConnectionString { get; set; } // CONNECTION_STRING
        public string TableName { get; set; } // TABLE_NAME
        public int TimeoutChecking { get; set; } // TIMEOUT_CHECKING
        public string Name { get; set; } // NAME
        public string JobName { get; set; } // JOB_NAME
	}
}