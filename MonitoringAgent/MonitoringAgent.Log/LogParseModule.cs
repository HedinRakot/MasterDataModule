using System.Collections.Generic;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Log
{
    /// <summary>
    /// Module for parse logs
    /// </summary>
    public sealed class LogParseModule : BaseTimerModule<LogTypeAnalyzer>
    {
        private readonly INotificationsModule notificationsModule;
        private readonly IManagersProvider managersProvider;
        private List<MasterDataSubscribers> errorSubscribers = new List<MasterDataSubscribers>();

        /// <summary>
        /// Ctor
        /// </summary>
        public LogParseModule(INotificationsModule notificationsModule,  IManagersProvider managersProvider)
        {
            this.notificationsModule = notificationsModule;
            this.managersProvider = managersProvider;
        }

        /// <summary>
        /// Action which will be invoked when timer elapsed
        /// </summary>
        /// <param name="info">Info about monitorable object which is associated with current timer</param>
        protected override void TimerAction(LogTypeAnalyzer info)
        {
            List<ApplicationLogs> errors;
            info.Analyze(out errors);
            if (errors.Count > 0 && errorSubscribers.Count > 0)
            {
                var reportFactory = new LogReportFactory();
                var report = reportFactory.CreateErrorReport(errors, info.LogTypeInfo);
                notificationsModule.NotifyAboutErrors(errorSubscribers, report);
            }
        }
        /// <summary>
        /// Initialize module
        /// </summary>
        public override  void Initialize()
        {
            var logTypeManager = managersProvider.GetManager<ILogTypeInfoManager>();
            var logTypes = logTypeManager.GetAllEntities().ToList();
            errorSubscribers = notificationsModule.GetAllErrorSubscribers();
            foreach (var logTypeInfo in logTypes)
            {
                AddService(new LogTypeAnalyzer(logTypeInfo, managersProvider), logTypeInfo.FileName, 10000);
            }
        }
    }
}
