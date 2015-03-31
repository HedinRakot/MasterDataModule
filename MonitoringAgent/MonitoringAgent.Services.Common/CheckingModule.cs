using System.Collections.Generic;
using System.Threading;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common
{
    public abstract class CheckingModule<TServiceInfo, TCheckingResult> : ICheckingModule
        where TServiceInfo : class
        where TCheckingResult: class
    {
        readonly Dictionary<string, Timer> checkTimers = new Dictionary<string, Timer>(); 

        protected void AddService(TServiceInfo serviceInfo, string name, int timeout)
        {
            var info = new ServiceInfo
            {
                Info = serviceInfo,
                Name = name,
                Timeout = timeout
            };

            var timer = new Timer(TimerElapsed, info, Timeout.Infinite, Timeout.Infinite);
            checkTimers.Add(name, timer);
            timer.Change(timeout, timeout);
        }

        private void TimerElapsed(object state)
        {
            var info = state as ServiceInfo;
            if (info != null)
            {
                var timer = checkTimers[info.Name];
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                var checkingResult = CheckService(info.Info);
                SaveCheckingResult(checkingResult);
                timer.Change(info.Timeout, info.Timeout);
            }
        }

        public void Initialize()
        {
            RegisterServices();
        }

        protected abstract void RegisterServices();

        protected abstract TCheckingResult CheckService(TServiceInfo serviceInfo);

        protected abstract void SaveCheckingResult(TCheckingResult result);

        #region Nested types

        private class ServiceInfo
        {
            public TServiceInfo Info { get; set; }
            public string Name { get; set; }
            public int Timeout { get; set; }
        }

        #endregion Nested types

    }
}
