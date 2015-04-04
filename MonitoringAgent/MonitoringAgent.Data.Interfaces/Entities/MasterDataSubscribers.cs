using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataSubscribers
    {
        public int Id { get; set; } // ID (Primary key)
        public string Email { get; set; } // EMAIL
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
	}
}
