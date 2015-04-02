using System;
using System.Linq;
using System.Threading;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common.Services
{
    public sealed class ConfigurationService : BaseManagersService, IConfigurationService
    {
        private readonly Timer timer;

        public event EventHandler NeedReconfigure;

        public ConfigurationService(IManagersProvider managerProvider): base(managerProvider)
        {
            timer = new Timer(state => TimerElapsed(), null, Timeout.Infinite, Timeout.Infinite);
        }

        public void Initialize()
        {
            var state = GetState();
            timer.Change(state.ReconfigureCheckingTimeout, state.ReconfigureCheckingTimeout);
        }

        private void TimerElapsed()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            var state = GetState();
            if (state.Reconfigure.HasValue && state.Reconfigure.Value)
            {
                OnNeedReconfigure();
            }
            timer.Change(state.ReconfigureCheckingTimeout, state.ReconfigureCheckingTimeout);
        }

        private MasterDataMonitorState GetState()
        {
            var stateManager = ManagersProvider.GetManager<IMasterDataMonitorStateManager>();
            return stateManager.GetAllEntities().First();
        }

        private void OnNeedReconfigure()
        {
            if (NeedReconfigure != null)
            {
                NeedReconfigure(this, EventArgs.Empty);
                MarkReconfigureAsRead();
            }
        }

        private void MarkReconfigureAsRead()
        {
            var stateManager = ManagersProvider.GetManager<IMasterDataMonitorStateManager>();
            var state = GetState();
            state.Reconfigure = false;
            stateManager.AddOrUpdateEntities(new[] {state});
            stateManager.SaveChanges();
        }
    }
}
