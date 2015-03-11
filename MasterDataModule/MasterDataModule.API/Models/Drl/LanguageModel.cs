using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="Language"/> entity
    /// </summary>
    [DataContract]
    public class LanguageModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="Language.SysLanguageId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysLanguageId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Language.OldAbbr"/> entity
        /// </summary>
        [DataMember]
        public string oldAbbr{ get; set; }

    }
}
