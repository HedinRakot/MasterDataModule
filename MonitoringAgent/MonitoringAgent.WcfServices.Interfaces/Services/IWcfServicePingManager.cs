namespace MonitoringAgent.WcfServices.Interfaces.Services
{
    public interface IWcfServicePingManager
    {
        void StartChecking();
        void StopChecking();
    }
}