using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataWcfInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataWcfInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.WsdlPath"/> entity
        /// </summary>
        [DataMember]
        public string wsdlPath{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.TimeoutChecking"/> entity
        /// </summary>
        [DataMember]
        public int timeoutChecking{ get; set; }

    }
}
