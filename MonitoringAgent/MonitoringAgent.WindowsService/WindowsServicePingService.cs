using System;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceProcess;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.WindowsService.Interfaces;

namespace MonitoringAgent.WindowsService
{
    /// <summary>
    /// Service for working with Windows services
    /// </summary>
    internal sealed class WindowsServicePingService : BasePingServiceWithLastResultWithLastResult<IMasterDataWindowsServiceInfoManager, MasterDataWindowsServiceInfo, IMasterDataWindowsServiceCheckResultsManager, MasterDataWindowsServiceCheckResults>, IWindowsServicePingService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managersProvider">Manager provider</param>
        public WindowsServicePingService(IManagersProvider managersProvider) : base(managersProvider)
        {
        }
        /// <summary>
        /// Gets id of info
        /// </summary>
        protected override Expression<Func<MasterDataWindowsServiceCheckResults, int>> InfoIdExtractor
        {
            get { return results => results.MasterDataWindowsServiceInfoId; }
        }

        /// <summary>
        /// Check windows service
        /// </summary>
        /// <param name="serviceInfo">Service info</param>
        /// <returns></returns>
        public MasterDataWindowsServiceCheckResults CheckService(MasterDataWindowsServiceInfo serviceInfo)
        {
            var result = new MasterDataWindowsServiceCheckResults {CheckDate = DateTime.Now, MasterDataWindowsServiceInfoId = serviceInfo.Id, Attempt = 1};
            try
            {
                var services = ServiceController.GetServices(serviceInfo.MachineName);
                var service = services.First(s => s.ServiceName == serviceInfo.ServiceName);
                if (service != null)
                {
                    if (service.Status == ServiceControllerStatus.Running || service.Status == ServiceControllerStatus.StartPending)
                    {
                        result.CheckStatus = 1;
                    }
                    else
                    {
                        result.CheckStatus = 0;
                        result.Message = string.Format("Service status: {0}", service.Status);
                    }
                }
                else
                {
                    result.CheckStatus = 0;
                    result.Message = "Service unavaliable";
                }
            }
            catch (Exception ex)
            {
                result.CheckStatus = 0;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
