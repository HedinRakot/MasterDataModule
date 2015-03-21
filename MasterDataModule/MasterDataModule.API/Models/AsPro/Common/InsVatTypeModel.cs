using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsVatType"/> entity
    /// </summary>
    [DataContract]
    public partial class InsVatTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsVatType.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsVatType.TaxCode"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string taxCode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsVatType.Percent"/> entity
        /// </summary>
        [DataMember]
        public decimal? percent{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsVatType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsVatType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
