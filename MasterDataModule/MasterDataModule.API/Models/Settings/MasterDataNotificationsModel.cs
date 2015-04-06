using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataNotifications"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataNotificationsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataNotifications.NotificationType"/> entity
        /// </summary>
        [DataMember]
        public int notificationType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotifications.IsAlertOn"/> entity
        /// </summary>
        [DataMember]
        public bool isAlertOn{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotifications.AlertCheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int alertCheckStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotifications.AlertAttemptCount"/> entity
        /// </summary>
        [DataMember]
        public int alertAttemptCount{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotifications.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataNotifications.Subject"/> entity
        /// </summary>
        [DataMember]
        public string subject{ get; set; }

    }
}
