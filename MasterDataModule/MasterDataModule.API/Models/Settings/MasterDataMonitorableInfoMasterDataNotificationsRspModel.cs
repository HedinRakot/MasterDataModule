using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.MonitorableInfoType"/> entity
        /// </summary>
        [DataMember]
        public int monitorableInfoType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.MonitorableInfoId"/> entity
        /// </summary>
        [DataMember]
        public int monitorableInfoId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataMonitorableInfoMasterDataNotificationsRsp.MasterDataNotificationsId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataNotificationsId{ get; set; }

    }
}
