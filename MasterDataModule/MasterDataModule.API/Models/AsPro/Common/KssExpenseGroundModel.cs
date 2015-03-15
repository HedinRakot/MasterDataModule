using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="KssExpenseGround"/> entity
    /// </summary>
    [DataContract]
    public class KssExpenseGroundModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="KssExpenseGround.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="KssExpenseGround.Account"/> entity
        /// </summary>
        [DataMember]
        public string account{ get; set; }
        /// <summary>
        ///     Model property for <see cref="KssExpenseGround.InsVatTypeId"/> entity
        /// </summary>
        [DataMember]
        public int? insVatTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="KssExpenseGround.MaxAmount"/> entity
        /// </summary>
        [DataMember]
        public decimal? maxAmount{ get; set; }
        /// <summary>
        ///     Model property for <see cref="KssExpenseGround.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="KssExpenseGround.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
