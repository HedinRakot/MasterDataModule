namespace MonitoringAgent.Data.Interfaces.Managers
{
    /// <summary>
    /// Provides managers
    /// </summary>
    public interface IManagersProvider
    {
        /// <summary>
        /// Gets manager
        /// </summary>
        /// <typeparam name="T">Type of manager</typeparam>
        T GetManager<T>(ContextScope scope = null);
        /// <summary>
        /// Begin scope
        /// </summary>
        ContextScope BeginScope();

        /// <summary>
        /// End scope
        /// </summary>
        void EndScope(ContextScope scope);
    }
}
