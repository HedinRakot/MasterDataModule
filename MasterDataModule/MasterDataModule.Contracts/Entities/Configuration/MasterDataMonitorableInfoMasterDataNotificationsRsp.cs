using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRsp: IHasId<int>
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
          
        }
        #endregion
        public int Id{ get; set; }
        public int MonitorableInfoType{ get; set; }
        public int MonitorableInfoId{ get; set; }
        public int MasterDataNotificationsId{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
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
        	           };
        }
    }
}
