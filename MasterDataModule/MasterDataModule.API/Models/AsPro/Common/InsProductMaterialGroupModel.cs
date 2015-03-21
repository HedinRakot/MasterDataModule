using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsProductMaterialGroup"/> entity
    /// </summary>
    [DataContract]
    public partial class InsProductMaterialGroupModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsProductMaterialGroup.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductMaterialGroup.SapId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sapId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductMaterialGroup.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductMaterialGroup.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
