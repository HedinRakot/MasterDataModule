using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Überwachungsnachrichten  EN: Notifications
    /// </summary>
    public partial class MasterDataNotifications: IHasId<int>
        ,IHasTitle
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_NOTIFICATIONS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataNotifications.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NOTIFICATION_TYPE' for property <see cref="MasterDataNotifications.NotificationType"/>
            /// </summary>
            public static readonly string NotificationType = "NOTIFICATION_TYPE";
            /// <summary>
            /// Column name 'IS_ALERT_ON' for property <see cref="MasterDataNotifications.IsAlertOn"/>
            /// </summary>
            public static readonly string IsAlertOn = "IS_ALERT_ON";
            /// <summary>
            /// Column name 'ALERT_CHECK_STATUS' for property <see cref="MasterDataNotifications.AlertCheckStatus"/>
            /// </summary>
            public static readonly string AlertCheckStatus = "ALERT_CHECK_STATUS";
            /// <summary>
            /// Column name 'ALERT_ATTEMPT_COUNT' for property <see cref="MasterDataNotifications.AlertAttemptCount"/>
            /// </summary>
            public static readonly string AlertAttemptCount = "ALERT_ATTEMPT_COUNT";
            /// <summary>
            /// Column name 'MESSAGE' for property <see cref="MasterDataNotifications.Message"/>
            /// </summary>
            public static readonly string Message = "MESSAGE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataNotifications.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataNotifications.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataNotifications.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'SUBJECT' for property <see cref="MasterDataNotifications.Subject"/>
            /// </summary>
            public static readonly string Subject = "SUBJECT";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataNotifications.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataNotifications.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Überwachungsnachricht Typ  EN: Notification type
        /// </summary>
        public int NotificationType{ get; set; }
        /// <summary>
        ///     DE: Aktiv  EN: Is alert on
        /// </summary>
        public bool IsAlertOn{ get; set; }
        /// <summary>
        ///     DE: Status  EN: Check status for alert
        /// </summary>
        public int AlertCheckStatus{ get; set; }
        /// <summary>
        ///     DE: Versuchanzahl  EN: Attempt count for alert
        /// </summary>
        public int AlertAttemptCount{ get; set; }
        /// <summary>
        ///     DE: Nachricht  EN: Message
        /// </summary>
        public string Message{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        /// <summary>
        ///     DE: Thema  EN: Subject
        /// </summary>
        public string Subject{ get; set; }
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
        string IHasTitle.EntityTitle
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
        public MasterDataNotifications ShallowCopy()
        {
            return new MasterDataNotifications {
                       NotificationType = NotificationType,
                       IsAlertOn = IsAlertOn,
                       AlertCheckStatus = AlertCheckStatus,
                       AlertAttemptCount = AlertAttemptCount,
                       Message = Message,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       Subject = Subject,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
