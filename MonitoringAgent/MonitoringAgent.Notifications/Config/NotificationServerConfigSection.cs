using System.Configuration;
using System.Reflection;

namespace MonitoringAgent.Notifications.Config
{
    /// <summary>
    /// Configuration settings for smtp server for notification server
    /// </summary>
    public class NotificationServerConfigSection : ConfigurationSection
    {
        private static NotificationServerConfigSection settings;

        private const string SmtpServerSettingName = "SmtpServer";
        private const string SmtpServerAccountSettingName = "SmtpServerAccountName";
        private const string SmtpServerAccountPasswordSettingName = "SmtpServerAccountPassword";
        private const string SectionName = "notificationServer";

        /// <summary>
        /// Smtp server path
        /// </summary>
        [ConfigurationProperty(SmtpServerSettingName, IsRequired = true)]
        public string SmtpServer
        {
            get { return this[SmtpServerSettingName] as string; }
            set { this[SmtpServerSettingName] = value; }
        }
        /// <summary>
        /// Account name
        /// </summary>
        [ConfigurationProperty(SmtpServerAccountSettingName, IsRequired = true)]
        public string SmtpServerAccountName
        {
            get { return this[SmtpServerAccountSettingName] as string; }
            set { this[SmtpServerAccountSettingName] = value; }
        }
        /// <summary>
        /// Password
        /// </summary>
        [ConfigurationProperty(SmtpServerAccountPasswordSettingName, IsRequired = true)]
        public string SmtpServerAccountPassword
        {
            get { return this[SmtpServerAccountPasswordSettingName] as string; }
            set { this[SmtpServerAccountPasswordSettingName] = value; }
        }

        /// <summary>
        /// Gets instance of config section
        /// </summary>
        public static NotificationServerConfigSection Instance
        {
            get
            {
                if (settings == null)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location);
                    settings = (NotificationServerConfigSection) config.GetSection(SectionName);
                }
                return settings;
            }
        }
    }
}
