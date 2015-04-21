using Microsoft.Practices.Unity;
using MonitoringAgent.Common.Data.Managers;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Job;
using MonitoringAgent.Job.Interfaces;
using MonitoringAgent.Log;
using MonitoringAgent.Notifications;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Notifications.Interfaces.Services;
using MonitoringAgent.Notifications.Services;
using MonitoringAgent.Services.Common.Contracts;
using MonitoringAgent.Services.Common.Services;
using MonitoringAgent.Site;
using MonitoringAgent.Site.Interfaces.Services;
using MonitoringAgent.WcfServices;
using MonitoringAgent.WcfServices.Interfaces.Services;
using MonitoringAgent.WindowsService;
using MonitoringAgent.WindowsService.Interfaces;

namespace MonitoringAgent.Configuration
{
    public partial class Configuration
    {
        readonly IUnityContainer container = new UnityContainer();

        public void Initialize()
        {
            container.RegisterType<IManagersProvider, ManagersProvider>(new PerResolveLifetimeManager());
            container.RegisterType<IConfigurationService, ConfigurationService>();

            container.RegisterType<INotificationService, NotificationService>();
            container.RegisterType<ISubscribersService, SubscribersService>();
            container.RegisterType<INotificationsModule, NotificationsModule>();
            container.RegisterType<IMailNotificationSendService, MailNotificationSendService>();

            container.RegisterType<IWcfPingService, WcfPingService>();
            container.RegisterType<ITimerModule, WcfServicePingModule>("wcfPing");

            container.RegisterType<ISitePingServiceWithLastResult, SitePingServiceWithLastResult>();
            container.RegisterType<ITimerModule, SitePingModule>("sitePing");

            container.RegisterType<IJobCheckService, JobCheckService>();
            container.RegisterType<ITimerModule, JobCheckingModule>("jobPing");

            container.RegisterType<IWindowsServicePingService, WindowsServicePingService>();
            container.RegisterType<ITimerModule, WindowsServiceCheckingModule>("winServicePing");

            container.RegisterType<ITimerModule, LogParseModule>("logCheckModule");
        }

        public IUnityContainer Container
        {
            get { return container; }
        }
    }
}
