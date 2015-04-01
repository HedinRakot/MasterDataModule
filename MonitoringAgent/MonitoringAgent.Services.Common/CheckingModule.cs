using System.Collections.Generic;
using System.Threading;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common
{
    public abstract class CheckingModule<TServiceInfo, TCheckingResult> : ICheckingModule
        where TServiceInfo : class, ICheckServiceInfo
        where TCheckingResult: class, ICheckResult
    {
        readonly Dictionary<string, ServiceInfo> checkServices = new Dictionary<string, ServiceInfo>(); 

        private void AddService(TServiceInfo serviceInfo, string name, int timeout)
        {
            var info = new ServiceInfo
            {
                Info = serviceInfo,
                Name = name,
                Timeout = timeout,
                Timer = new Timer(TimerElapsed, name, Timeout.Infinite, Timeout.Infinite)
            };

            checkServices.Add(name, info);
        }

        private void TimerElapsed(object state)
        {
            var serviceName = state as string;
            ServiceInfo info;
            if (!string.IsNullOrEmpty(serviceName) && checkServices.TryGetValue(serviceName, out info))
            {
                var timer = info.Timer;
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                var checkingResult = CheckService(info.Info);

                var lastResult = LastResultExtractor(info.Info);
                if (lastResult != null && checkingResult.CheckStatus == lastResult.CheckStatus && checkingResult.Message == lastResult.Message)
                {
                    lastResult.Attempt++;
                    lastResult.CheckDate = checkingResult.CheckDate;
                    checkingResult = lastResult;
                }
                SaveCheckingResult(checkingResult);

                lock (info.SyncObject)
                {
                    if (info.CanStart)
                    {
                        timer.Change(info.Timeout, info.Timeout);
                    }
                }
            }
        }

        public void Initialize()
        {
            var services = ServiceExtractor();
            foreach (var service in services)
            {
                AddService(service, service.Name, service.TimeoutChecking);
            }
        }

        public void StartAllChecks()
        {
            foreach (var value in checkServices.Values)
            {
                lock (value.SyncObject)
                {
                    value.CanStart = true;
                    value.Timer.Change(value.Timeout, value.Timeout);
                }
            }
        }

        public void StopAllChecks()
        {
            foreach (var value in checkServices.Values)
            {
                lock (value.SyncObject)
                {
                    value.CanStart = false;
                    value.Timer.Change(Timeout.Infinite, Timeout.Infinite);
                }
            }
        }

        protected abstract IList<TServiceInfo> ServiceExtractor();

        protected abstract TCheckingResult LastResultExtractor(TServiceInfo serviceInfo);

        protected abstract TCheckingResult CheckService(TServiceInfo serviceInfo);

        protected abstract void SaveCheckingResult(TCheckingResult result);

        #region Nested types

        private class ServiceInfo
        {
            private readonly object syncObject = new object();

            public TServiceInfo Info { get; set; }
            public string Name { get; set; }
            public int Timeout { get; set; }
            public Timer Timer { get; set; }
            public object SyncObject
            {
                get { return syncObject; }
            }
            public bool CanStart { get; set; }
        }

        #endregion Nested types

    }
}
