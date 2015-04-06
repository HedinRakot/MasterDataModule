using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class MasterDataWindowsServiceCheckResults: ISystemFields
    {
		public MasterDataWindowsServiceCheckResults()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID (Primary key)
        public int? CheckStatus { get; set; } // CHECK_STATUS
        public DateTime? CheckDate { get; set; } // CHECK_DATE
        public string Message { get; set; } // MESSAGE
        public int? Attempt { get; set; } // ATTEMPT
        public int MasterDataWindowsServiceInfoId { get; set; } // MASTER_DATA_WINDOWS_SERVICE_INFO_ID
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
	}
}
