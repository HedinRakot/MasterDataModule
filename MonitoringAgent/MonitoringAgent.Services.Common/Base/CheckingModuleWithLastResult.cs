using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Notifications.Interfaces;

namespace MonitoringAgent.Services.Common.Base
{
    /// <summary>
    /// Checking module with optimization of saing last result
    /// </summary>
    /// <typeparam name="TServiceInfo">Info about monitorable object</typeparam>
    /// <typeparam name="TCheckingResult">Type of result of checking</typeparam>
    public abstract class CheckingModuleWithLastResult<TServiceInfo, TCheckingResult>: CheckingModule<TServiceInfo, TCheckingResult>
        where TServiceInfo : class, ICheckServiceInfo
        where TCheckingResult: class, ICheckResult
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="notficationModule">Notification module</param>
        protected CheckingModuleWithLastResult(INotificationsModule notficationModule)
            : base(notficationModule)
        {
        }
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected sealed override TCheckingResult CheckService(TServiceInfo serviceInfo)
        {
            var result = CheckServiceWithLastResult(serviceInfo);
            var lastResult = LastResultExtractor(serviceInfo);
            if (lastResult != null && result.CheckStatus == lastResult.CheckStatus && result.Message == lastResult.Message)
            {
                lastResult.Attempt++;
                lastResult.CheckDate = result.CheckDate;
                result = lastResult;
            }
            return result;
        }
        /// <summary>
        /// Checks that we need notify
        /// </summary>
        /// <param name="result">Result</param>
        /// <param name="notification">Notification</param>
        protected override bool NeedNotify(TCheckingResult result, MasterDataNotifications notification)
        {
            var currentState = result.Attempt%notification.AlertAttemptCount;
            return currentState == 0 && result.Attempt >= notification.AlertAttemptCount && result.CheckStatus == notification.AlertCheckStatus;
        }
        /// <summary>
        /// Gets previous result of checking
        /// </summary>
        /// <param name="serviceInfo">Info about monitorable object</param>
        protected abstract TCheckingResult LastResultExtractor(TServiceInfo serviceInfo);
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected abstract TCheckingResult CheckServiceWithLastResult(TServiceInfo serviceInfo);


    }
}
