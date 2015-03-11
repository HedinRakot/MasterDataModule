using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsCoreDataProductGroup"/> entity
    /// </summary>
    [DataContract]
    public class InsCoreDataProductGroupModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductGroup.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductGroup.DefaultDuration"/> entity
        /// </summary>
        [DataMember]
        public long defaultDuration{ get; set; }

    }
}
