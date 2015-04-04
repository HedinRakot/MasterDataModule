using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;

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
        /// <param name="notificationService">Notification service</param>
        protected CheckingModuleWithLastResult(INotificationService notificationService)
            : base(notificationService)
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
            return result.Attempt == notification.AlertAttemptCount && result.CheckStatus == notification.AlertCheckStatus;
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
