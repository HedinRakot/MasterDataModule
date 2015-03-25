using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="User"/> entity
    /// </summary>
    [DataContract]
    public partial class UserModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="User.MasterDataRoleId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? masterDataRoleId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="User.Login"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string login{ get; set; }
        /// <summary>
        ///     Model property for <see cref="User.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="User.Password"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string password{ get; set; }
        /// <summary>
        ///     Model property for <see cref="User.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="User.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
