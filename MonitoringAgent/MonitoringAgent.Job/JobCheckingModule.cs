﻿using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Enums;
using MonitoringAgent.Notifications.Interfaces;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Job
{
    /// <summary>
    /// Module for checking jobs
    /// </summary>
    internal sealed class JobCheckingModule : CheckingModule<MasterDataJobInfo, MasterDataJobCheckResults>
    {
        private readonly JobCheckService jobCheckService;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="jobCheckService">Job service</param>
        /// <param name="notificationModule">Notification module</param>
        public JobCheckingModule(JobCheckService jobCheckService, INotificationsModule notificationModule)
            : base(notificationModule)
        {
            this.jobCheckService = jobCheckService;
        }
        /// <summary>
        /// Gets all monitorable objects for checking
        /// </summary>
        /// <returns>List of monitorble objects</returns>
        protected override IList<MasterDataJobInfo> ServiceExtractor()
        {
            return jobCheckService.GetAllInfos();
        }
        /// <summary>
        /// Checks monitorable object
        /// </summary>
        /// <param name="serviceInfo">Monitorable object info</param>
        protected override MasterDataJobCheckResults CheckService(MasterDataJobInfo serviceInfo)
        {
            return jobCheckService.CheckJob(serviceInfo);
        }
        /// <summary>
        /// Save results of checking
        /// </summary>
        /// <param name="result">Result</param>
        protected override void SaveCheckingResult(MasterDataJobCheckResults result)
        {
            jobCheckService.SaveResults(result);
        }
        /// <summary>
        /// Module type
        /// </summary>
        protected override CheckModuleType CheckModuleType
        {
            get { return CheckModuleType.Job; }
        }
        /// <summary>
        /// Checks that we need notify
        /// </summary>
        /// <param name="result">Result</param>
        /// <param name="notification">Notification</param>
        protected override bool NeedNotify(MasterDataJobCheckResults result, MasterDataNotifications notification)
        {
            return result == null;
        }
    }
}
