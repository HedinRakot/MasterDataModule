using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class GetApplicationLogs: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.GET_APPLICATION_LOGS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="GetApplicationLogs.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'LOG_LEVEL' for property <see cref="GetApplicationLogs.LogLevel"/>
            /// </summary>
            public static readonly string LogLevel = "LOG_LEVEL";
            /// <summary>
            /// Column name 'MESSAGE_DATE' for property <see cref="GetApplicationLogs.MessageDate"/>
            /// </summary>
            public static readonly string MessageDate = "MESSAGE_DATE";
            /// <summary>
            /// Column name 'MESSAGE' for property <see cref="GetApplicationLogs.Message"/>
            /// </summary>
            public static readonly string Message = "MESSAGE";
            /// <summary>
            /// Column name 'FILE_NAME' for property <see cref="GetApplicationLogs.FileName"/>
            /// </summary>
            public static readonly string FileName = "FILE_NAME";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="GetApplicationLogs.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="GetApplicationLogs.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="GetApplicationLogs.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'LOG_TYPE_INFO_ID' for property <see cref="GetApplicationLogs.LogTypeInfoId"/>
            /// </summary>
            public static readonly string LogTypeInfoId = "LOG_TYPE_INFO_ID";
          
        }
        #endregion
        public int Id{ get; set; }
        public int LogLevel{ get; set; }
        public DateTime? MessageDate{ get; set; }
        public string Message{ get; set; }
        public string FileName{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public int LogTypeInfoId{ get; set; }
        DateTime ISystemFields.CreateDate
        {
            get { return CreateDate; }
            set { CreateDate = value; }
        }
        DateTime ISystemFields.ChangeDate
        {
            get { return ChangeDate; }
            set { ChangeDate = value; }
        }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public GetApplicationLogs ShallowCopy()
        {
            return new GetApplicationLogs {
                       Id = Id,
                       LogLevel = LogLevel,
                       MessageDate = MessageDate,
                       Message = Message,
                       FileName = FileName,
                       DeleteDate = DeleteDate,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       LogTypeInfoId = LogTypeInfoId,
        	           };
        }
    }
}
