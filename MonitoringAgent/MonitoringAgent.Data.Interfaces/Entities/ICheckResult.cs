using System;

namespace MonitoringAgent.Data.Interfaces.Entities
{
    public interface ICheckResult : IHasCheckStatus
    {
        DateTime? CheckDate { get; set; }
        string Message { get; set; }
        int? Attempt { get; set; }
    }
}
