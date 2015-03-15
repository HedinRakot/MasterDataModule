using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsNextSpInterval"/> entity
    /// </summary>
    [DataContract]
    public class InsNextSpIntervalModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.InsProductObjectTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insProductObjectTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.InsProductObjectClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insProductObjectClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.AgeMonthFrom"/> entity
        /// </summary>
        [DataMember]
        public int ageMonthFrom{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.AgeMonthTo"/> entity
        /// </summary>
        [DataMember]
        public int? ageMonthTo{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.SpInterval"/> entity
        /// </summary>
        [DataMember]
        public int spInterval{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsNextSpInterval.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
