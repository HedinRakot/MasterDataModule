using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class GetWinServicesStatus: ISystemFields
    {
		public GetWinServicesStatus()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID
        public int? CheckStatus { get; set; } // CHECK_STATUS
        public DateTime? CheckDate { get; set; } // CHECK_DATE
        public string Message { get; set; } // MESSAGE
        public int? Attempt { get; set; } // ATTEMPT
        public string Name { get; set; } // NAME
        public string MachineName { get; set; } // MACHINE_NAME
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public int? LogTypeInfoId { get; set; } // LOG_TYPE_INFO_ID
	}
}
