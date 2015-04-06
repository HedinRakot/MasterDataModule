using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public interface ISystemFields
    {
        DateTime CreateDate { get; set; } // CREATE_DATE
        DateTime? DeleteDate { get; set; } // DELETE_DATE
        DateTime ChangeDate { get; set; } // CHANGE_DATE
    }
}
