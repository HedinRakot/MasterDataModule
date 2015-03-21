using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsProductObjectClass"/> entity
    /// </summary>
    [DataContract]
    public partial class InsProductObjectClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsProductObjectClass.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectClass.WeightFrom"/> entity
        /// </summary>
        [DataMember]
        public int? weightFrom{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductObjectClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
