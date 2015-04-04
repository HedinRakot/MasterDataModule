namespace MonitoringAgent.Data.Interfaces.Entities
{
    public interface ICheckServiceInfo
    {
        int Id { get; }
        string Name { get; }
        int TimeoutChecking { get; }
    }
}
