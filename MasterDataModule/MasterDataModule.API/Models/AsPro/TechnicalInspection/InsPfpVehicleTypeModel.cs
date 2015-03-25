using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsPfpVehicleType"/> entity
    /// </summary>
    [DataContract]
    public partial class InsPfpVehicleTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsPfpVehicleType.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpVehicleType.ImageFileName"/> entity
        /// </summary>
        [DataMember]
        public string imageFileName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpVehicleType.IsPolygonDataValid"/> entity
        /// </summary>
        [DataMember]
        public bool? isPolygonDataValid{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpVehicleType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpVehicleType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
