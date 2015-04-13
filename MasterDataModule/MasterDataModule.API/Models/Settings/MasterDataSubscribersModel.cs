using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataSubscribers"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataSubscribersModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataSubscribers.Email"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string email{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSubscribers.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSubscribers.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
