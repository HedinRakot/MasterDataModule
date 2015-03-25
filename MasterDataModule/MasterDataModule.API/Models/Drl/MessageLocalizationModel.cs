using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="MessageLocalization"/> entity
    /// </summary>
    [DataContract]
    public partial class MessageLocalizationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MessageLocalization.ValidationErrorNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int validationErrorNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MessageLocalization.SysLanguageId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysLanguageId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MessageLocalization.Message"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string message{ get; set; }

    }
}
