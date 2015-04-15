using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="LogTypeInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class LogTypeInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="LogTypeInfo.FileName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string fileName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LogTypeInfo.FilePattern"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string filePattern{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LogTypeInfo.FilePath"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string filePath{ get; set; }

    }
}
