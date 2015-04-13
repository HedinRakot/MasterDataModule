using MasterDataModule.API.Validation;
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
        [Required]
        [DataMember]
        public int masterDataNotificationsId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotificationsMasterDataSubscribersRsp.MasterDataSubscribersId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int masterDataSubscribersId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotificationsMasterDataSubscribersRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotificationsMasterDataSubscribersRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
