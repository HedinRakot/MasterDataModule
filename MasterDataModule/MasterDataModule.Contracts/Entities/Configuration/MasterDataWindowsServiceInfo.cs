using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Windows Services Einstellungen  EN: Windows service info
    /// </summary>
    public partial class MasterDataWindowsServiceInfo: IHasId<int>
        ,IHasTitle<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_WINDOWS_SERVICE_INFO";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataWindowsServiceInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="MasterDataWindowsServiceInfo.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'MACHINE_NAME' for property <see cref="MasterDataWindowsServiceInfo.MachineName"/>
            /// </summary>
            public static readonly string MachineName = "MACHINE_NAME";
            /// <summary>
            /// Column name 'SERVICE_NAME' for property <see cref="MasterDataWindowsServiceInfo.ServiceName"/>
            /// </summary>
            public static readonly string ServiceName = "SERVICE_NAME";
            /// <summary>
            /// Column name 'TIMEOUT_CHECKING' for property <see cref="MasterDataWindowsServiceInfo.TimeoutChecking"/>
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataWindowsServiceInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataWindowsServiceInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataWindowsServiceInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataWindowsServiceInfo.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataWindowsServiceInfo.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'LOG_TYPE_INFO_ID' for property <see cref="MasterDataWindowsServiceInfo.LogTypeInfoId"/>
            /// </summary>
            public static readonly string LogTypeInfoId = "LOG_TYPE_INFO_ID";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Name  EN: Name
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: Machine Name  EN: Machine name
        /// </summary>
        public string MachineName{ get; set; }
        /// <summary>
        ///     DE: Windows-Service Name  EN: Service name
        /// </summary>
        public string ServiceName{ get; set; }
        /// <summary>
        ///     DE: Timeout  EN: Timeout checking
        /// </summary>
        public int TimeoutChecking{ get; set; }
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
        public int? LogTypeInfoId{ get; set; }
        public virtual ICollection<MasterDataWindowsServiceCheckResults> MasterDataWindowsServiceCheckResults{ get; set; }
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
            get { return Name; }
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
        public MasterDataWindowsServiceInfo ShallowCopy()
        {
            return new MasterDataWindowsServiceInfo {
                       Name = Name,
                       MachineName = MachineName,
                       ServiceName = ServiceName,
                       TimeoutChecking = TimeoutChecking,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
                       LogTypeInfoId = LogTypeInfoId,
        	           };
        }
    }
}
