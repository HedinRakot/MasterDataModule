using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Services.Common.Base
{
    public abstract class BaseManagersService
    {
        private readonly IManagersProvider managersProvider;

        protected BaseManagersService(IManagersProvider managersProvider)
        {
            this.managersProvider = managersProvider;
        }
        protected IManagersProvider ManagersProvider
        {
            get { return managersProvider; }
        }
    }
}
