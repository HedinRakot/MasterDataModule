using System.Collections.Generic;
using MonitoringAgent.SettingStorage.Contracts;

namespace MonitoringAgent.WcfServices.Settings
{
    public class WcfServiceSettings: BaseSettings
    {
        List<string> checkableServices = new List<string>(); 
    }
}
