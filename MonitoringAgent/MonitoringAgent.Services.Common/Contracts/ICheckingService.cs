namespace MonitoringAgent.Services.Common.Contracts
{
    public interface ICheckingService
    {
        void StartChecking();
        void StopChecking();
    }
}
