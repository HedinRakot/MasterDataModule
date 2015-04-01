namespace MonitoringAgent.Data.Interfaces.Managers
{
    public interface IManagersProvider
    {
        T GetManager<T>();
    }
}
