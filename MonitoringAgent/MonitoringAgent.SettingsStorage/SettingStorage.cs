using System.Collections.Generic;
using MonitoringAgent.SettingStorage.Contracts;

namespace MonitoringAgent.SettingsStorage
{
    public class SettingStorage: ISettingStorage
    {
        private readonly Dictionary<string, IModuleSettings<BaseSettings>> settings = new Dictionary<string, IModuleSettings<BaseSettings>>();

        public void RegisterSettings(string moduleName, IModuleSettings<BaseSettings> moduleSettings)
        {
            settings.Add(moduleName, moduleSettings);
        }

        public IModuleSettings<BaseSettings> GetSettings(string moduleName)
        {
            return settings[moduleName];
        }
    }
}
