using System;
using System.Threading;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    public class WcfServicePingManager : ICheckingService
    {
        private readonly IWcfPingService service;
        private readonly Timer timer;
        
        public WcfServicePingManager(IWcfPingService service)
        {
            this.service = service;
            timer = new Timer(TimerElapsed, null, Timeout.Infinite, Timeout.Infinite);
        }

        public void StartChecking()
        {
            timer.Change(10000, 10000);
        }

        public void StopChecking()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void TimerElapsed(object state)
        {
            StopChecking();

            var services = service.GetAllServicesToCheck();
            foreach (var wcfServiceInfo in services)
            {
                var loader = new WcfMetadataLoader(wcfServiceInfo.WsdlPath);
                var result = loader.Ping();
                var lastResult = service.GetLastResult(wcfServiceInfo.Id);
                if (lastResult != null && ((lastResult.CheckStatus == 1 && result.Result) || (lastResult.CheckStatus == 0 && !result.Result)))
                {
                    lastResult.Attempt++;
                    lastResult.CheckDate = DateTime.Now;
                }
                else
                {
                    lastResult = new WcfServiceInfoCheckResult
                    {
                        Attempt = 1,
                        CheckDate = DateTime.Now,
                        WcfServiceInfoId = wcfServiceInfo.Id,
                        CheckStatus = result.Result ? 1 : 0,
                        Message = result.Message,
                    };
                }

                service.SetCheckingResult(lastResult);
            }

            StartChecking();
        }
    }
}
