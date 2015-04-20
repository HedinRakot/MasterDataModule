using System.Collections.Generic;
using System.Threading;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common.Base
{
    /// <summary>
    /// Base class for modules with timer functionallity
    /// </summary>
    /// <typeparam name="TObjectInfo">Information about monitoable object</typeparam>
    public abstract class BaseTimerModule<TObjectInfo> : ITimerModule
    {
        readonly Dictionary<string, TimerContainer<TObjectInfo>> checkServices = new Dictionary<string, TimerContainer<TObjectInfo>>();

        private void TimerElapsed(object state)
        {
            var serviceName = state as string;
            TimerContainer<TObjectInfo> info;
            if (!string.IsNullOrEmpty(serviceName) && checkServices.TryGetValue(serviceName, out info))
            {
                var timer = info.Timer;
                timer.Change(Timeout.Infinite, Timeout.Infinite);

                TimerAction(info.Info, info.Notifications);
    
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
        /// Add timer for monitorable object
        /// </summary>
        /// <param name="objectInfo">Info about object</param>
        /// <param name="name">Name</param>
        /// <param name="timeout">Timeout for timer settings</param>
        /// <param name="notifications">List of notifications</param>
        protected void AddService(TObjectInfo objectInfo, string name, int timeout, List<MasterDataNotifications> notifications = null)
        {
            var info = new TimerContainer<TObjectInfo>
            {
                Notifications = notifications ?? new List<MasterDataNotifications>(),
                Info = objectInfo,
                Timeout = timeout,
                Timer = new Timer(TimerElapsed, name, Timeout.Infinite, Timeout.Infinite)
            };

            checkServices.Add(name, info);
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
        /// Action which will be invoked when timer elapsed
        /// </summary>
        /// <param name="info">Info about monitorable object which is associated with current timer</param>
        /// <param name="notifications">List of notifications for monitorable object</param>
        protected abstract void TimerAction(TObjectInfo info, List<MasterDataNotifications> notifications);
        /// <summary>
        /// Initialize module
        /// </summary>
        public abstract void Initialize();

        #region Nested Types
        private class TimerContainer<TObjectInfo>
        {
            private readonly object syncObject = new object();

            public TObjectInfo Info { get; set; }
            public List<MasterDataNotifications> Notifications { get; set; }
            public int Timeout { get; set; }
            public Timer Timer { get; set; }
            public object SyncObject
            {
                get { return syncObject; }
            }
            public bool CanStart { get; set; }
        }
        #endregion Nested Types
    }
}
