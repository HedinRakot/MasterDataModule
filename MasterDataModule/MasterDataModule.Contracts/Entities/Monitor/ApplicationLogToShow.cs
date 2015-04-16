
using System;

namespace MasterDataModule.Contracts.Entities.Monitor
{
    public partial class ApplicationLogToShow : IHasId<int>, IRemovable, ISystemFields
    {
        /// <summary>
        /// Table name
        /// 
        /// </summary>
        public static readonly string EntityTableName = "dbo.GET_APPLICATION_LOGS";

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
            /// Column name 'LOG_LEVEL'  </summary>
            public static readonly string LogLevel = "LOG_LEVEL";

            /// <summary>
            /// Column name 'MESSAGE_DATE' 
            /// </summary>
            public static readonly string MessageDate = "MESSAGE_DATE";
            /// <summary>
            /// Column name 'MESSAGE' 
            /// </summary>
            public static readonly string Message = "MESSAGE";

            /// <summary>
            /// Column name 'FILE_NAME' 
            /// </summary>
            public static readonly string FileName = "FILE_NAME";
           

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

        public int LogTypeInfoId { get; set; }
        public int LogLevel { get; set; }
        public DateTime? MessageDate { get; set; }
        public string Message { get; set; }
        public string FileName { get; set; }
       
        public DateTime? DeleteDate { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public ApplicationLogToShow ShallowCopy()
        {
            return new ApplicationLogToShow
            {
                LogLevel = LogLevel,
                MessageDate = MessageDate,
                Message = Message,
                FileName = FileName,
                LogTypeInfoId = LogTypeInfoId
            };
        }

       
    }
}

