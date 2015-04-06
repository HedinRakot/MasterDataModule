using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Services.Common.Base
{
    /// <summary>
    /// Base class for services which monitor objects and compare result with previous before save it.
    /// </summary>
    /// <typeparam name="TManager">Manager for get info about monitorable objects</typeparam>
    /// <typeparam name="TServiceInfo">Type of monitorable objects</typeparam>
    /// <typeparam name="TResultManager">Manager for gets checking results</typeparam>
    /// <typeparam name="TCheckResult">Checking result</typeparam>
    public abstract class BasePingServiceWithLastResultWithLastResult<TManager, TServiceInfo, TResultManager, TCheckResult>:
        BasePingService<TManager, TServiceInfo>, IBasePingServiceWithLastResult<TServiceInfo, TCheckResult> 
        where TManager: IBaseManager<TServiceInfo> where TServiceInfo : class
        where TResultManager : IBaseManager<TCheckResult> where TCheckResult : class, ICheckResult
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="managersProvider">Provides managers</param>
        protected BasePingServiceWithLastResultWithLastResult(IManagersProvider managersProvider) : base(managersProvider)
        {
        }

        /// <summary>
        /// Get last result of checking
        /// </summary>
        public TCheckResult GetLastResult(int infoId)
        {
            var manager = ManagersProvider.GetManager<TResultManager>();
            
            var item = Expression.Parameter(typeof(TCheckResult), "result");
            var body = (MemberExpression)InfoIdExtractor.Body;
            
            var prop = Expression.Property(item, body.Member.Name);
            var soap = Expression.Constant(infoId);
            var equal = Expression.Equal(prop, soap);
            var lambda = Expression.Lambda<Func<TCheckResult, bool>>(equal, item);

            return manager.GetAllEntities().Where(lambda).OrderByDescending(r => r.CheckDate).FirstOrDefault();
        }
        /// <summary>
        /// Saves checking result
        /// </summary>
        public void SetCheckingResult(TCheckResult result)
        {
            var serviceInfoCheckResultManager = ManagersProvider.GetManager<TResultManager>();
            serviceInfoCheckResultManager.AddOrUpdateEntities(new[] { result });
            serviceInfoCheckResultManager.SaveChanges();
        }
        /// <summary>
        /// Gets id of info
        /// </summary>
        protected abstract Expression<Func<TCheckResult, int>> InfoIdExtractor { get; }
    }
}
