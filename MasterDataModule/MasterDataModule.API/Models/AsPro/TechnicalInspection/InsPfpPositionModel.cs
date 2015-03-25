using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsPfpPosition"/> entity
    /// </summary>
    [DataContract]
    public partial class InsPfpPositionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsPfpPosition.Text"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string text{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpPosition.TopId"/> entity
        /// </summary>
        [DataMember]
        public int? topId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpPosition.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpPosition.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
