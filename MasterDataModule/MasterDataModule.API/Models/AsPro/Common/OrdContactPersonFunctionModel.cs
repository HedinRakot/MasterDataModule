using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdContactPersonFunction"/> entity
    /// </summary>
    [DataContract]
    public class OrdContactPersonFunctionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdContactPersonFunction.SapId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sapId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdContactPersonFunction.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdContactPersonFunction.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdContactPersonFunction.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
