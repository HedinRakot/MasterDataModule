using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdFederalState"/> entity
    /// </summary>
    [DataContract]
    public class OrdFederalStateModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdFederalState.FederalStateName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string federalStateName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdFederalState.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdFederalState.SysCountryId"/> entity
        /// </summary>
        [DataMember]
        public int? sysCountryId{ get; set; }

    }
}