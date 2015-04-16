namespace MonitoringAgent.Data.Interfaces.Entities
{
    /// <summary>
    /// Interface for check results
    /// </summary>
    public interface IHasCheckStatus
    {
        /// <summary>
        /// Check status
        /// </summary>
        int? CheckStatus { get; set; }
    }
}
