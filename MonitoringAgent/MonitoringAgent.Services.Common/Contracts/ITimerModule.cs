namespace MonitoringAgent.Services.Common.Contracts
{
    public interface ITimerModule
    {
        /// <summary>
        /// Initialize module
        /// </summary>
        void Initialize();
        /// <summary>
        /// Reinitialize module
        /// </summary>
        void Reinitialize();
        /// <summary>
        /// Starts all checkings
        /// </summary>
        void StartAllChecks();
        /// <summary>
        /// Stops all checkings
        /// </summary>
        void StopAllChecks();
    }
}
