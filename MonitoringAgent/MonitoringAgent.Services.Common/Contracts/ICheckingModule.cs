namespace MonitoringAgent.Services.Common.Contracts
{
    public interface ICheckingModule
    {
        void Initialize();
        void StartAllChecks();
        void StopAllChecks();
    }
}
