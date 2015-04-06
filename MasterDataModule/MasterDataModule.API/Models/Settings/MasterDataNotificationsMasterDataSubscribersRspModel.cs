using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataNotificationsMasterDataSubscribersRsp"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataNotificationsMasterDataSubscribersRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataNotificationsMasterDataSubscribersRsp.MasterDataNotificationsId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataNotificationsId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotificationsMasterDataSubscribersRsp.MasterDataSubscribersId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataSubscribersId{ get; set; }

    }
}
