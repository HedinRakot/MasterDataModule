using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Applikation-Logs  EN: Applications logs
    /// </summary>
    public partial class ApplicationLogs: IHasId<int>
        ,IIntervalFields
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
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="ApplicationLogs.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="ApplicationLogs.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'LOG_TYPE_INFO_ID' for property <see cref="ApplicationLogs.LogTypeInfoId"/>
            /// </summary>
            public static readonly string LogTypeInfoId = "LOG_TYPE_INFO_ID";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Log-Stufe  EN: logs level
        /// </summary>
        public int LogLevel{ get; set; }
        /// <summary>
        ///     DE: Datum  EN: Date
        /// </summary>
        public DateTime? Date{ get; set; }
        /// <summary>
        ///     DE: Text  EN: Text
        /// </summary>
        public string Message{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime CreateDate{ get; set; }
        /// <summary>
        ///     DE:Von Datum  EN:  Date from
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE:Bis Datum  EN:  Date to
        /// </summary>
        public DateTime ToDate{ get; set; }
        public int LogTypeInfoId{ get; set; }
        public virtual LogTypeInfo LogTypeInfo{ get; set; }
        public bool HasLogTypeInfo
        {
            get { return !ReferenceEquals(LogTypeInfo, null); }
        }
        DateTime? IIntervalFields.FromDate
        {
            get { return FromDate; }
            set { if(value.HasValue)FromDate = value.Value; else throw new ArgumentNullException("value"); }
        }
        DateTime? IIntervalFields.ToDate
        {
            get { return ToDate; }
            set { if(value.HasValue)ToDate = value.Value; else throw new ArgumentNullException("value"); }
        }
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
                       LogLevel = LogLevel,
                       Date = Date,
                       Message = Message,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       CreateDate = CreateDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
                       LogTypeInfoId = LogTypeInfoId,
        	           };
        }
    }
}
