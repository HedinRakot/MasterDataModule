using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsNextInspection"/> entity
    /// </summary>
    [DataContract]
    public class InsNextInspectionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsNextInspection.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }

    }
}
