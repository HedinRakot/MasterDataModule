namespace MonitoringAgent.Services.Common.Contracts
{
    public interface ICheckingModule
    {
        void Initialize();
        void Reinitialize();
        void StartAllChecks();
        void StopAllChecks();
    }
}
