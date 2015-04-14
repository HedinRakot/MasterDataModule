using System.Configuration;

namespace MonitoringAgent.Services.Common.Helpers
{
    /// <summary>
    /// Static class for working with settings from config
    /// </summary>
    public static class SettingsHelper
    {
        private const string HubUrlSettingName = "hubUrl";
        private const string HubNameSettingName = "hubName";

        /// <summary>
        /// Gets hub url
        /// </summary>
        public static string HubUrl
        {
            get { return ConfigurationManager.AppSettings[HubUrlSettingName]; }
        }
        /// <summary>
        /// Gets hub name
        /// </summary>
        public static string HubName
        {
            get { return ConfigurationManager.AppSettings[HubNameSettingName]; }
        }
    }
}
