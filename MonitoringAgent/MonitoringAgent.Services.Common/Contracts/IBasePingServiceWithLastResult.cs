namespace MonitoringAgent.Services.Common.Contracts
{
    /// <summary>
    /// Base interface for all ping services
    /// </summary>
    /// <typeparam name="TServiceInfo">Monitorable object info</typeparam>
    /// <typeparam name="TCheckResult">Result of checking</typeparam>
    public interface IBasePingServiceWithLastResult<TServiceInfo, TCheckResult> : IBasePingService<TServiceInfo>
    {
        /// <summary>
        /// Get last result of checking
        /// </summary>
        TCheckResult GetLastResult(int infoId);
        /// <summary>
        /// Saves checking result
        /// </summary>
        void SetCheckingResult(TCheckResult result);
    }
}