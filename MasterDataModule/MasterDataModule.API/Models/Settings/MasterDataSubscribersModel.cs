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
        [DataMember]
        public string email{ get; set; }

    }
}
