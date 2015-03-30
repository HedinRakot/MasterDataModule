namespace MonitoringAgent.SettingStorage.Contracts
{
    public interface ISettingStorage
    {
        void RegisterSettings(string moduleName, IModuleSettings<BaseSettings> moduleSettings);

        IModuleSettings<BaseSettings> GetSettings(string moduleName);

    }
}
