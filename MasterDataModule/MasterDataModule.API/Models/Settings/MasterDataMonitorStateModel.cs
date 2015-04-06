using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataMonitorState"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataMonitorStateModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataMonitorState.Reconfigure"/> entity
        /// </summary>
        [DataMember]
        public bool? reconfigure{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataMonitorState.ReconfigureCheckingTimeout"/> entity
        /// </summary>
        [DataMember]
        public int reconfigureCheckingTimeout{ get; set; }

    }
}
