using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Hintergrundprozess Monitor  EN: Job check result
    /// </summary>
    public partial class MasterDataJobCheckResults: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_JOB_CHECK_RESULTS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataJobCheckResults.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'LAST_RUN_TIME' for property <see cref="MasterDataJobCheckResults.LastRunTime"/>
            /// </summary>
            public static readonly string LastRunTime = "LAST_RUN_TIME";
            /// <summary>
            /// Column name 'CHECK_DATE' for property <see cref="MasterDataJobCheckResults.CheckDate"/>
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";
            /// <summary>
            /// Column name 'CHECK_STATUS' for property <see cref="MasterDataJobCheckResults.CheckStatus"/>
            /// </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";
            /// <summary>
            /// Column name 'MASTER_DATA_JOB_INFO_ID' for property <see cref="MasterDataJobCheckResults.MasterDataJobInfoId"/>
            /// </summary>
            public static readonly string MasterDataJobInfoId = "MASTER_DATA_JOB_INFO_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataJobCheckResults.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataJobCheckResults.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataJobCheckResults.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataJobCheckResults.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataJobCheckResults.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Letztes Prüfungsdatum  EN: Last run time
        /// </summary>
        public DateTime? LastRunTime{ get; set; }
        /// <summary>
        ///     DE: Prüfungsdatum  EN: Check date
        /// </summary>
        public DateTime? CheckDate{ get; set; }
        /// <summary>
        ///     DE: Status  EN: Status
        /// </summary>
        public int? CheckStatus{ get; set; }
        /// <summary>
        ///     DE: Hintergrundprozess  EN: Job info
        /// </summary>
        public int MasterDataJobInfoId{ get; set; }
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
        public MasterDataJobCheckResults ShallowCopy()
        {
            return new MasterDataJobCheckResults {
                       LastRunTime = LastRunTime,
                       CheckDate = CheckDate,
                       CheckStatus = CheckStatus,
                       MasterDataJobInfoId = MasterDataJobInfoId,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
