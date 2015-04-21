using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public partial class SiteInfosWithLastResult: ISystemFields
    {
		public SiteInfosWithLastResult()
		{
			ChangeDate = CreateDate = DateTime.Now;
		}
        public int Id { get; set; } // ID
        public string Name { get; set; } // NAME
        public DateTime? DeleteDate { get; set; } // DELETE_DATE
        public DateTime CreateDate { get; set; } // CREATE_DATE
        public DateTime ChangeDate { get; set; } // CHANGE_DATE
        public int? LastResult { get; set; } // LAST_RESULT
	}
}
