namespace MonitoringAgent.Data.Interfaces.Entities
{
    public interface ICheckServiceInfo
    {
        string Name { get; }
        int TimeoutChecking { get; }
    }
}
