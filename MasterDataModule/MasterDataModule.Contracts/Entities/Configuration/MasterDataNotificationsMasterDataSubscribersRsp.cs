using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataNotificationsMasterDataSubscribersRsp: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_NOTIFICATIONS_MASTER_DATA_SUBSCRIBERS_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataNotificationsMasterDataSubscribersRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'MASTER_DATA_NOTIFICATIONS_ID' for property <see cref="MasterDataNotificationsMasterDataSubscribersRsp.MasterDataNotificationsId"/>
            /// </summary>
            public static readonly string MasterDataNotificationsId = "MASTER_DATA_NOTIFICATIONS_ID";
            /// <summary>
            /// Column name 'MASTER_DATA_SUBSCRIBERS_ID' for property <see cref="MasterDataNotificationsMasterDataSubscribersRsp.MasterDataSubscribersId"/>
            /// </summary>
            public static readonly string MasterDataSubscribersId = "MASTER_DATA_SUBSCRIBERS_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataNotificationsMasterDataSubscribersRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataNotificationsMasterDataSubscribersRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataNotificationsMasterDataSubscribersRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public int MasterDataNotificationsId{ get; set; }
        public int MasterDataSubscribersId{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public virtual MasterDataSubscribers MasterDataSubscribers{ get; set; }
        public bool HasMasterDataSubscribers
        {
            get { return !ReferenceEquals(MasterDataSubscribers, null); }
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
        public MasterDataNotificationsMasterDataSubscribersRsp ShallowCopy()
        {
            return new MasterDataNotificationsMasterDataSubscribersRsp {
                       MasterDataNotificationsId = MasterDataNotificationsId,
                       MasterDataSubscribersId = MasterDataSubscribersId,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
        	           };
        }
    }
}
