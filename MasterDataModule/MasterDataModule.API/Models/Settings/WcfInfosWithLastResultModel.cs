using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="WcfInfosWithLastResult"/> entity
    /// </summary>
    [DataContract]
    public partial class WcfInfosWithLastResultModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="WcfInfosWithLastResult.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="WcfInfosWithLastResult.LastResult"/> entity
        /// </summary>
        [DataMember]
        public int? lastResult{ get; set; }

    }
}
