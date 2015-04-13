using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Windows Services Monitor  EN: Windows service check results
    /// </summary>
    public partial class MasterDataWindowsServiceCheckResults: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_WINDOWS_SERVICE_CHECK_RESULTS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataWindowsServiceCheckResults.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'CHECK_STATUS' for property <see cref="MasterDataWindowsServiceCheckResults.CheckStatus"/>
            /// </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";
            /// <summary>
            /// Column name 'CHECK_DATE' for property <see cref="MasterDataWindowsServiceCheckResults.CheckDate"/>
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";
            /// <summary>
            /// Column name 'MESSAGE' for property <see cref="MasterDataWindowsServiceCheckResults.Message"/>
            /// </summary>
            public static readonly string Message = "MESSAGE";
            /// <summary>
            /// Column name 'ATTEMPT' for property <see cref="MasterDataWindowsServiceCheckResults.Attempt"/>
            /// </summary>
            public static readonly string Attempt = "ATTEMPT";
            /// <summary>
            /// Column name 'MASTER_DATA_WINDOWS_SERVICE_INFO_ID' for property <see cref="MasterDataWindowsServiceCheckResults.MasterDataWindowsServiceInfoId"/>
            /// </summary>
            public static readonly string MasterDataWindowsServiceInfoId = "MASTER_DATA_WINDOWS_SERVICE_INFO_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataWindowsServiceCheckResults.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataWindowsServiceCheckResults.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataWindowsServiceCheckResults.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataWindowsServiceCheckResults.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataWindowsServiceCheckResults.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Status  EN: Status
        /// </summary>
        public int? CheckStatus{ get; set; }
        /// <summary>
        ///     DE: Prüfungsdatum  EN: Check date
        /// </summary>
        public DateTime? CheckDate{ get; set; }
        /// <summary>
        ///     DE: Nachricht  EN: Message
        /// </summary>
        public string Message{ get; set; }
        /// <summary>
        ///     DE: Zähler  EN: Attempt
        /// </summary>
        public int? Attempt{ get; set; }
        /// <summary>
        ///     DE: Windows-Service  EN: Windows service info
        /// </summary>
        public int MasterDataWindowsServiceInfoId{ get; set; }
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
        public virtual MasterDataWindowsServiceInfo MasterDataWindowsServiceInfo{ get; set; }
        public bool HasMasterDataWindowsServiceInfo
        {
            get { return !ReferenceEquals(MasterDataWindowsServiceInfo, null); }
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
        public MasterDataWindowsServiceCheckResults ShallowCopy()
        {
            return new MasterDataWindowsServiceCheckResults {
                       CheckStatus = CheckStatus,
                       CheckDate = CheckDate,
                       Message = Message,
                       Attempt = Attempt,
                       MasterDataWindowsServiceInfoId = MasterDataWindowsServiceInfoId,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
