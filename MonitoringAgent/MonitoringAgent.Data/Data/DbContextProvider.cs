namespace MonitoringAgent.Common.Data
{
    public class DbContextProvider
    {
        public MasterDataMonitoringModelContainer GetContext()
        {
            return new MasterDataMonitoringModelContainer();
        }
    }
}
