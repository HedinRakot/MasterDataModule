﻿
using System;

namespace MasterDataModule.Contracts.Entities.Monitor
{
    public partial class JobStatus : IHasId<int>, IRemovable, ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.GET_JOBS_STATUS";

        #region Fields

        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID'  </summary>
            public static readonly string Id = "ID";

            /// <summary>
            /// Column name 'CHECK_STATUS'  </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";

            /// <summary>
            /// Column name 'CHECK_DATE' 
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";

            /// <summary>
            /// Column name 'LAST_RUN_TIME' 
            /// </summary>
            public static readonly string LastRunTime = "LAST_RUN_TIME";
            

            /// <summary>
            /// Column name 'NAME' 
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'JOB_NAME' 
            /// </summary>
            public static readonly string JobName = "JOB_NAME";

            /// <summary>
            /// Column name 'LOG_TYPE_INFO_ID' 
            /// </summary>
            public static readonly string LogTypeInfoId = "LOG_TYPE_INFO_ID";

            public static readonly string DeleteDate = "DELETE_DATE";
            public static readonly string CreateDate = "CREATE_DATE";
            public static readonly string ChangeDate = "CHANGE_DATE";


           
        }

        #endregion

        public int Id { get; set; }

        public int? CheckStatus { get; set; }

        public int? LogTypeInfoId { get; set; }

        public DateTime? CheckDate { get; set; }

        public DateTime? LastRunTime { get; set; }
       
        public string Name { get; set; }
        public string JobName { get; set; }
        public DateTime? DeleteDate { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public JobStatus ShallowCopy()
        {
            return new JobStatus
            {
                Name = Name,
                CheckDate = CheckDate,
                CheckStatus = CheckStatus,
                LastRunTime = LastRunTime,
                JobName = JobName,
                LogTypeInfoId = LogTypeInfoId
            };
        }

       
    }
}

