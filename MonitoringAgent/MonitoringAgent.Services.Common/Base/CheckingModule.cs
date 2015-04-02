using System.Collections.Generic;
using System.Threading;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common.Base
{
    public abstract class CheckingModule<TServiceInfo, TCheckingResult> : ICheckingModule
        where TServiceInfo : class, ICheckServiceInfo
    {
        readonly Dictionary<string, ServiceInfo> checkServices = new Dictionary<string, ServiceInfo>(); 

        private void AddService(TServiceInfo serviceInfo, string name, int timeout)
        {
            var info = new ServiceInfo
            {
                Info = serviceInfo,
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

                SaveCheckingResult(checkingResult, info.Info);

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

        public void Reinitialize()
        {
            foreach (var checkService in checkServices.Values)
            {
                lock (checkService.SyncObject)
                {
                    checkService.Timer.Change(Timeout.Infinite, Timeout.Infinite);
                    checkService.Timer.Dispose();
                    checkService.Timer = null;
                    checkService.CanStart = false;
                }
            }
            checkServices.Clear();
            Initialize();
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

        protected abstract TCheckingResult CheckService(TServiceInfo serviceInfo);

        protected abstract void SaveCheckingResult(TCheckingResult result, TServiceInfo info);

        #region Nested types

        private class ServiceInfo
        {
            private readonly object syncObject = new object();

            public TServiceInfo Info { get; set; }
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
