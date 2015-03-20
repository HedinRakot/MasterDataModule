using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="Holiday"/> entity
    /// </summary>
    [DataContract]
    public partial class HolidayModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="Holiday.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Holiday.Date"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime date{ get; set; }

    }
}
