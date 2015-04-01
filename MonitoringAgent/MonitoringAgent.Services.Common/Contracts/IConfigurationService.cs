using System;

namespace MonitoringAgent.Services.Common.Contracts
{
    public interface IConfigurationService
    {
        event EventHandler NeedReconfigure;
        void Initialize();
    }
}