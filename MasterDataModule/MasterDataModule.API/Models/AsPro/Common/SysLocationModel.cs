using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysLocation"/> entity
    /// </summary>
    [DataContract]
    public class SysLocationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysLocation.LocationCode"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string locationCode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLocation.LocationName"/> entity
        /// </summary>
        [DataMember]
        public string locationName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLocation.SysCountryId"/> entity
        /// </summary>
        [DataMember]
        public int? sysCountryId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLocation.OrdFederalStateId"/> entity
        /// </summary>
        [DataMember]
        public int? ordFederalStateId{ get; set; }

    }
}
