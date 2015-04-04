using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class ApplicationLogs: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.APPLICATION_LOGS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="ApplicationLogs.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'LOG_TYPE' for property <see cref="ApplicationLogs.LogType"/>
            /// </summary>
            public static readonly string LogType = "LOG_TYPE";
            /// <summary>
            /// Column name 'LOG_LEVEL' for property <see cref="ApplicationLogs.LogLevel"/>
            /// </summary>
            public static readonly string LogLevel = "LOG_LEVEL";
            /// <summary>
            /// Column name 'DATE' for property <see cref="ApplicationLogs.Date"/>
            /// </summary>
            public static readonly string Date = "DATE";
            /// <summary>
            /// Column name 'MESSAGE' for property <see cref="ApplicationLogs.Message"/>
            /// </summary>
            public static readonly string Message = "MESSAGE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="ApplicationLogs.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="ApplicationLogs.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="ApplicationLogs.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public int LogType{ get; set; }
        public int LogLevel{ get; set; }
        public DateTime? Date{ get; set; }
        public string Message{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime CreateDate{ get; set; }
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
        public ApplicationLogs ShallowCopy()
        {
            return new ApplicationLogs {
                       Id = Id,
                       LogType = LogType,
                       LogLevel = LogLevel,
                       Date = Date,
                       Message = Message,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       CreateDate = CreateDate,
        	           };
        }
    }
}
