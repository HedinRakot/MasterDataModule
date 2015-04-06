using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataWindowsServiceInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataWindowsServiceInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.MachineName"/> entity
        /// </summary>
        [DataMember]
        public string machineName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.ServiceName"/> entity
        /// </summary>
        [DataMember]
        public string serviceName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.TimeoutChecking"/> entity
        /// </summary>
        [DataMember]
        public int timeoutChecking{ get; set; }

    }
}
