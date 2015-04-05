namespace MonitoringAgent.Data.Interfaces.Enums
{
    /// <summary>
    /// Type of module
    /// </summary>
    public enum CheckModuleType
    {
        /// <summary>
        /// Default value
        /// </summary>
        None = 0,
        /// <summary>
        /// Wcf services
        /// </summary>
        WcfService = 1,
        /// <summary>
        /// Sites
        /// </summary>
        Site = 2,
        /// <summary>
        /// Jobs
        /// </summary>
        Job = 3
    }
}