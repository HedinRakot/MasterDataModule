using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="SiteInfosWithLastResult"/> entity
    /// </summary>
    [DataContract]
    public partial class SiteInfosWithLastResultModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SiteInfosWithLastResult.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SiteInfosWithLastResult.LastResult"/> entity
        /// </summary>
        [DataMember]
        public int? lastResult{ get; set; }

    }
}
