using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common.Base
{
    /// <summary>
    /// Base class for all checking modules
    /// </summary>
    /// <typeparam name="TServiceInfo">Info about monitorable object</typeparam>
    /// <typeparam name="TCheckingResult">Type of result</typeparam>
    public abstract class CheckingModule<TServiceInfo, TCheckingResult> : ICheckingModule
        where TServiceInfo : class, ICheckServiceInfo
    {
        private readonly INotificationsModule notificationsModule;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="notificationsModule">Module for get info about notifications </param>
        protected CheckingModule(INotificationsModule notificationsModule)
        {
            this.notificationsModule = notificationsModule;
        }

        readonly Dictionary<string, ServiceInfo> checkServices = new Dictionary<string, ServiceInfo>(); 

        private void AddService(TServiceInfo serviceInfo, string name, int timeout, List<MasterDataNotifications> notifications)
        {
            var info = new ServiceInfo
            {
                Notifications = notifications ?? new List<MasterDataNotifications>(),
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

                if (info.Notifications.Count > 0)
                {
                    foreach (var notification in info.Notifications)
                    {
                        if (NeedNotify(checkingResult, notification))
                        {
                            notificationsModule.Notify(notification);
                        }
                    }
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

        /// <summary>
        /// Initialize module
        /// </summary>
        public void Initialize()
        {
            var services = ServiceExtractor();
            var notifications = notificationsModule.GetAllNotifications(services.Select(s => s.Id).ToList(), CheckModuleType);

            foreach (var service in services)
            {
                List<MasterDataNotifications> serviceNotifications;
                notifications.TryGetValue(service.Id, out serviceNotifications);
                AddService(service, service.Name, service.TimeoutChecking, serviceNotifications);
            }
        }


        /// <summary>
        /// Reinitialize module
        /// </summary>
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

        /// <summary>
        /// Starts all checkings
        /// </summary>
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

        /// <summary>
        /// Stops all checkings
        /// </summary>
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

        /// <summary>
        /// Gets all monitorable objects for checking
        /// </summary>
        /// <returns>List of monitorble objects</returns>
        protected abstract IList<TServiceInfo> ServiceExtractor();
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected abstract TCheckingResult CheckService(TServiceInfo serviceInfo);
        /// <summary>
        /// Save results of checking
        /// </summary>
        /// <param name="result">Result</param>
        protected abstract void SaveCheckingResult(TCheckingResult result);
        /// <summary>
        /// Module type
        /// </summary>
        protected abstract CheckModuleType CheckModuleType { get; }
        /// <summary>
        /// Checks that we need notify
        /// </summary>
        /// <param name="result">Result</param>
        /// <param name="notification">Notification</param>
        protected abstract bool NeedNotify(TCheckingResult result, MasterDataNotifications notification);

        #region Nested types

        private class ServiceInfo
        {
            private readonly object syncObject = new object();

            public TServiceInfo Info { get; set; }
            public int Timeout { get; set; }
            public List<MasterDataNotifications> Notifications { get; set; }
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
