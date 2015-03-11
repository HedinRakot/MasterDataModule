using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsObdStatus"/> entity
    /// </summary>
    [DataContract]
    public class InsObdStatusModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsObdStatus.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsObdStatus.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsObdStatus.AuView"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string auView{ get; set; }

    }
}
