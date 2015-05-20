using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class LogTypeInfo: IHasId<int>
        ,IHasTitle<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.LOG_TYPE_INFO";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="LogTypeInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="LogTypeInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="LogTypeInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="LogTypeInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="LogTypeInfo.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="LogTypeInfo.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'FILE_NAME' for property <see cref="LogTypeInfo.FileName"/>
            /// </summary>
            public static readonly string FileName = "FILE_NAME";
            /// <summary>
            /// Column name 'FILE_PATTERN' for property <see cref="LogTypeInfo.FilePattern"/>
            /// </summary>
            public static readonly string FilePattern = "FILE_PATTERN";
            /// <summary>
            /// Column name 'FILE_PATH' for property <see cref="LogTypeInfo.FilePath"/>
            /// </summary>
            public static readonly string FilePath = "FILE_PATH";
            /// <summary>
            /// Column name 'LAST_READ_DATE' for property <see cref="LogTypeInfo.LastReadDate"/>
            /// </summary>
            public static readonly string LastReadDate = "LAST_READ_DATE";
            /// <summary>
            /// Column name 'MESSAGE_PATTERN' for property <see cref="LogTypeInfo.MessagePattern"/>
            /// </summary>
            public static readonly string MessagePattern = "MESSAGE_PATTERN";
            /// <summary>
            /// Column name 'LAST_READ_POSITION' for property <see cref="LogTypeInfo.LastReadPosition"/>
            /// </summary>
            public static readonly string LastReadPosition = "LAST_READ_POSITION";
            /// <summary>
            /// Column name 'START_MESSAGE_PATTERN' for property <see cref="LogTypeInfo.StartMessagePattern"/>
            /// </summary>
            public static readonly string StartMessagePattern = "START_MESSAGE_PATTERN";
            /// <summary>
            /// Column name 'CHECKING_TIMEOUT' for property <see cref="LogTypeInfo.CheckingTimeout"/>
            /// </summary>
            public static readonly string CheckingTimeout = "CHECKING_TIMEOUT";
            /// <summary>
            /// Column name 'LAST_PROCESSED_FILE' for property <see cref="LogTypeInfo.LastProcessedFile"/>
            /// </summary>
            public static readonly string LastProcessedFile = "LAST_PROCESSED_FILE";
          
        }
        #endregion
        public int Id{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        /// <summary>
        ///     DE:Von Datum  EN:  Date from
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE:Bis Datum  EN:  Date to
        /// </summary>
        public DateTime ToDate{ get; set; }
        public string FileName{ get; set; }
        public string FilePattern{ get; set; }
        public string FilePath{ get; set; }
        public DateTime? LastReadDate{ get; set; }
        public string MessagePattern{ get; set; }
        public long? LastReadPosition{ get; set; }
        public string StartMessagePattern{ get; set; }
        public int? CheckingTimeout{ get; set; }
        public string LastProcessedFile{ get; set; }
        public virtual ICollection<ApplicationLogs> ApplicationLogs{ get; set; }
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
        string IHasTitle<int>.EntityTitle
        {
            get { return FileName; }
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
        public LogTypeInfo ShallowCopy()
        {
            return new LogTypeInfo {
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
                       FileName = FileName,
                       FilePattern = FilePattern,
                       FilePath = FilePath,
                       LastReadDate = LastReadDate,
                       MessagePattern = MessagePattern,
                       LastReadPosition = LastReadPosition,
                       StartMessagePattern = StartMessagePattern,
                       CheckingTimeout = CheckingTimeout,
                       LastProcessedFile = LastProcessedFile,
        	           };
        }
    }
}
