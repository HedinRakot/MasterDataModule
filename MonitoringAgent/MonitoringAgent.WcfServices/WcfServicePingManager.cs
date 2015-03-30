using System;
using System.Threading;

namespace MonitoringAgent.WcfServices
{
    public class WcfServicePingManager
    {
        private readonly WcfPingService settings;
        private readonly Timer timer;
        
        public WcfServicePingManager(WcfPingService settings)
        {
            this.settings = settings;
            timer = new Timer(TimerElapsed, null, 0, 10000);
        }

        private void TimerElapsed(object state)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);

            var services = settings.GetAllServicesToCheck();
            foreach (var wcfServiceInfo in services)
            {
                var loader = new WcfMetadataLoader(wcfServiceInfo.WsdlPath);
                var result = loader.Ping();
                wcfServiceInfo.LastCheckStatus = (short)(result.Result? 1: 0);
                wcfServiceInfo.LastCheckDate = DateTime.Now;
                wcfServiceInfo.Message = result.Message;
            }
            settings.SetCheckingResults(services);

            timer.Change(0, 1000);
        }
    }
}
