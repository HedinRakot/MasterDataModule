using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsCoreDataProduct"/> entity
    /// </summary>
    public partial class InsCoreDataProductModel
    {
        [DataMember]
        public string productName { get; set; }

        [DataMember]
        public string productDescription { get; set; }
    }
}
