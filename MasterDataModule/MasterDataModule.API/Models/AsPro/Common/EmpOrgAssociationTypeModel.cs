using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="EmpOrgAssociationType"/> entity
    /// </summary>
    [DataContract]
    public class EmpOrgAssociationTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="EmpOrgAssociationType.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpOrgAssociationType.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }

    }
}
