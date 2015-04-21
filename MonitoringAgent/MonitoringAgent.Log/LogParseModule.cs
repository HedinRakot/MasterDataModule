using System.Linq;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Log
{
    /// <summary>
    /// Module for parse logs
    /// </summary>
    public class LogParseModule : BaseTimerModule<LogTypeAnalyzer>
    {
        private readonly IManagersProvider managersProvider;
        /// <summary>
        /// Ctor
        /// </summary>
        public LogParseModule(IManagersProvider managersProvider)
        {
            this.managersProvider = managersProvider;
        }
        /// <summary>
        /// Action which will be invoked when timer elapsed
        /// </summary>
        /// <param name="info">Info about monitorable object which is associated with current timer</param>
        protected override void TimerAction(LogTypeAnalyzer info)
        {
            info.Analyze();
        }
        /// <summary>
        /// Initialize module
        /// </summary>
        public override  void Initialize()
        {
            var logTypeManager = managersProvider.GetManager<ILogTypeInfoManager>();
            var logTypes = logTypeManager.GetAllEntities().ToList();
            foreach (var logTypeInfo in logTypes)
            {
                AddService(new LogTypeAnalyzer(logTypeInfo, managersProvider), logTypeInfo.FileName, 10000);
            }
        }
    }
}
