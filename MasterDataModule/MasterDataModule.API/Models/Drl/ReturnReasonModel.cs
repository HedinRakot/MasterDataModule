using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ReturnReason"/> entity
    /// </summary>
    [DataContract]
    public class ReturnReasonModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ReturnReason.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ReturnReason.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ReturnReason.Text1"/> entity
        /// </summary>
        [DataMember]
        public string text1{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ReturnReason.Text2"/> entity
        /// </summary>
        [DataMember]
        public string text2{ get; set; }

    }
}
