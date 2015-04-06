using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class GetWcfServicesStatus: ISystemFields
    {
		public GetWcfServicesStatus()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID
        public int? CheckStatus { get; set; } // CHECK_STATUS
        public DateTime? CheckDate { get; set; } // CHECK_DATE
        public string Message { get; set; } // MESSAGE
        public int? Attempt { get; set; } // ATTEMPT
        public string Name { get; set; } // NAME
        public string WsdlPath { get; set; } // WSDL_PATH
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
	}
}
