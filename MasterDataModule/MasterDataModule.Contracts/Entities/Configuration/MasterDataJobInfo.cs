using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Hintergrundprozess Einstellungen  EN: Job info
    /// </summary>
    public partial class MasterDataJobInfo: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_JOB_INFO";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataJobInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'CONNECTION_STRING' for property <see cref="MasterDataJobInfo.ConnectionString"/>
            /// </summary>
            public static readonly string ConnectionString = "CONNECTION_STRING";
            /// <summary>
            /// Column name 'TABLE_NAME' for property <see cref="MasterDataJobInfo.TableName"/>
            /// </summary>
            public static readonly string TableName = "TABLE_NAME";
            /// <summary>
            /// Column name 'TIMEOUT_CHECKING' for property <see cref="MasterDataJobInfo.TimeoutChecking"/>
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";
            /// <summary>
            /// Column name 'NAME' for property <see cref="MasterDataJobInfo.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'JOB_NAME' for property <see cref="MasterDataJobInfo.JobName"/>
            /// </summary>
            public static readonly string JobName = "JOB_NAME";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataJobInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataJobInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataJobInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataJobInfo.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataJobInfo.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Connection string  EN: Connection string

        /// </summary>
        public string ConnectionString{ get; set; }
        /// <summary>
        ///     DE: Tabelle  EN: Table name

        /// </summary>
        public string TableName{ get; set; }
        /// <summary>
        ///     DE: Timeout checking  EN: Timeout checking

        /// </summary>
        public int TimeoutChecking{ get; set; }
        /// <summary>
        ///     DE: Name  EN: Name

        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: Hintergrundprozess Name  EN:  Job name

        /// </summary>
        public string JobName{ get; set; }
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
        public MasterDataJobInfo ShallowCopy()
        {
            return new MasterDataJobInfo {
                       ConnectionString = ConnectionString,
                       TableName = TableName,
                       TimeoutChecking = TimeoutChecking,
                       Name = Name,
                       JobName = JobName,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
