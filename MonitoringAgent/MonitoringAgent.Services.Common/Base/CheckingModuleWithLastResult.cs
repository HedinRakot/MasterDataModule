using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Services.Common.Base
{
    public abstract class CheckingModuleWithLastResult<TServiceInfo, TCheckingResult>: CheckingModule<TServiceInfo, TCheckingResult>
        where TServiceInfo : class, ICheckServiceInfo
        where TCheckingResult: class, ICheckResult
    {
        protected sealed override void SaveCheckingResult(TCheckingResult result, TServiceInfo info)
        {
            var lastResult = LastResultExtractor(info);
            if (lastResult != null && result.CheckStatus == lastResult.CheckStatus && result.Message == lastResult.Message)
            {
                lastResult.Attempt++;
                lastResult.CheckDate = result.CheckDate;
                result = lastResult;
            }
            SaveResult(result);
        }

        protected abstract void SaveResult(TCheckingResult result);

        protected abstract TCheckingResult LastResultExtractor(TServiceInfo serviceInfo);
    }
}
