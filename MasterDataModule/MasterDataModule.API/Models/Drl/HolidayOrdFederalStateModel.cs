using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="HolidayOrdFederalState"/> entity
    /// </summary>
    [DataContract]
    public partial class HolidayOrdFederalStateModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="HolidayOrdFederalState.HolidayId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int holidayId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="HolidayOrdFederalState.OrdFederalStateId"/> entity
        /// </summary>
        [DataMember]
        public int ordFederalStateId{ get; set; }

    }
}
