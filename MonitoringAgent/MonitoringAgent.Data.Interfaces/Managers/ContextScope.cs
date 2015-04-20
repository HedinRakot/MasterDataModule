namespace MonitoringAgent.Data.Interfaces.Managers
{
    /// <summary>
    /// Context scope
    /// </summary>
    public class ContextScope
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ContextScope(string guid)
        {
            Guid = guid;
        }
        /// <summary>
        /// Identifier of context
        /// </summary>
        public string Guid { get; private set; }
    }
}