using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsStatisticGroup"/> entity
    /// </summary>
    [DataContract]
    public class InsStatisticGroupModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsStatisticGroup.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsStatisticGroup.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsStatisticGroup.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
