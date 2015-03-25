using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsOpticalDefect"/> entity
    /// </summary>
    [DataContract]
    public partial class InsOpticalDefectModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsOpticalDefect.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsOpticalDefect.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsOpticalDefect.IsCustom"/> entity
        /// </summary>
        [DataMember]
        public bool isCustom{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsOpticalDefect.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsOpticalDefect.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
