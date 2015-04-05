using Microsoft.Practices.Unity;
using MonitoringAgent.Common.Data.Managers;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Job;
using MonitoringAgent.Job.Interfaces;
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
            container.RegisterType<ICheckingModule, WcfServicePingModule>("wcfPing");

            container.RegisterType<ISitePingService, SitePingService>();
            container.RegisterType<ICheckingModule, SitePingModule>("sitePing");

            container.RegisterType<IJobCheckService, JobCheckService>();
            container.RegisterType<ICheckingModule, JobCheckingModule>("jobPing");
        }

        public IUnityContainer Container
        {
            get { return container; }
        }
    }
}
