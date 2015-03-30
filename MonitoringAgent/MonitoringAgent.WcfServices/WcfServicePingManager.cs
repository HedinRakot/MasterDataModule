using System;
using System.Threading;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent.WcfServices
{
    public class WcfServicePingManager : IWcfServicePingManager
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
                wcfServiceInfo.LastCheckStatus = (short)(result.Result? 1: 0);
                wcfServiceInfo.LastCheckDate = DateTime.Now;
                wcfServiceInfo.Message = result.Message;
            }
            service.SetCheckingResults(services);

            StartChecking();
        }
    }
}
