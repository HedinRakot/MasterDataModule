using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Überwachungsnachrichten Einstellungen  EN: Monitorable object to notification
    /// </summary>
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRsp: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_MONITORABLE_INFO_MASTER_DATA_NOTIFICATIONS_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'MONITORABLE_INFO_TYPE' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.MonitorableInfoType"/>
            /// </summary>
            public static readonly string MonitorableInfoType = "MONITORABLE_INFO_TYPE";
            /// <summary>
            /// Column name 'MONITORABLE_INFO_ID' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.MonitorableInfoId"/>
            /// </summary>
            public static readonly string MonitorableInfoId = "MONITORABLE_INFO_ID";
            /// <summary>
            /// Column name 'MASTER_DATA_NOTIFICATIONS_ID' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.MasterDataNotificationsId"/>
            /// </summary>
            public static readonly string MasterDataNotificationsId = "MASTER_DATA_NOTIFICATIONS_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Überwachungsobjekt Typ  EN: Monitorable object type

        /// </summary>
        public int MonitorableInfoType{ get; set; }
        /// <summary>
        ///     DE: Überwachungsobjekt  EN: Monitorable object id

        /// </summary>
        public int MonitorableInfoId{ get; set; }
        /// <summary>
        ///     DE: Überwachungsnachricht  EN: Notification

        /// </summary>
        public int MasterDataNotificationsId{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
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
        public MasterDataMonitorableInfoMasterDataNotificationsRsp ShallowCopy()
        {
            return new MasterDataMonitorableInfoMasterDataNotificationsRsp {
                       MonitorableInfoType = MonitorableInfoType,
                       MonitorableInfoId = MonitorableInfoId,
                       MasterDataNotificationsId = MasterDataNotificationsId,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
