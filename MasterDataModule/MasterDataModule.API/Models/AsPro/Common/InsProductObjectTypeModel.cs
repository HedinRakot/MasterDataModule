using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsProductObjectType"/> entity
    /// </summary>
    [DataContract]
    public class InsProductObjectTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsProductObjectType.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectType.SapId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sapId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectType.IsAuNecessary"/> entity
        /// </summary>
        [DataMember]
        public bool isAuNecessary{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
