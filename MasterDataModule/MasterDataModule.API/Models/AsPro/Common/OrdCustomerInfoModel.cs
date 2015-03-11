using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdCustomerInfo"/> entity
    /// </summary>
    [DataContract]
    public class OrdCustomerInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdCustomerInfo.TextValue"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string textValue{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdCustomerInfo.NumberValue"/> entity
        /// </summary>
        [DataMember]
        public int? numberValue{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdCustomerInfo.InfoType"/> entity
        /// </summary>
        [DataMember]
        public int infoType{ get; set; }

    }
}
